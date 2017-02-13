using System;
using System.Collections.Generic;

namespace Ls.DataAccess.Models
{
    public partial class ls_user_duty
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int duty_id { get; set; }
    }
}
