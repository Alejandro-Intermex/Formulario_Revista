using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using revistas.Models;


namespace revistas.data
{
	public class ApplicationDBContext : DbContext
	{
	
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) :base (options)
        {

        }

		public DbSet<Usuario> Usuario { get; set; }

	}
}