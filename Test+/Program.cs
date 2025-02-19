using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RestClient restClient = new RestClient("https://api.api-ninjas.com/v1/cars");

            RestRequest restRequest = new RestRequest("", Method.Get);

            var response = restClient.Execute(restRequest);
        }
    }
}
