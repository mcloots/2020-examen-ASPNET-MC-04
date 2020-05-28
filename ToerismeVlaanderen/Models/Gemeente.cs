using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToerismeVlaanderen.Models
{
	public class Gemeente
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int GemeenteID { get; set; }
		public string Naam { get; set; }
		public int ProvincieID { get; set; }

		public ICollection<Activiteit> Activiteiten { get; set; }
		public Provincie Provincie { get; set; }
	}
}
