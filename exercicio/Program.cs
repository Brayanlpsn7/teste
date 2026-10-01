// --- 1.8 ---

/***8. Cálculo de Fatorial**

Peça um número inteiro não negativo e calcule o seu fatorial.

O fatorial de `n` (escrito `n!`) é o produto de todos os inteiros positivos até `n`. Exemplo: `5! = 5 × 4 × 3 × 2 × 1 = 120`.

*Dica: comece com uma variável de resultado valendo 1 e vá multiplicando.*/

using System.Numerics;

int n;
string resultado;

do
{
    Console.WriteLine("\n Digite um numero inteiro não negativo para calcular o seu fatorial: ");
    n = int.Parse(Console.ReadLine());

    if (n < 0)
    {
        Console.WriteLine("Digite um número valido!");
    }

    else
    {
        BigInteger fatorial = 1; //BigInteger (que não tem limite de tamanho, ele cresce conforme a memória do PC)
        for (int i = 1; i <= n; i++)
        {
            fatorial = fatorial * i;
        }
        Console.WriteLine($"\n O fatorial de {n}!, é: {fatorial:N0}");
    }

    Console.WriteLine("\n Deseja calcular outro fatorial? (S/s)?");
    resultado = Console.ReadLine();

} while ( resultado == "S" || resultado == "s");  /*while: Significa "enquanto". Ele diz para o C#: "Volte para o início do "do" enquanto essa condição dentro dos parênteses for verdadeira."

resultado == "S": Testa se o texto digitado pelo usuário é igual à letra "S" maiúscula.

||: É o operador OU (OR em inglês). Significa que pelo menos uma das duas comparações precisa ser verdadeira para o programa continuar rodando.

resultado == "s": Testa se o texto digitado é igual à letra "s" minúscula (garante que funcione mesmo se a pessoa esquecer o Caps Lock ligado).



// --- 1.9 ---

/***9. Jogo de Adivinhação**

O programa sorteia um número inteiro entre 1 e 100. O jogador tenta adivinhar qual é. A cada tentativa, informe se o número secreto é **maior** ou **menor** que o palpite.
O jogo termina quando o jogador acerta. No final, mostre quantas tentativas foram necessárias.

*Dica: `int numeroSecreto = new Random().Next(1, 101);`*/


int numeroSecreto = new Random().Next(1, 100);  //  Sortear o número secreto entre 1 e 100
int palpite;
int tentativas = 0;  // Contador de tentativas

Console.WriteLine("\n=== Jogo de Adivinhação ===");
Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");


