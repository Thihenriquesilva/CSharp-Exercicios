namespace Senaizinho
{
    public class Aluno
    {
        public string Nome {get;set;}
        public DateTime DataNascimento {get;set;}
        public string Curso {get;set;}
        public int NumeroSala {get;set;}




        public Aluno (string Nome, DataTime DataNascimento, string Curso, int NumeroSala){
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
            this.Curso = Curso;
            this.NumeroSala = NumeroSala;
        }
    }
}