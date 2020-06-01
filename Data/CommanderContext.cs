using Microsoft.EntityFrameworkCore;
using WebApiVue.Model;

namespace WebApiVue.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
        }

        public DbSet<Command> Commands { get; set; }
    }
}