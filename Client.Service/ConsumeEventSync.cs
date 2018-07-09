using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.Service
{
    class ConsumeEventSync
    {
        //chage here the port of the web api 
        public string hostservice = @"http://localhost:50889/api/values/";
        //
        public string PostSum(double[] numbers, string xid = "")
        {
            using (var client = new WebClient())
            {
                Parameters objtb = new Parameters();
                objtb.Numbers = numbers;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("xid:" + xid);
                var result = client.UploadString(hostservice + "Sum", JsonConvert.SerializeObject(objtb));
                return result;
            }
        }
        public string PostMult(double[] numbers, string xid = "")
        {
            using (var client = new WebClient())
            {
                Parameters objtb = new Parameters();
                objtb.Numbers = numbers;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("xid:" + xid);
                var result = client.UploadString(hostservice + "multiply", JsonConvert.SerializeObject(objtb));
                return result;
            }
        }
        public string PosDiv(double Dividend, double Divisor, string xid = "")
        {
            using (var client = new WebClient())
            {
                Parameters objtb = new Parameters();
                objtb.Dividend = Dividend;
                objtb.Divisor = Divisor;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("xid:" + xid);
                var result = client.UploadString(hostservice + "Div", JsonConvert.SerializeObject(objtb));
                return result;
            }
        }
        public string PosSub(double Minuend, double Subtrahend, string xid = "")
        {
            using (var client = new WebClient())
            {
                Parameters objtb = new Parameters();
                objtb.Minuend = Minuend;
                objtb.Subtrahend = Subtrahend;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("xid:" + xid);
                var result = client.UploadString(hostservice + "Sub", JsonConvert.SerializeObject(objtb));
                return result;
            }
        }
        public string PosSqr(double Sqr, string xid = "")
        {
            using (var client = new WebClient())
            {
                Parameters objtb = new Parameters();
                objtb.Sqr = Sqr;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("xid:" + xid);
                var result = client.UploadString(hostservice + "Sqr", JsonConvert.SerializeObject(objtb));
                return result;
            }
        }
        public string Posidx(string xid = "")
        {
            using (var client = new WebClient())
            {
                Parameters objtb = new Parameters();
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                client.Headers.Add("xid:" + xid);
                var result = client.UploadString(hostservice + "idx", JsonConvert.SerializeObject(objtb));
                return result;
            }
        }
    }
}
