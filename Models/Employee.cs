﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CURD27.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
    }
}