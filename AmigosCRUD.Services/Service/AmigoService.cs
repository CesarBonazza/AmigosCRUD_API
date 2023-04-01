using AmigosCRUD.Domain.Entities;
using AmigosCRUD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosCRUD.Services.Service
{
    public class AmigoService : IAmigoService
    {
        private readonly AmigosDBContext _ApiFDataBase;
        public AmigoService(AmigosDBContext ApiFDataBase)
        {
            _ApiFDataBase = ApiFDataBase;
        }
        public IList<Amigo> GetAll() 
        {
            return _ApiFDataBase.Amigo.ToList();
        }

        public void Registrar(Amigo amigo)
        {
            _ApiFDataBase.Amigo.Add(amigo);
            _ApiFDataBase.SaveChanges();
        }
        public void Deletar(int Id) 
        {
            var amigo = _ApiFDataBase.Amigo.First(t => t.Id == Id);
            _ApiFDataBase.Amigo.Remove(amigo);
            _ApiFDataBase.SaveChanges();
        }
        public void Atualizar(Amigo amigo)
        {
            _ApiFDataBase.Amigo.Update(amigo);
            _ApiFDataBase.SaveChanges();
        }
    }
}
