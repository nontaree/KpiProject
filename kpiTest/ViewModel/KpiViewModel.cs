using kpiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kpiTest.ViewModel
{
    public class KpiViewModel
    {
        public kpi_Perfomance performance { get; set; }
        public kpi_PerfomanceKey performanceKey { get; set; }
        public kpi_Year kpiYear { get; set; }
    }
}