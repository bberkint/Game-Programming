using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Codes
{
    enum Season
    {
        SPRING,
        SUMMER,
        AUTUMN,
        WINTER
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello C#");

            Character player = new Player(6,"BBT",0);

            Character enemy = new Enemy(7,"Soldier",0);

            List<Character> characters = new List<Character>();
            characters.Add(player);
            characters.Add(enemy);

            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }

            IGun currentGun = new Gun1();

            player.takeGun(currentGun);
            player.shoot(enemy);
            player.removeGun();

            currentGun = new Gun2();
            player.takeGun(currentGun);
            player.shoot(enemy);



            while ( !player.isDead || !enemy.isDead )
            {
                player.AttackTo(enemy);
                enemy.AttackTo(player);
            }


            Player newPlayer = (Player)player;
            newPlayer.doSomethingPlayer();

            Console.WriteLine(player.health);
            Console.WriteLine(enemy.health);


            //ConditionalStatement2();
            //ConditionalStatement();
            //WhileLoop();
            //ForEach();
            //ForLoop();


            //Test();
            Console.ReadKey();
        }

        static void Test() {
            Console.WriteLine("Test fonksiyonu");

            int number = 3;
            float number2 = 23.2f;

            double number3 = 34.65;
            char myChar = 'b';

            string myData = "my data";
            bool    myBool = false;

        }


        static void ConditionalStatement() {

            int number = 5;
            if (number == 5)
            {
                Console.WriteLine("Number is 5");
            }else if (number != 5)
            {
                Console.WriteLine("Number is not 5");
            }else
            {
                Console.WriteLine("else statement");
            }

        }

        static void ConditionalStatement2() { 
        
            Season season = Season.SUMMER;

            switch (season)
            {
                case Season.SPRING:
                    Console.WriteLine("Season is Spring");
                    break;
                case Season.SUMMER:
                    Console.WriteLine("Season is Summer");
                    break;
                case Season.AUTUMN:
                    Console.WriteLine("Season is Autumn");
                    break;
                case Season.WINTER:
                    Console.WriteLine("Season is Winter");
                    break;
                default:
                    Console.WriteLine("IF-ELSE deki else gibi düşünebiliriz.");
                    break;
            }
        }

        static void WhileLoop() {
            int counter = 0;
            while (counter <5) {
                Console.WriteLine(counter);
                counter++;
            }
                    
        }

        static void ForLoop() {
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // continue de kulanılabilir
                }
                Console.WriteLine(i);
            }    
        }


        static void ForEach() {
            String[] names = {"Berkin" , "Oğuz ", "Mustafa"};

            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
        }
        

    }
}
