using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionZoho.ServiceFusionAPI.Models
{
    public class JobStatusView
    {
        public string id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string is_custom { get; set; }
        public string category { get; set; }
        public List<string> _expandable { get; set; }

    }
}
