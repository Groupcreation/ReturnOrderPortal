using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ReturnOrderPortal.DataContext;
using ReturnOrderPortal.Models;

namespace ReturnOrderPortal.Controllers
{

    public class UserController : Controller
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(UserController));
        static string TokenForLogin;
        private readonly ProcessContext db;
        public static ProcessResponse Response = new ProcessResponse();
        private IConfiguration _config;

       
        public UserController(ProcessContext context, IConfiguration config)
        {
            db = context;
            _config = config;
        }

        public IActionResult Login()
        {
            _log4net.Info("Login initiated");
            
                
                var user = new User();
           
            return View("Login", user);
            
           

        }


        //Token is being generated using Authorization MicroService
        public ActionResult Authentication(User user)
        {
            try
            {


                _log4net.Info("Authentication initiated");
                // TokenForLogin = GetToken("http://localhost:65486/api/token", user);
                TokenForLogin = GetToken(_config["Links:AuthorizationMicroService"] + "/token", user);
                _log4net.Info("Authorization URI invoked http://52.141.211.78/api");
                _log4net.Info("Token recieved From Authentication MicroService");

                if (TokenForLogin == null)
                {
                    _log4net.Info("Login Failed");
                    ViewBag.Message = String.Format("Invalid Username Or Password");
                    return View("Login", user);
                }
                //return Content("Login Successful");
                _log4net.Info("Authentication Successful And Login Completed");
                var ComponentModel = new Component();
                return View("ComponentProcessing");
            }
            catch (Exception ex)
            {
                _log4net.Info("Exception In Authentication ActionResult");
                return View("Error1",ex);
            }
        }




        
        //Form is being filled by the user and the form data is being sent to Component Microservice
        public async Task<ActionResult> ComponentProcessing(Component component)
        {
            try
            {


                _log4net.Info("ComponentProcessingMicroservice initiated");
                string Results;
                using (var client = new HttpClient())
                {
                    Component components = new Component
                    {
                        Name = component.Name,
                        ContactNumber = component.ContactNumber,
                        CreditCardNumber = component.CreditCardNumber,
                        ComponentType = component.ComponentType,
                        ComponentName = component.ComponentName,
                        Quantity = component.Quantity,
                        IsPriorityRequest = component.IsPriorityRequest
                    };

                    // client.DefaultRequestHeaders.Accept.Clear();
                    _log4net.Info("Token added to header");
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenForLogin);
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var myJSON = JsonConvert.SerializeObject(components);


                    string uri = string.Format("https://localhost:44392/api/ComponentProcessingMicroservice?json={0}", myJSON);
                   // string uri = string.Format(_config["Links:ComponentMicroService"] + "/ComponentProcessingMicroservice?json={0}", myJSON);
                    _log4net.Info("Component Microservice uri invoked http://52.154.250.90/api");
                    HttpResponseMessage response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode)
                    {
                        Results = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        Results = null;
                    }
                }
                _log4net.Info("Response Received From Component Microservice");
                Response = JsonConvert.DeserializeObject<ProcessResponse>(Results);


                return View("ProcessResponse", Response);
            }
            catch (Exception ex)
            {
                _log4net.Info("Exception In Component ActionResult");
                return View("Error1", ex);
            }


        }




       




        //User will confirm if he wants to Confirm the payment or not
        public async Task<ActionResult> Confirmation()
        {
            try
            {


                _log4net.Info("Payment Confirmation initiated");
                Submission res = new Submission()
                {
                    Result = "True"
                };
                string name = "";

                dynamic details = "";
                var abc = JsonConvert.SerializeObject(res);
                var data = new StringContent(abc, Encoding.UTF8, "application/json");

                using (var client = new HttpClient())
                {

                    _log4net.Info("Confirmation sent to Component Microservice For Payment");
                    // var response = await client.PostAsync("https://localhost:44392/api/ComponentProcessingMicroservice", data);
                    var response = await client.PostAsync(_config["Links:ComponentMicroService"] + "/ComponentProcessingMicroservice", data);

                    _log4net.Info("Component Microservice uri invoked http://52.154.250.90/api");


                    name = response.Content.ReadAsStringAsync().Result;


                }
                _log4net.Info("Success or failed Message received from Component Moicroservice");
                string x = (string)name;
                if (x == "Success")
                {
                    _log4net.Info("Respose added to db ");
                    db.ProcessDb.Add(Response);
                    db.SaveChanges();
                    return View("Confirmation",Response);
                }
                else
                    return View("Failed");
            }
            catch (Exception ex)
            {
                _log4net.Info("Exception In Confirmation ActionResult");
                return View("Error1", ex);
            }

        }

        




        static string GetToken(string url, User user)
        {
           
            var json = JsonConvert.SerializeObject(user);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(url, data).Result;
                string name = response.Content.ReadAsStringAsync().Result;
                dynamic details = JObject.Parse(name);
                return details.token;
            }
        }
    }
}
