namespace crud_passageiro.Models
{
    public class Passageiro
    {
        public Passageiro (){

        }
            public Passageiro(int id, string nome, int idade, string cpf, string endereco, string local){
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
            this.cidade = cidade;
            this.endereco = endereco;
            this.local = local;
        }
        
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string local { get; set; }
    }
}