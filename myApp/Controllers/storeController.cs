using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myApp.Controllers
{
    public class storeController : Controller
    {
        // GET: store
        public string Index()
        {
            return "yo";
        }
        public string brownse(string genre)
        {
            string message = 
                HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre); 
            return message;
        }
        public string fetch()
        {
            return "yo from 2";
        }

    }
}