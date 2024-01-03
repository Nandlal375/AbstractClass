using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateHtmlHelper.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }
    }
}