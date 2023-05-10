double n1, n2, n3, n4, media;
string resultado;

Console.WriteLine("-- Média --\n");
Console.WriteLine("Digite as suas notas abaixo, com somente uma casa decimal.");

Console.Write("Nota 1: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 3: ");
n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 4: ");
n4 = Convert.ToDouble(Console.ReadLine());

if (n1 < 0.0 || n1 > 10.0 || n2 < 0.0 || n2 > 10.0 || n3 < 0.0 || n3 > 10.0 || n4 < 0.0 || n4 > 10.0)
{
Console.WriteLine("Digite somente notas entre 0.0 e 10.0 com uma casa decimal.");
}
else
{
media = (n1 + n2 + n3 + n4) / 4.0;

if (media >= 7.0)
{
resultado = "Aprovado";
}
else if (media >= 5.0)
{
resultado = "Em recuperação";
}
else
{
resultado = "Reprovado";
}

Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
}