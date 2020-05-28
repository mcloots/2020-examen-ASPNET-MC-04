using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToerismeVlaanderen.Models
{
	public class Inschrijving
	{
		public int InschrijvingID { get; set; }
		public string Naam { get; set; }
		public string Email { get; set; }
		public int ActiviteitID { get; set; }

		public Activiteit Activiteit { get; set; }
	}
}
