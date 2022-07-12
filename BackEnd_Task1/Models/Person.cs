using BackEnd_Task1.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Task1.Models
{
    public class Person : BaseEntity
    {
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }
        public string BoxText { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
