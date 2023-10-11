using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizacionEventos.Shared.Entities
{
    public class EmployeeEvent
    {
        public int Id { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public Event Event { get; set; }
        public int EventId { get; set; }

        [Required]
        public string AssignmentDate { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string EmployeeRole { get; set; }

    }
}
