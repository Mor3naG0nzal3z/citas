using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Gestion_de_Citas
{
    public class Citas
    {

        public string Id { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddThh:mm:ss}")]
        [Display(Name = "Registra tu Cita")]
        public DateTime citas { get; set; }
    }
}  