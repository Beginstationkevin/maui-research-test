using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Models
{
    public class SuperHero
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string place { get; set; } = string.Empty;
        public SuperPower superPower { get; set; }
    }
}
