using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizacionEventos.Shared.Entities
{
    public class Contract
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int IdCustomer {  get; set; }
        public Event Event { get; set; }
        public int IdEvent { get; set; }

        [Required]
        public string Date {  get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

    }
}
