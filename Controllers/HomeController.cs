/*Take-home: Build an Activity Tracker Fullstack Web App

        In Visual Studio, build a basic fullstack Activity Tracker web application.Keep the model class simple(just a few fields like Id, Name, Date)
            1. Create a new ASP.NET Core(MVS) project in Visual Studio
            2. Add git version control to the project and link it to a Github repository(Make the repository public)
            3. Add all necessary NuGet packages, such as Microsofit.EntitFramworkCore, .SQLite, .Tools
            4. Build a Model Class
            5. Build a Context Class.
            6. Add a service to the Program.cs(the service look like the line below)
                builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite("Data Source=DatabaseName.db"));
            7. Code the Context class and add the model class DbSets
            8. Run database migrations to get the database created
            9. Code the controller class. Give it at least 3 methods:
                Index method to read and display all activity
                Create method to direct the user to the “Create” page
                Create(POST) method to save new activities in the database
            10. Build the View pages: Home page(Index) to list all activities and Create page
            11. Modify the _Layout.cshtml file (under the Views >> Shared folder) and add a “Create” button on the navigation bar that will take the user to the “Create” page to enter input data into the form and submit for new activity creation
            12. Run and test the app, improve and fix anything that needs to be fixed. Then push to a public Github repository(repo) and submit the repo link in the take home exam answer field below! 
*/
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Xml.Linq;
using CWK_GeaduationExam7_TakeHomeProject.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CWK_GeaduationExam7_TakeHomeProject.Controllers
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
            return View();
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
