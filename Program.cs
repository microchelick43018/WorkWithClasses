using System;
using System.Collections.Generic;
namespace WorkWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = { new Player(new Person("Nikita", 19), "Krasautsi", "beginner"), 
                                 new Player(new Person("Vasya", 25), "Zmagari", "Master") };
            foreach (Player player in players)
            {
                player.ShowInfo();
            }
        }
    }

    class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя игрока: {_name}, возраст: {_age}");
        }
    }

    class Player
    {
        private Person _person;
        private string _team;
        private string _rank;

        public Player(Person person, string team, string rank)
        {
            _person = person;
            _team = team;
            _rank = rank;
        }

        public void ShowInfo() 
        {
            _person.ShowInfo();
            Console.WriteLine($"Команда: {_team}, ранг в игре: {_rank}");
        }
    }
}
