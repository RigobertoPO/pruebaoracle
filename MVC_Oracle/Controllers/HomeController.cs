using MVC_Oracle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Oracle.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            try
            {
                using (var conexion = new EntitiesOracle())
                {
                    var _clientes = (from c in conexion.CLIENTES select c);
                    return View(_clientes.ToList());
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}