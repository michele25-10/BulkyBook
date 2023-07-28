using BulkyBookWeb.Controllers.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db; 


        //Si connette al database
        public CategoryController(ApplicationDbContext db)
        {
            _db = db; 
        }
        public IActionResult Index()
        {
            //Fa praticamente una get di tutta la tabella categories e prende tutti i dati presenti all'interno
            IEnumerable<Category> objCategoryList = _db.Categories.ToList(); 
            return View(objCategoryList);
        }
    }
}