do  //  O laço vai repetir até o palpite ser IGUAL ao número secreto
{
    Console.WriteLine("\nDIgite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());

    tentativas++;  // Conta +1 tentativa a cada palpite digitado

    if (palpite < numeroSecreto) // Verificação do palpite
    {
        Console.WriteLine("\nO número secreto é MAIOR!");
    }

    else if (palpite > numeroSecreto)
    {
        Console.WriteLine("\nO número secreto é MENOR!");
    }

    else
    {
        Console.WriteLine("\nPARABÉNS!!! Você acertou!");
    }
} while (palpite != numeroSecreto);

//  Exibe o total de tentativas no final
Console.WriteLine($"\nVocê precisou de {tentativas} tentativas para acertar.");


// === 1.10 ===

/***10. Calculadora Interativa**

Desenvolva uma calculadora com as quatro operações básicas. O programa deve:

1. Exibir um menu com as opções (somar, subtrair, multiplicar, dividir, sair).
2. Pedir ao usuário para escolher uma operação.
3. Pedir dois números.
4. Exibir o resultado.
5. Voltar ao menu, repetindo até que o usuário escolha "Sair".

*Dica: use `do-while` para o menu e `if/else` ou `switch` para as operações.*/


int opcao = 1;

do
{
    Console.WriteLine("\n=== Menu de operações básicas ===");
    Console.WriteLine("1. Somar");
    Console.WriteLine("2. Subtrair");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("0. Sair");

    Console.WriteLine("\nEscolha uma operação: ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("\n=== Somar ===");
        Console.WriteLine("Digite dois números: ");

        Console.WriteLine("\nPrimeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nSegundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        double resultadoSoma;

        resultadoSoma = n1 + n2;

        Console.WriteLine($"\n{n1} + {n2} = {resultadoSoma}");
    }

    else if (opcao == 2)
    {
        Console.WriteLine("\n=== Subtrair ===");
        Console.WriteLine("Digite dois números: ");

        Console.WriteLine("\nPrimeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nSegundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        double resultadoSubtrair;

        resultadoSubtrair = n1 - n2;

        Console.WriteLine($"\n{n1} - {n2} = {resultadoSubtrair}");
    }

    else if (opcao == 3)
    {
        Console.WriteLine("\n=== Multiplicar ===");
        Console.WriteLine("Digite dois números: ");

        Console.WriteLine("\nPrimeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nSegundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        double resultadoMultiplicar;

        resultadoMultiplicar = n1 * n2;

        Console.WriteLine($"\n{n1} * {n2} = {resultadoMultiplicar}");
    }

    else if (opcao == 4)
    {
        Console.WriteLine("\n=== Dividir ===");
        Console.WriteLine("Digite dois números: ");

        Console.WriteLine("\nPrimeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nSegundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        if (n2 == 0)
        {
            Console.WriteLine("\nErro: Não é possível dividir por zero!");
        }

        else
        {
            double resultadoDividir;

            resultadoDividir = n1 / n2;

            Console.WriteLine($"\n{n1} / {n2} = {resultadoDividir}");
        }

    }

    else if (opcao == 0)
    {
        Console.WriteLine("\nEncerrando Programa...");
    }

    else
    {
        Console.WriteLine("\nOpção inválida! Escolha um número de 0 a 4.");
    }


} while (opcao != 0);

// === 1.11 ===

/*## Avançado

**11. Números Primos até 100**

Liste todos os números primos entre 1 e 100.

Um número primo é um número natural maior que 1 que só é divisível por 1 e por ele mesmo.

*Dica: você vai precisar de um `for` dentro de outro. O laço externo percorre os números de 2 a 100 e o interno verifica se existe algum divisor.
*O comando `break` ajuda a sair do laço interno assim que um divisor é encontrado.*/

Console.WriteLine("=== NÚMEROS PRIMOS DE 1 A 100 ===");

// 1. Laço externo: passa por todos os números de 2 até 100
for (int numero = 2; numero <= 100; numero++)
{
    bool ehPrimo = true; // Assumimos que o número é primo até provar o contrário

    // 2. Laço interno: testa se existe algum divisor entre 2 e (numero - 1)
    for (int divisor = 2; divisor < numero; divisor++)
    {
        // Se a divisão for exata (resto igual a 0), encontramos um divisor!
        if (numero % divisor == 0)
        {
            ehPrimo = false; // Não é primo
            break; // Sai do laço interno imediatamente (não precisa continuar testando)
        }
    }

    // 3. Se passou por todos os testes sem encontrar divisores, exibe na tela
    if (ehPrimo)
    {
        Console.Write($"{numero} ");
    }
}

Console.WriteLine(); // Apenas pula uma linha no final

// === explicação 1.11 ===

/* Esse exercício é um clássico! Ele serve exatamente para praticar **laços aninhados** (um `for` dentro do outro) e a instrução `break`.

Aqui está o código completo comentado:

```csharp
Console.WriteLine("=== NÚMEROS PRIMOS DE 1 A 100 ===");

// 1. Laço externo: passa por todos os números de 2 até 100
for (int numero = 2; numero <= 100; numero++)
{
    bool ehPrimo = true; // Assumimos que o número é primo até provar o contrário

    // 2. Laço interno: testa se existe algum divisor entre 2 e (numero - 1)
    for (int divisor = 2; divisor < numero; divisor++)
    {
        // Se a divisão for exata (resto igual a 0), encontramos um divisor!
        if (numero % divisor == 0)
        {
            ehPrimo = false; // Não é primo
            break; // Sai do laço interno imediatamente (não precisa continuar testando)
        }
    }

    // 3. Se passou por todos os testes sem encontrar divisores, exibe na tela
    if (ehPrimo)
    {
        Console.Write($"{numero} ");
    }
}

Console.WriteLine(); // Apenas pula uma linha no final

```

---

### Como funciona a lógica passo a passo:

1. **Por que começamos o laço externo em `2`?**
Porque, pela definição, números primos são maiores que 1. O número 1 não é primo.
2. **A variável `bool ehPrimo = true;`:**
A cada número novo que o laço externo pega, resetamos esse "sinalizador" (flag) para `true`.
É como dizer: *"vou testar esse número, assumindo primeiro que ele é primo"*.
3. **O operador `%` (Resto da divisão):**
O `%` calcula o resto de uma divisão. Se `numero % divisor == 0`, significa que o número é divisível por aquele `divisor` sem deixar resto.
Por exemplo: `6 % 2` é `0` (não é primo), mas `5 % 2` é `1`.
4. **O papel do `break`:**
Se estamos testando o número **50** e testamos o divisor **2**, o resto já dá `0`.
O `break` manda o C# interromper o laço interno na hora, evitando testar o 3, 4, 5... até 49 à toa! Isso deixa o programa muito mais rápido.*/

string explicacao;

// === 1.12 ===

/***12. Sequência de Fibonacci**

Peça um número `N` ao usuário e exiba os `N` primeiros termos da sequência de Fibonacci.

Na sequência, cada termo é a soma dos dois anteriores: `0, 1, 1, 2, 3, 5, 8, 13, 21...` */

Console.Write("Digite a quantidade de termos da sequência de Fibonacci: ");
int n = int.Parse(Console.ReadLine());

int primeiro = 0;
int segundo = 1;

Console.WriteLine($"\nOs {n} primeiros termos da sequência de Fibonacci:");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{primeiro} ");

    // Calcula o próximo termo somando os dois anteriores
    int proximo = primeiro + segundo;

    // Atualiza as variáveis para a próxima rodada do laço
    primeiro = segundo;
    segundo = proximo;
}

Console.WriteLine(); // Pula uma linha no final

// === explicação 1.12 ===

/* Para fazer a sequência de Fibonacci, você precisa guardar sempre os **dois últimos valores** para calcular o próximo!

Aqui está o código completo e comentado:

```csharp
Console.Write("Digite a quantidade de termos da sequência de Fibonacci: ");
int n = int.Parse(Console.ReadLine());

int primeiro = 0;
int segundo = 1;

Console.WriteLine($"\nOs {n} primeiros termos da sequência de Fibonacci:");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{primeiro} ");

    // Calcula o próximo termo somando os dois anteriores
    int proximo = primeiro + segundo;

    // Atualiza as variáveis para a próxima rodada do laço
    primeiro = segundo;
    segundo = proximo;
}

Console.WriteLine(); // Pula uma linha no final

```

---

### Como funciona o "jogo das variáveis" dentro do `for`:

Imagine que `N = 5`. O programa faz essa "dança" a cada rodada:

1. **Rodada 1:** Exibe `0`.
* `proximo = 0 + 1 = 1`
* `primeiro` passa a ser `1` | `segundo` passa a ser `1`


2. **Rodada 2:** Exibe `1`.
* `proximo = 1 + 1 = 2`
* `primeiro` passa a ser `1` | `segundo` passa a ser `2`


3. **Rodada 3:** Exibe `1`.
* `proximo = 1 + 2 = 3`
* `primeiro` passa a ser `2` | `segundo` passa a ser `3`


4. **Rodada 4:** Exibe `2`.
* `proximo = 2 + 3 = 5`
* `primeiro` passa a ser `3` | `segundo` passa a ser `5`m


5. **Rodada 5:** Exibe `3`. (Atingiu os 5 termos e encerra!) */
string sinc;





