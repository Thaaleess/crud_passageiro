using System.Collections.Generic;

namespace crud_passageiro.Models
{
    public interface IPassageiroRepository 
    {
        void Create(Passageiro passageiro);
        void Delete(int id);
        void Update(Passageiro passageiro);
        List<Passageiro>GetAll();
        Passageiro GetById(int id);
    }
}