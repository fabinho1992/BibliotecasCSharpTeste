using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using GeradorPix;
using System;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


//new ByteBankAtendimento().AtendimentoCliente();

//Console.WriteLine(GeradorPix.GeradorPix.GetChavePix());

//var listaPix = GeradorPix.GeradorPix.GetChavesPix(5);

//foreach (var chave in listaPix)
//{
//    Console.WriteLine(chave);
//}



public class Estagiario : Funcionario
{
    public Estagiario(double salario, string cpf) : base(salario, cpf)
    {
    }

    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    public override double getBonificacao()
    {
        throw new NotImplementedException();
    }
}

