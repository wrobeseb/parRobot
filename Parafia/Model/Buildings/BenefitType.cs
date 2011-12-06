using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parafia.Model.Buildings
{
    [Flags]
    public enum BenefitType
    {
        BELIVER_NO, VIKAR_NO, BELIVER_GAIN,
        ENERGY_NO, HEALTH_NO, UNIT_1, UNIT_2, UNIT_3, UNIT_4, UNIT_5, UNIT_6,
        CASH_MAX, CASH_GAIN, ENERGY_GAIN, HEALTH_GAIN,
    }
}
