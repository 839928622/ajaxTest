using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SavaMutiData.ViewModels
{
    public class School
    {
        public string Name { get; set; }
        public ICollection<Fee> Fee { get; set; }

    }
}