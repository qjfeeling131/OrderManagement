﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManager.Web.Models
{
    public class ErrorModel
    {
        public string Title { get; set; }

        public string Message { get; set; }

        public string Type { get; set; }

        public string Target { get; set; }
    }
}