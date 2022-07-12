using BackEnd_Task1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Task1.ViewModels
{
    public class HomeVM
    {
        public Heading Heading { get; set; }
        public List<Person> Person { get; set; }
    }
}
