using GestaoPessoal.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System;

namespace GestaoPessoal.Data;

public class GestaoPessoalContext : IdentityDbContext<IdentityUser>
{
    public GestaoPessoalContext(DbContextOptions<GestaoPessoalContext> options)
        : base(options)
    {
    }

    public DbSet<Pessoa> Pessoa { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Pessoa>().ToTable("Pessoas");
    }
}
