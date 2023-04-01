using AmigosCRUD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCRUD.Domain.Interfaces
{
    public interface IAmigoService
    {
        IList<Amigo> GetAll();

        void Registrar(Amigo amigo);
        void Deletar(int Id);
        void Atualizar(Amigo amigo);
    }
}
