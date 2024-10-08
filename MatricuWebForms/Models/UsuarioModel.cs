using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatricuWebForms.Models
{
    public class UsuarioModel
    {
        #region atributos
        public int ID { get; set; }
        public String NICKNAME { get; set; }
        public String CORREO { get; set; }
        public String CONTRASENNA { get; set; }
        public String ROL { get; set; }
        public String ADICIONADOPOR { get; set; }
        public DateTime FECHAADICION { get; set; }
        public String MODIFICADOPOR { get; set; }
        public DateTime FECHAMODIFICACION { get; set; }
        #endregion

        public UsuarioModel()
        {
            
        }
    }
}