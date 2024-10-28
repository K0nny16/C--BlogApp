using Microsoft.EntityFrameworkCore;
using BlogApp.DTO;

namespace BlogApp.Data
{
    //DbContext funkar som en brygga mellan applikationen och databasen. Påminner en del om Entitys i springboot.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {   
        }
        //Represnterar en tabell i databasen
        public DbSet<User> Users {get;set;}
    }
}