using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1DriverMananger.Models
{
    internal class Driver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }
        public int Race_Wins { get; set; }
    }
}
