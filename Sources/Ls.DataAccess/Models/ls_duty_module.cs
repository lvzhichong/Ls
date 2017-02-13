using System;
using System.Collections.Generic;

namespace Ls.DataAccess.Models
{
    public partial class ls_duty_module
    {
        public int id { get; set; }
        public int duty_id { get; set; }
        public int module_id { get; set; }
        public string duty_module_roles { get; set; }
    }
}
