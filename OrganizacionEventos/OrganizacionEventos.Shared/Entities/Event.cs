using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrganizacionEventos.Shared.Entities
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }


        //Colecciòn de eventos
        [JsonIgnore]
        public ICollection<Contract>? Contracts { get; set; }
        [JsonIgnore]
        public ICollection<ServiceEvent>? serviceEvents { get; set; }
        [JsonIgnore]
        public ICollection<EmployeeEvent>? EmployeeEvents { get; set; }

    }
}
