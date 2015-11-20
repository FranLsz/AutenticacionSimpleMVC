using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticacionSimple.Models
{
    public class Usuario
    {
        [DisplayName("Nombre de usuario")]
        public String Login { get; set; }

        [DisplayName("Contraseña")]
        public String Password { get; set; }
    }
}
