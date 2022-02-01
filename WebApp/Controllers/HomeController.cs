using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;
using WebApp.Models.Predpr;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static List<Factory>  factories = new List<Factory>();
        DataBaseContext db;

        public HomeController(DataBaseContext context,ILogger<HomeController> logger)
        {
            db = context;
            _logger = logger;
        }

        public  IActionResult Index()
        {            
            return View();
        }

        public IActionResult Search(SelectedFactory selectedFactory) 
        {
            if (ModelState.IsValid)
            {
                factories.Clear();
                try
                {
                    Run(selectedFactory.Vnaim);
                }
                catch(Exception ex)
                {
                    return View(ex.Message);
                }
                foreach(var item in factories)
                {
                    db.Factories.Add(item);
                    db.SaveChanges();
                }
                return View(factories);
            }
            return NotFound();
           
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

        private static void Run(string vnaim)
        {
            string webResponseString;
            WebRequest request = WebRequest.Create($"https://egr.gov.by/api/v2/egr/getShortInfoByRegName/{vnaim}");
            request.Method = WebRequestMethods.Http.Get;

            using (WebResponse response = request.GetResponse())
            {
               using (Stream stream = response.GetResponseStream())
               {
                  StreamReader reader = new StreamReader(stream);
                  webResponseString = reader.ReadToEnd();
               }
            }

            List<NaimFactory> naimFactories = JsonConvert.DeserializeObject<List<NaimFactory>>(webResponseString);
            foreach (var item in naimFactories)
            {
                request = WebRequest.Create($"https://egr.gov.by/api/v2/egr/getBaseInfoByRegNum/{item.ngrn}");
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        webResponseString = reader.ReadToEnd();
                    }
                }
                List<Factory> result = JsonConvert.DeserializeObject<List<Factory>>(webResponseString);
                factories.Add(new Factory()
                {
                    vnaim = item.vnaim,
                    dfrom = result[0].dfrom,
                    dto = result[0].dto,
                    ngrn = result[0].ngrn,
                    nsi00219 = result[0].nsi00219,
                    nsi00212CRT = result[0].nsi00212CRT,
                    nsi00208 = result[0].nsi00208,
                    nsi00211 = result[0].nsi00211,
                    nsi00212 = result[0].nsi00212,
                    nsi00212LKV = result[0].nsi00212LKV,
                    nsi00228 = result[0].nsi00228,
                    vnrlkv = result[0].vnrlkv
                });
            }
        }
    }
}
