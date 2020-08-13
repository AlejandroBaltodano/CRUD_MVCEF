using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_MVCEF.UI.Models.ViewModels
{
    public class PersonaViewModel
    {
        public int idPersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimineto { get; set; }

    }
}