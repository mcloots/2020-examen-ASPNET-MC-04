using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToerismeVlaanderen.Models
{
	public class Activiteit
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ActiviteitID { get; set; }
		public string Naam { get; set; }
		public DateTime Datum { get; set; }
		public int MaxPersonen { get; set; }
		public int GemeenteID { get; set; }

		public ICollection<Inschrijving> Inschrijvingen { get; set; }
		public Gemeente Gemeente { get; set; }

	}
}
