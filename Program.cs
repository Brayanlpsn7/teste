int opcao = 0;
double salario = 0;
double novoSalario = 0;
double salarioMaisFerias = 0;
int mesesTrabalhados = 0;
double decimoterceiro = 0;


do
{
    Console.WriteLine("Escolha umas das opções: \n");
    Console.WriteLine("1. Novo salário");
    Console.WriteLine("2. Férias");
    Console.WriteLine("3. Décimo terceiro");
    Console.WriteLine("4. Sair");

    Console.WriteLine("\nopção: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("\nDigite seu salário: ");
        salario = double.Parse(Console.ReadLine());

        if (salario >= 0 && salario <= 350)
        {
            novoSalario = salario * 1.15;
        }
        else if (salario <= 600)
        {
            novoSalario = salario * 1.10;
        }
        else
        {
            novoSalario = salario * 1.05;
        }

        Console.WriteLine($"\nDe acordo com o sistema de RH, seu novo salário é: R$ {novoSalario:F2}\n");
    }

    else if (opcao == 2)
    {
        Console.WriteLine("\nDigite seu salário: ");
        salario = double.Parse(Console.ReadLine());

        salarioMaisFerias = salario * 1.50;

        Console.WriteLine($"\nValor das Férias: R$ {salarioMaisFerias:F2}" + $"\nValor total bruto das Férias mais Salário: R$ {salarioMaisFerias + salario:F2}.\n");

    }

    else if (opcao == 3)
    {
        Console.WriteLine("\nDigite seu salário: ");
        salario = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite os meses trabalhados: ");
        mesesTrabalhados = int.Parse(Console.ReadLine());

        if (mesesTrabalhados > 0 && mesesTrabalhados <= 12)
        {
            decimoterceiro = (salario * mesesTrabalhados) / 12;
            Console.WriteLine($"\nValor do Décimo Terceiro: R$ {decimoterceiro:F2}." +
                $"\nValor total bruto do Décimo Terceiro mais Salário: R$ {decimoterceiro + salario:F2}.\n");
        }

        else
        {
            Console.WriteLine($"\nDigite meses válidos dentro do período de 1 ano." + $"\nRepita o processo.\n");
        }

    }

    else if (opcao == 4)
    {
        Console.WriteLine("\nEncerrando o programa...\n");
    }

    else
    {
        Console.WriteLine("\nOpção inválida! Escolha um número de 1 a 4.\n");
    };







} while (opcao != 4);
