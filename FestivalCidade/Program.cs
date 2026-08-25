using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== FestivalCidade ===");
        Console.WriteLine("Sistema de Ingresso Express");
        Console.WriteLine();

        Console.Write("Digite o nome do fã: ");
        string nomeFa = Console.ReadLine() ?? "";

        Console.Write("Digite a quantidade de dias de show: ");
        int quantidadeDias = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o cupom de desconto: ");
        string cupom = Console.ReadLine() ?? "";

        Console.Write("Digite a pontuação do clube de fidelidade: ");
        int pontuacao = int.Parse(Console.ReadLine() ?? "0");

        double taxaServico = 15.00;
        double valorPorDia = 120.00;

        double custoBruto = taxaServico + (quantidadeDias * valorPorDia);
        double desconto = 0;

        if (cupom.Equals("ROCK10", StringComparison.OrdinalIgnoreCase))
        {
            desconto = custoBruto * 0.10;
        }

        double valorFinal = custoBruto - desconto;

        bool acessoLoungeVip = quantidadeDias > 2 && pontuacao >= 500;

        Console.WriteLine();
        Console.WriteLine("=== RESUMO DA COMPRA ===");
        Console.WriteLine($"Fã: {nomeFa.ToUpper()}");
        Console.WriteLine($"Valor bruto: R$ {custoBruto:F2}");
        Console.WriteLine($"Desconto: R$ {desconto:F2}");
        Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
        Console.WriteLine($"Acesso ao Lounge VIP: {acessoLoungeVip}");
    }
}