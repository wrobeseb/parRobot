using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Logging;

namespace ParafiaPrism
{
    public class BootStrapper : UnityBootstrapper
    {
        private readonly CallbackLogger callbackLogger = new CallbackLogger();

        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override ILoggerFacade CreateLogger()
        {
            return this.callbackLogger;
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            this.Container.RegisterInstance<CallbackLogger>(this.callbackLogger);
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new AggregateModuleCatalog();
        }

        protected override void ConfigureModuleCatalog()
        {
            ((AggregateModuleCatalog)ModuleCatalog).AddCatalog(new ConfigurationModuleCatalog());
        }
    }
}
