using System;

namespace RecreatingSimpleList
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool TesteCovidPositivo { get; set; }
        public double Pressao { get; set; }
        public int BatimentosCardiacos { get; set; }
        public int Saturacao { get; set; }
        public int Idade => (DateTime.Now - DataNascimento).Days / 365;
        public bool Preferencial => Idade >= 60;


        public Paciente()
        {

        }

        public Paciente(string nome, string cpf, DateTime dataNascimento)
        {
            Nome = nome;
            CPF = cpf;
            DataNascimento = dataNascimento;
        }

        public Paciente(string nome, string cPF, DateTime dataNascimento, double pressao, int batimentosCardiacos, int saturacao) : this(nome, cPF, dataNascimento)
        {
            Pressao = pressao;
            BatimentosCardiacos = batimentosCardiacos;
            Saturacao = saturacao;
        }

    }
}
