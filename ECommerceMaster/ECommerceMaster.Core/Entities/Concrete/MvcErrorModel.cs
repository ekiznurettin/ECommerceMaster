﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceMaster.Core.Entities.Concrete
{
    public class MvcErrorModel
    {
        public string Message { get; set; }
        public string Detail { get; set; }
        public string StatusCode { get; set; }
    }
}
