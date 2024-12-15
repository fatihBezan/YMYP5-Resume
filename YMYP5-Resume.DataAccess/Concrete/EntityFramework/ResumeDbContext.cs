using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMYP5_Resume.Entity.Concrete;

namespace YMYP5_Resume.DataAccess.Concrete.EntityFramework;
public class ResumeDbContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YMYP5BEZAN;Integrated Security=True;Trust Server Certificate=True; ");
        //@"Data Source=AKINCENGIZ; Initial catalog=YMYP5Resume;Integrated Security=True;Trust Server Certificate=True;"
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        //modelBuilder.Entity<Experience>().HasIndex(a => a.Company);
        //modelBuilder.Entity<PersonalInfo>().HasOne(x => x.Address).WithMany(x => x.pero)
        //modelBuilder.Entity<Town>().HasOne(c => c.City).WithMany(t => t.Towns).HasForeignKey(t => t.CityId);
        modelBuilder.Entity<PersonalInfo>().Property(p => p.FirstName).HasMaxLength(50);
		base.OnModelCreating(modelBuilder);
	}

	public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<PersonalInfo> PersonalInfos { get; set; }
    public DbSet<SkillAndLanguage> SkillAndLanguages { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Portfolio> Portfolios { get; set; }
    public DbSet<Reccomendation> Reccomendations { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
}
