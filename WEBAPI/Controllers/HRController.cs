using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    
    [Route("[controller]")]
    [ApiController]
    public class HRController : ControllerBase
    {

        private readonly HRContext _context;

        public HRController(HRContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        //Exemple1

        //[HttpGet]

        //public string GetHR()
        //{
        //    return "OK.";
        //}

        //Exemple2
        [HttpGet]
        public IEnumerable<Employe> GetAllEmployees()
        {
            return _context.Employes.ToList();
        }
    }
}
