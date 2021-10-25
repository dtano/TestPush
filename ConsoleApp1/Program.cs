using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot sampleRobot = new Robot("Marianne");
            sampleRobot.Greet();

            Console.WriteLine("Hello world");
        }
    }

    public class Robot
    {
        public string Name { get; set; }
        public int Hp { get; set; }

        public Robot(string name)
        {
            Name = name;
            Hp = 30;
        }

        public void Greet()
        {
            Console.WriteLine($"Hello my name is {Name}");
        }

        public void Damage(int dmgAmount)
        {
            Console.WriteLine("Robot is dead");
            Hp -= dmgAmount;
        }
    }
}
