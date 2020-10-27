﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ArchivoDePasaportes.Models
{
    public class Ticket
    {
        public long Id { get; set; }

        [Required]
        [Display(Name = "País Origen")]
        public byte OriginCountryId { get; set; }
        public Country OriginCountry { get; set; }

        [Required]
        [Display(Name = "País Destino")]
        public byte DestinyCountryId { get; set; }
        public Country DestinyCountry { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Regreso")]
        public DateTime DepartureDate { get; set; }
    }
}
