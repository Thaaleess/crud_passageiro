using System.Collections.Generic;

namespace crud_passageiro.Models
{
    public class PassageiroRepository
    {
        public static List<Passageiro> passageiros = new List<Passageiro>();
    
        public PassageiroRepository()
        {

        }

        public void Create(Passageiro passageiro)
        {
            passageiros.Add(passageiro);

        }
        public void Delete(int id)
        {
            passageiros.Remove(passageiros.Find(x=>x.id == id));
        }

        public void Update(Passageiro passageiro){
            Delete(passageiro.id);
            Create(passageiro);
        }

        public Passageiro GetById(int id)
        {
            return passageiros.Find(x=>x.id == id);
        }

        public List<Passageiro> GetAll()
        {
            return passageiros;
        }
    }
}