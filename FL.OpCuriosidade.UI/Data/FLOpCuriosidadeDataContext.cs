using FL.OpCuriosidade.UI.Models;
using System.Data.Entity;

namespace FL.OpCuriosidade.UI.Data
{
    public class FLOpCuriosidadeDataContext:DbContext
    {
        public FLOpCuriosidadeDataContext() : base("OpConn") 
        {
            Database.SetInitializer(new DbInitializer());
        }
        public DbSet<Colaborador> Colaboradores  { get; set; }
        public DbSet<TipoStatus> TipoStatus { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
