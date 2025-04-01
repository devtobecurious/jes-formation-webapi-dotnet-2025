using DTBC.Ludotek.Core.VideoGames.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTBC.Ludotek.Core.VideoGames.Infrastructure.Data
{
	public class VideoGamesDbContext : DbContext
	{
		public VideoGamesDbContext(DbContextOptions<VideoGamesDbContext> options) : base(options)
		{
		}

		protected VideoGamesDbContext()
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var vgModelBuilder = modelBuilder.Entity<VideoGame>();
			vgModelBuilder.HasKey(vg => vg.Id);
			vgModelBuilder.ToTable("VideoGame");


			//vgModelBuilder.Property(vg => vg.CurrentStatus)
			//	.HasConversion(
			//		v => v.ToString(),
			//		v => Enum.Parse<Status>(v)
			//	);	

			vgModelBuilder.Property(vg => vg.CurrentStatus)
				.HasConversion<StatusValueConverter>();


		}

		public DbSet<VideoGame> VideoGames { get; set; }
	}
}
