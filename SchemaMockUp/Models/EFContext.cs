using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace SchemaMockUp.Models
{
    class EFContext : DbContext
    {
        const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Database=DemoModelDB;Trusted_Connection=True";

        //public EFContext()
        //{
        //    var builder = new ConfigurationBuilder();
        //    builder.AddJsonFile("appsettings.json", optional: false);

        //    var configuration = builder.Build();

        //    connectionString = configuration.GetConnectionString("sqlConnection");
        //}



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentParticipant> AppointmentParticipants { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobSkill> JobSkillso { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillMatch> SkillMatches { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserSpecification> UserSpecifications { get; set; }

    }
}
