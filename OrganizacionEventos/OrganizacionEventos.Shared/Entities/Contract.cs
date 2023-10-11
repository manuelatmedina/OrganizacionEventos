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
        public int CustomerId {  get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }

        [Required]
        public string Date {  get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

    }
}
