namespace crud_passageiro.Models
{
    public class Passageiro
    {
        public Passageiro (){

        }
            public Passageiro(int id, string nome, string cpf, string endereco){
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.cidade = cidade;
            this.endereco = endereco;
        }
        
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
    }
}