using System;


namespace Avaliacao3
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Matricula { get; set; }
        public string Data_Nascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string cpf, int matricula, string data_nascimento, string sexo, double salario)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Matricula = matricula;
            this.Data_Nascimento = data_nascimento;
            this.Sexo = sexo;
            this.Salario = salario;
        }
    }
}
