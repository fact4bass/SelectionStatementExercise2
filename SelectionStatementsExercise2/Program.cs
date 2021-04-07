using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rightAnswer = false;

                var r = new Random();
                var number = r.Next(1, 1000);
            while (rightAnswer == false)
            {

                Console.WriteLine("try to guess my favorite number!");

                var guess = int.Parse(Console.ReadLine());

                if (guess > number)

                { Console.WriteLine("Too high!"); }

                else if (guess < number)

                { Console.WriteLine("Too low!"); }

                else
                {
                    Console.WriteLine("You got it! Congratuations!");
                    rightAnswer = true;
                }


                Console.WriteLine("What is my favorite subject?");

                var subject = Console.ReadLine();

                switch (subject.ToLower())
                {
                    case "english":
                        Console.WriteLine("Would rather do Math.");
                        break;
                    case "history":
                        Console.WriteLine("It's basically English.");
                        break;
                    case "math":
                        Console.WriteLine("How did you know,smartie pants?");
                        break;
                    default:
                        Console.WriteLine("Come on,you should know this!");
                        break;
                        
                }

            }



        }

    }
}