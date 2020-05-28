using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToerismeVlaanderen.Data;
using ToerismeVlaanderen.Models;

namespace ToerismeVlaanderen.Controllers
{
	public class Vraag2Controller : Controller
	{
		private readonly VLContext _context;

		public Vraag2Controller(VLContext context)
		{
			_context = context;
		}

	}
}
