using EntityLayer.Concrete;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class AgricultureContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-VFP0P7JM\\SQLEXPRESS;database=DBAgriculture;integrated security=true;");
        }
        public DbSet<Image> Images { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Announcement>Announcements  { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Team>Teams  { get; set; }
        public DbSet<Contact>Contacts { get; set; }
        public DbSet<SocialMedia>SocialMedias { get; set; }
        public DbSet<About>Abouts{ get; set; }
    }
}
