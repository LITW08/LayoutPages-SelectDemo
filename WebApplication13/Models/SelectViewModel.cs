using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication13.Models
{
    public class SelectViewModel
    {
        public string Color { get; set; }
    }

    public class SelectColor
    {
        public int Id { get; set; }
        public string Color { get; set; }
    }
    
    public class DisplaySelectViewModel
    {
        public List<SelectColor> Colors { get; set; }
    }
}
