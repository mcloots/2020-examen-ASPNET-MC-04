using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToerismeVlaanderen.Models
{
	public class Provincie
	{
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int ProvincieID { get; set; }
		public string Naam { get; set; }

		public ICollection<Gemeente> Gemeentes { get; set; }
	}
}
