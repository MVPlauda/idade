internal class Program
{
    private static void Main(string[] args)
    {
        int idade;

        Console.WriteLine("Qual a sua idade?: ");
        idade = int.Parse(Console.ReadLine());

        if (idade <= 12)
        {
            Console.WriteLine("De acordo com sua idade você ainda é uma criança. ");
        }

        else if (idade >= 18)
        {
            Console.WriteLine("De acordo com sua idade você é um adulto. ");
        }

        else
        {

            Console.WriteLine("De acordo com sua idade você é um adolescente. ");
        }
    }
}
