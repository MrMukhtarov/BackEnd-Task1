using BackEnd_Task1.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Task1.Models
{
    public class Heading : BaseEntity
    {
        public string Title { get; set; }
        public string Desc { get; set; }
       

    }
}
