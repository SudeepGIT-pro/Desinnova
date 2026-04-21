using Desinnova.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Desinnova.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Holidays = new List<Holiday>
                {
                    new Holiday { SerialNo = 1, Name = "New Year", Date = new DateTime(2026, 1, 1), Day = "Thursday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 2, Name = "Pongal", Date = new DateTime(2026, 1, 14), Day = "Wednesday", Location = "Tamil nadu" },
                    new Holiday { SerialNo = 3, Name = "Thiruvalluvar Day", Date = new DateTime(2026, 1, 15), Day = "Thursday", Location = "Tamil nadu" },
                    new Holiday { SerialNo = 4, Name = "Republic Day", Date = new DateTime(2026, 1, 26), Day = "Monday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 5, Name = "Ramzan/Eid al-Fitr", Date = new DateTime(2026, 3, 21), Day = "Friday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 6, Name = "Good Friday", Date = new DateTime(2026, 4, 3), Day = "Friday", Location = "Kerala" },
                    new Holiday { SerialNo = 7, Name = "Tamil New Year/Vishu", Date = new DateTime(2026, 4, 14), Day = "Monday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 8, Name = "May Day", Date = new DateTime(2026, 5, 1), Day = "Friday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 9, Name = "Bakrid/Eid Al Adha", Date = new DateTime(2026, 5, 27), Day = "Wednesday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 10, Name = "Independence day", Date = new DateTime(2026, 8, 15), Day = "Saturday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 11, Name = "First Onam", Date = new DateTime(2026, 8, 25), Day = "Tuesday", Location = "Kerala" },
                    new Holiday { SerialNo = 12, Name = "Thiruvonam", Date = new DateTime(2026, 8, 26), Day = "Wednesday", Location = "Kerala" },
                    new Holiday { SerialNo = 13, Name = "Ganesh Chaturthi", Date = new DateTime(2026, 9, 14), Day = "Monday", Location = "Kerala" },
                    new Holiday { SerialNo = 14, Name = "Gandhi Jayanthi", Date = new DateTime(2026, 10, 2), Day = "Friday", Location = "Tamil nadu and Kerala" },
                    new Holiday { SerialNo = 15, Name = "Maha Navami", Date = new DateTime(2026, 10, 20), Day = "Tuesday", Location = "Kerala" },
                    new Holiday { SerialNo = 16, Name = "Vijayadhasami", Date = new DateTime(2026, 10, 21), Day = "Wednesday", Location = "Tamil nadu" },
                    new Holiday { SerialNo = 17, Name = "Diwali", Date = new DateTime(2026, 11, 8), Day = "Sunday", Location = "Tamil nadu" },
                    new Holiday { SerialNo = 18, Name = "Christmas", Date = new DateTime(2026, 12, 25), Day = "Friday", Location = "Tamil nadu and Kerala" }
                },
                StaffList = new List<Staff>
                {
                    new Staff { SerialNo = 1, Name = "K Bhama", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" },
                    new Staff { SerialNo = 2, Name = "N Prasanth", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" },
                    new Staff { SerialNo = 3, Name = "Ra Santhosh", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" },
                    new Staff { SerialNo = 4, Name = "Tony", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Kerala" },
                    new Staff { SerialNo = 5, Name = "Santhosh", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" },
                    new Staff { SerialNo = 6, Name = "Prasanna", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" },
                    new Staff { SerialNo = 7, Name = "Kalaivani", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" },
                    new Staff { SerialNo = 8, Name = "Stephany", StartDate = new DateTime(2025, 7, 14), EndDate = null, Location = "Tamil nadu" }
                }
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
