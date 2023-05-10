using Projeto;
using System.Globalization;

Aluno a = new Aluno();
Console.WriteLine("Emtre com o nome do Aluno");
a.Nome = Console.ReadLine();
Console.WriteLine("Digite as 3 notas do aluno");
a.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
a.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Nota final: "+ a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
if (a.Aprovado())
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
    Console.WriteLine("FALTARAM: " + a.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "pontos");
}
