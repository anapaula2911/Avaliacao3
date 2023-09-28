using Avaliacao3;
using System;

class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario = new Funcionario();
        
        Console.WriteLine("qual o seu nome? ");
        funcionario.Nome = Console.ReadLine();
        
        Console.WriteLine("qual o seu cpf? ");
        funcionario.Cpf = Console.ReadLine();
        
        Console.WriteLine("qual o seu matricula? ");
        funcionario.Matricula = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("qual a sua data de nascimento? ");
        funcionario.Data_Nascimento = Console.ReadLine();
        
        Console.WriteLine("qual o seu sexo? ");
        funcionario.Sexo = Console.ReadLine();
        
        Console.WriteLine("qual o seu salário? ");
        funcionario.Salario = Convert.ToDouble(Console.ReadLine());


        Medico medico = new Medico();
        Console.WriteLine("Qual o seu registro de conselho? ");
        medico.Registro_Conselho = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Quanto de hora extra você fez? ");
        medico.Hora_Extra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("qual a sua especialidade? ");
        medico.Especialidade = Console.ReadLine();

        Administrativo admin = new Administrativo();

        Console.WriteLine("qual a sua funcao? ");
        admin.Funcao = Console.ReadLine();
    }
}