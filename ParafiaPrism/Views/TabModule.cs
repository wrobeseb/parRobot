using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ParafiaPrism.Views
{
    public sealed class TabModule : IModule
    {
        private IRegionManager regionManager;

        public TabModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.AddToRegion("TabRegion", "dgdgfdf").AddToRegion("TabRegion", "sdfgdgfsdgf");
        }
    }
}
