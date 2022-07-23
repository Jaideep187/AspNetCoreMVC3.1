using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webgentle.BookStore.Controllers
{
    public class Home: Controller
    {
        public string Index()
        {
            return "Webgentle";
        }
    }
}
