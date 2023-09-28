using System;
using System.Runtime.CompilerServices;

namespace Avaliacao3
{
    public class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo() { }

        public Administrativo(string nome, string cpf, int matricula, string data_nascimento, string sexo, double salario,
            string fucao) : base(nome, cpf, matricula, data_nascimento, sexo, salario)
        {
            this.Funcao = fucao;
        }

        public double acrescimo(double salario, double alimentacao, double transporte)
        {
            alimentacao = 17 / 100;
            transporte = salario + 250;
            salario = alimentacao + transporte + salario;
            return salario;
        }
    }
}
