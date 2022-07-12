using BackEnd_Task1.Models;
using BackEnd_Task1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd_Task1.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Heading heading = GetHeading();
            List<Person> person = GetPersons();
            HomeVM model = new HomeVM 
            {
                Heading = heading,
                Person = person
            };
            return View(model);
        }

        public Heading GetHeading()
        {
            Heading heading = new Heading
            {
                Id = 1,
                Title = "Testimonials",
                Desc = "Necessitatibus eius consequatur ex aliquid fuga eum quidem"
            };
            return heading;
        }

        public List<Person> GetPersons()
        {
            List<Person> person = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Icon1 = "bx bxs-quote-alt-left quote-icon-left",
                    BoxText = "Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper",
                    Icon2 = "bx bxs-quote-alt-right quote-icon-right",
                    Image = "https://bootstrapmade.com/demo/templates/Lumia/assets/img/testimonials/testimonials-1.jpg",
                    Name = "Saul Goodman",
                    Position = "Ceo &amp; Founder"
                },
                new Person
                {
                    Id = 2,
                    Icon1 = "bx bxs-quote-alt-left quote-icon-left",
                    BoxText = "Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis quorum velit fore eram velit sunt aliqua noster fugiat irure amet legam anim culpa.",
                    Icon2 = "bx bxs-quote-alt-right quote-icon-right",
                    Image = "https://bootstrapmade.com/demo/templates/Lumia/assets/img/testimonials/testimonials-2.jpg",
                    Name = "Sara Wilsson",
                    Position = "Designer"
                },
                new Person
                {
                    Id = 3,
                    Icon1 = "bx bxs-quote-alt-left quote-icon-left",
                    BoxText = "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
                    Icon2 = "bx bxs-quote-alt-right quote-icon-right",
                    Image = "https://bootstrapmade.com/demo/templates/Lumia/assets/img/testimonials/testimonials-3.jpg",
                    Name = "Jena Karlis",
                    Position = "Store Owner"
                },
                new Person
                {
                    Id = 4,
                    Icon1 = "bx bxs-quote-alt-left quote-icon-left",
                    BoxText = " Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore labore illum veniam.",
                    Icon2 = "bx bxs-quote-alt-right quote-icon-right",
                    Image = "https://bootstrapmade.com/demo/templates/Lumia/assets/img/testimonials/testimonials-4.jpg",
                    Name = "Matt Brandon",
                    Position = "Freelancer"
                },
                new Person
                {
                    Id = 5,
                    Icon1 = "bx bxs-quote-alt-left quote-icon-left",
                    BoxText = "Quis quorum aliqua sint quem legam fore sunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid.",
                    Icon2 = "bx bxs-quote-alt-right quote-icon-right",
                    Image = "https://bootstrapmade.com/demo/templates/Lumia/assets/img/testimonials/testimonials-5.jpg",
                    Name = "John Larson",
                    Position = "Entrepreneur"
                }

            };
            return person;
        }

    }
}
