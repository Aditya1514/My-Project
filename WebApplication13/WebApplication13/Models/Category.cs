﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication13.Models
{
    public class Category
    {
        [Key]
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}