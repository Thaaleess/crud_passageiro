using System.Collections.Generic;
using System.Linq;

namespace crud_passageiro.Models
{
    public class PassageiroRepository : IPassageiroRepository
    {
        private DataContext context;

        public PassageiroRepository(DataContext context){
            this.context = context;
        }

        public void Create(Passageiro passageiro){
            context.Passageiros.Add(passageiro);
            context.SaveChanges();
        }

        public void Delete(int id){
            context.Passageiros.Remove(GetById(id));
            context.SaveChanges();
        }

        public void Update(Passageiro passageiro){
            Delete(passageiro.id);
            Create(passageiro);
        }

        public Passageiro GetById(int id){
            return context.Passageiros.SingleOrDefault(x=>x.id == id);
        }

        public List<Passageiro> GetAll(){
            return context.Passageiros.ToList();
        }
    }
}