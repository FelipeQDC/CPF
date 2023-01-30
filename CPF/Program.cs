//Desenvolva um programa que receba via teclado
//o número do CPF do usuário e o valide através de
//uma função C#.


string validação = "a";
int soma = 0, resto, resto2,contador=1;
int[] numeros = new int[11];
for (int i = 0; i < 11; i++)
{
            Console.WriteLine("Digite um Numero por vez");
            numeros[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 9; i++)
{   
    soma = soma + (numeros[i] * contador);
    contador++;
}
resto = soma % 11;
soma = 0;
contador = 0;
for (int i = 0; i < 10; i++)
{
    soma = soma + (numeros[i] * i);
    if (i == 10)
    {
        soma = soma + (resto * 9);
    }
}
resto2 = soma % 11;
if(resto2 == 10)
{
    resto2 = 0;
}
if (resto == numeros[9] && resto2 == numeros[10])
{
    validação = "Validado";
}
else
{
    validação = "Não validado";
}
Console.WriteLine(validação);