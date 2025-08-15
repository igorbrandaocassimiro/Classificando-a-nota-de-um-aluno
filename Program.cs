

Console.WriteLine("Digite a nota final do aluno:");
double notaFinal = double.Parse(Console.ReadLine());

if (notaFinal >= 9)
{
    Console.WriteLine("O aluno recebeu a nota A.");
}
else if (notaFinal >= 7 && notaFinal < 9)
{
    Console.WriteLine("O aluno recebeu a nota B.");
}
else if (notaFinal >= 5 && notaFinal< 7)
{
    Console.WriteLine("O aluno recebeu a nota C.");
}
else if (notaFinal < 5)
{
    Console.WriteLine("O aluno recebeu a nota D.");
}
else
{
    Console.WriteLine("Opção inválida");
}