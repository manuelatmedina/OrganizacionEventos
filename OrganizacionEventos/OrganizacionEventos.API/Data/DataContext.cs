using Microsoft.EntityFrameworkCore;
using OrganizacionEventos.Shared.Entities;

namespace OrganizacionEventos.API.Data
{
    //Creaciòn inyeccion de dependencias clase program para poder conectar sql server
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) 
        {

        }

        public DbSet<Employee>Employees { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<EmployeeEvent> EmployeeEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceEvent> ServiceEvents { get; set; }


        //Permite enviar tablas a la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
