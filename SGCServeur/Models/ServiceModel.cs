using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SGCServeur.Models
{
    public class ServiceModel
    {
        [Key]
        [Required]
        [Description("Le code du service (Identifiant Unique)")]
        public string code { get; set; }

        [Key]
        [Required]
        [Description("")]
        public string libelle { get; set; }
    }
}
