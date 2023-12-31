﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrganizacionEventos.Shared.Entities
{
    public class ServiceEvent
    {
        public int Id { get; set; }

        [JsonIgnore]
        public Service? Service { get; set; }
        public int ServiceId { get; set; }

        [JsonIgnore]
        public Event? Event { get; set; }
        public int EventId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

    }
}
