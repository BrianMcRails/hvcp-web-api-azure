using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hvcp_web_api.Models;

namespace hvcp_web_api.Entities
{
	using Microsoft.EntityFrameworkCore;
    public class StudyInfoContext : DbContext
    {
	    public StudyInfoContext(DbContextOptions<StudyInfoContext> options)
			: base(options)
	    { 
	    }

	    public DbSet<Demographics> Demographics { get; set; }

	    public DbSet<Dicomstudies> Dicomstudies { get; set; }

	    public DbSet<Dicomseries> Dicomseries { get; set; }

		public DbSet<Dicomimages> Dicomimages { get; set; }

		public DbSet<Sssettings> Sssettings { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Sssettings>()
				.HasKey(k => new { k.GroupName, k.KeyName });
		}
	}
}
