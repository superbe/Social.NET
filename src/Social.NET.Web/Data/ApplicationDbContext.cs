﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Social.NET.CMS;
using Social.NET.Core;
using Social.NET.Web.Models;

namespace Social.NET.Web.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			// Customize the ASP.NET Identity model and override the defaults if needed.
			// For example, you can rename the ASP.NET Identity table names and more.
			// Add your customizations after calling base.OnModelCreating(builder);
		}
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Page> Pages { get; set; }
		public DbSet<PageItem> PageItems { get; set; }
		public DbSet<Template> Templates { get; set; }
	}
}
