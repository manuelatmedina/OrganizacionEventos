using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrganizacionEventos.Shared.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Lastname { get; set; }
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        public string? Address { get; set; }



        //Colecciòn de Customer
        [JsonIgnore]
        public ICollection<Contract>? Contracts { get; set; }
         
    }
}
