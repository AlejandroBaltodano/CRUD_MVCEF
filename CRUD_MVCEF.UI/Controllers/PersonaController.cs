using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_MVCEF.UI.Models;

namespace CRUD_MVCEF.UI.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Models.ViewModels.PersonaViewModel> list;
            using (CRUBPersonaEFEntities db = new CRUBPersonaEFEntities())
            {
                    list = (from d in db.Persona
                            select new Models.ViewModels.PersonaViewModel
                            {
                                idPersona = d.idPersona,
                                Nombre = d.Nombre,
                                Cedula = d.Cedula,
                                FechaNacimineto = d.FechaNacimiento

                            }).ToList();


            }


                return View(list);
        }
    }
}