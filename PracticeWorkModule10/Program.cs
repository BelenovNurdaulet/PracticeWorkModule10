using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule10
{
    //Интерфейсы для частей дома и рабочих
    interface IPart
    {
        void Build();
    }

    interface IWorker
    {
        void Work(House house);
    }

    // Для частей дома
    class Basement : IPart
    {
        public void Build()
        {
            Console.WriteLine("Фундамент построен.");
        }
    }

    class Wall : IPart
    {
        public void Build()
        {
            Console.WriteLine("Стена построена.");
        }
    }

    class Door : IPart
    {
        public void Build()
        {
            Console.WriteLine("Дверь построена.");
        }
    }

    class Window : IPart
    {
        public void Build()
        {
            Console.WriteLine("Окно построено.");
        }
    }

    class Roof : IPart
    {
        public void Build()
        {
            Console.WriteLine("Крыша построена.");
        }
    }


    class House
    {
        private List<IPart> parts = new List<IPart>();

        public void AddPart(IPart part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Дом построен. Вот его состав:");

            foreach (var part in parts)
            {
                part.Build();
            }
        }
    }

    // Для бригады строителей
    class Worker : IWorker
    {
        public void Work(House house)
        {
            house.AddPart(new Basement());
            house.AddPart(new Wall());
            house.AddPart(new Wall());
            house.AddPart(new Wall());
            house.AddPart(new Wall());
            house.AddPart(new Door());
            house.AddPart(new Window());
            house.AddPart(new Window());
            house.AddPart(new Window());
            house.AddPart(new Window());
            house.AddPart(new Roof());
        }
    }

    class TeamLeader : IWorker
    {
        public void Work(House house)
        {
            house.Show();
        }
    }

    class Team
    {
        private List<IWorker> workers = new List<IWorker>();

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void BuildHouse(House house)
        {
            foreach (var worker in workers)
            {
                worker.Work(house);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            House house = new House();
            Team team = new Team();
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new Worker());
            team.AddWorker(new TeamLeader());

            team.BuildHouse(house);
        }
    }
}
