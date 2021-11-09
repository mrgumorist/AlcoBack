using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEnd.ModelsDto
{
    public class GetByDateInModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}