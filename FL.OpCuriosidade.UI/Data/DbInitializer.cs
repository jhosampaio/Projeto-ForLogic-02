using FL.OpCuriosidade.UI.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace FL.OpCuriosidade.UI.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<FLOpCuriosidadeDataContext>
    {
        protected override void Seed(FLOpCuriosidadeDataContext context)
        {
            var ativo = new TipoStatus() { Nome = "Ativo" };
            var inativo = new TipoStatus() { Nome = "Inativo" };
            var colaboradores = new List<Colaborador>()
            {
                new Colaborador(){Nome = "Jhonatan", Email = "jhonatan@gmail.com", Data_nasc = "23/03/1995", End = "Rua", inte = "nao", outras = "outro" , sent = "sem", valo = "1", TipoStatus = ativo},
                
            };
            context.Colaboradores.AddRange(colaboradores);

            context.Usuarios.Add(new Usuario()
            {
                Nome = "Jhonatan Sampaio",
                Email = "jhonatan@hotmail.com",
                Senha = "123456"
            });
            context.SaveChanges();
        }
    }
}