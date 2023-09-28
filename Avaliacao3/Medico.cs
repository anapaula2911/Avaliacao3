using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Avaliacao3
{
    public class Medico : Funcionario
    {
        
        public int Registro_Conselho { get; set; }
        public double Hora_Extra { get; set; }
        public string Especialidade { get; set; }

        public Medico() { }

        public Medico(string nome, string cpf, int matricula, string data_nascimento, string sexo, double salario,
            int registro_conselho, double hora_extra, string especialidade) : base(nome, cpf, matricula, data_nascimento, sexo, salario)
        { 
            this.Registro_Conselho = registro_conselho;
            this.Hora_Extra = hora_extra;
            this.Especialidade = especialidade;
        }

        public double Beneficio(double salario, double beneficio)
        {
            beneficio = 22 / 100;
            salario = salario + beneficio;
            return salario;
        }
    }
}
