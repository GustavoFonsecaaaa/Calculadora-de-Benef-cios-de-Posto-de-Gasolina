internal class Program
{
    private static void Main(string[] args)
    {
        int n, i, sem = 0, desc = 0, brinde = 0, moto = 1, maior = 0;

        Console.WriteLine("Quantos motoristas abasteceram o veículo?");
        n = int.Parse(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("Quantos litros o " + moto++ + " motorista abasteceu?");
            i = int.Parse(Console.ReadLine());

            if (i < 15) //sem benefico
            {
                sem++;
            }
            else if (i > 15 && i <= 30) //com desconto
            {
                desc++;
            }
            else
            {
                brinde++;
            }
        }
        Console.WriteLine("Os motoristas que ficaram sem benefício são: " + sem + " o percentual é: " + ((double)sem / n) * 100 + "%");
        Console.WriteLine("Os motoristas que ficaram com desconto são: " + desc + " o percentual é: " + ((double)desc / n) * 100 + "%");
        Console.WriteLine("Os motoristas que ficaram com desconto e brinde são: " + brinde + " o percentual é: " + ((double)brinde / n) * 100 + "%");

        if (sem > desc && sem > brinde)
        {
            maior = sem;
            Console.WriteLine("Mais motoristas ficaram sem benefício: " + maior + " (categoria predominante: sem benefício)");
        }
        else if (desc > sem && desc > brinde)
        {
            maior = desc;
            Console.WriteLine("Mais motoristas ficaram com desconto: " + maior + " (categoria predominante: com desconto)");
        }
        else if (brinde > sem && brinde > desc)
        {
            maior = brinde;
            Console.WriteLine("Mais motoristas ficaram com brinde: " + maior + " (categoria predominante: com brinde)");
        }
        else
        {
            Console.WriteLine("Categorias empatadas");
        }
    }
}