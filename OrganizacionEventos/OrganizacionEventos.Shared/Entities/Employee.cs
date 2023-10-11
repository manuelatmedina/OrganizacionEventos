using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizacionEventos.Shared.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Lastname { get; set; }

        [Required]
        [MaxLength(10)]
        public string? Phone { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        public string? Position { get; set; }

        //Colecciòn de empleados
        public ICollection<EmployeeEvent> EmployeeEvents { get; set; }

    }
}
