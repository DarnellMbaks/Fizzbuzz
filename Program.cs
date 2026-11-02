namespace fizzbuzz;

class Program
{
    static void Main(string[] args)
    {
        // Créez une application console qui affiche tous les nombres de 1 à 100 inclus, à l’exception de certains nombres.
        // Tous les nombres divisibles par 3 seront remplacés par le mot “Fizz”.
        // Tous les nombres divisibles par 5 seront remplacés par le mot “Buzz”.
        // Tous les nombres qui sont divisibles à la fois par 3 et à la fois par 5 seront remplacés par le mot “FizzBuzz”.

        for (int compteur = 1; compteur <= 100; compteur++)
        {
            if (compteur % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (compteur % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (compteur % 3 == 0 && compteur % 5 == 0)
            {
                Console.WriteLine("fizzBuzz");
            }
            else
            {
                Console.WriteLine(compteur);
            }
        }
    }
}
