using System;

void question1()
{
    Console.Write("\nInforme seu primeiro nome: ");
    string firstName = Console.ReadLine();
    Console.Write("Informe seu sobrenome: ");
    string lastName = Console.ReadLine();
    Console.WriteLine("Seu nome completo é: " + firstName + " " + lastName);
}

void question2()
{
    Console.WriteLine("Insira um número:");
    int num = int.Parse(Console.ReadLine());
    if (num % 2 == 0) Console.WriteLine($"O número { num } é PAR!");
    else Console.WriteLine($"O número { num } IMPAR");
}


void question3()
{
    Console.WriteLine("Insira um número:");
    int num = int.Parse(Console.ReadLine());

    int cont = 0;

    for (int i = 0; i < num; i++)
    {
        if (i % 2 == 0) cont++;
    }

    Console.WriteLine(cont + " são pares");
}

void question4()
{
    Console.WriteLine("Insira um número:");
    int num = int.Parse(Console.ReadLine());

    int cont = 0;

    int i = 0;
    while (i < num)
    {
        if (i % 3 == 0) cont++;
        i++;
    }
    Console.WriteLine(cont + " são múltiplos de 3");
}

void question5()
{
    Console.WriteLine("Informe um número: ");
    int num = int.Parse(Console.ReadLine());
    int result = 1;
    int x = num;

    while (num >= 1)
    {
        result *= num;
        num--;
    }
    Console.WriteLine("O fatorial de " + x + " é : " + result);
}

void question6()
{
    Console.WriteLine("Informe um número: ");
    int firstNum = int.Parse(Console.ReadLine());

    Console.WriteLine("Informe o segundo número: ");
    int lastNum = int.Parse(Console.ReadLine());

    Console.Write("Informe a operação (soma: +, subtração: -, multiplicação: *, divisão: /): ");
    string operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            Console.WriteLine("O resultado é: " + (firstNum + lastNum));
            break;
        case "-":
            {
                Console.WriteLine("O resultado é: " + (firstNum - lastNum));
                break;
            }
        case "*":
            {
                Console.WriteLine("O resultado é: " + firstNum * lastNum);
                break;
            }

        case "/":
            {
                if (lastNum != 0)
                    Console.WriteLine("O resultado é: " + (firstNum / lastNum));
                else
                    Console.WriteLine("Divisão por 0");
                break;
            }
        default:
            Console.WriteLine("Insira um destes caracteres: +, -, *, /");
            break;
    }
}

void question7(int day, int mounth, int year)
{
    Console.WriteLine(day + "/" + mounth + "/" + year);
}

void question8()
{
    Console.WriteLine("1 - Questão do nome");
    Console.WriteLine("2 - Questão do PAR ou IMPAR");
    Console.WriteLine("3 - Somador de númreos PAR");
    Console.WriteLine("4 - Multiplos de 3");
    Console.WriteLine("5 - Fatorial");
    Console.WriteLine("6 - Calculadora");
    Console.WriteLine("7 - Data");

    Console.Write("Informe o número da questão a ser resolvida: ");
    int operation = int.Parse(Console.ReadLine());

    switch (operation)
    {
        case 1:
            question1();
            break;
        case 2:
            question2();
            break;
        case 3:
            question3();
            break;
        case 4:
            question4();
            break;
        case 5:
            question5();
            break;
        case 6:
            question6();
            break;
        case 7:
            question7(11, 07, 2000);
            break;
        default:
            Console.WriteLine("Digite um número de 1 à 7");
            break;
    }
}

question8();