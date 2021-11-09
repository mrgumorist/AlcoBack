using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.ModelsDto
{
    public class OutProductModel
    {
        public string Name { get; set; }
        public string SpecialCode { get; set; }
        public double Count { get; set; } = 0;
    }
}