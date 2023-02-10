using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeBoard();
            Menu();
            var option = GetOption();
            int time;

            switch (option)
            {
                case MenuOption.Segundos:
                    {
                        time = GetTimerValue("segundos");
                        Start(time);
                        break;
                    }
                case MenuOption.Minutos:
                    {
                        time = ConvertMinuteToSecond(GetTimerValue("minutos"));
                        Start(time);
                        break;
                    }
                default: Console.WriteLine("Opção inválida."); break;
            }
        }

        static void WelcomeBoard()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-----------Bem vindo-----------");
            Console.WriteLine("---------Ao Cronometro---------");
            Console.WriteLine("-------------------------------");
        }

        static void Menu()
        {
            Console.WriteLine("Deseja cronometrar em:");
            Console.WriteLine("1 - Segundos");
            Console.WriteLine("2 - Minutos");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Selecione uma opção:");
        }

        static MenuOption GetOption()
        {
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: return MenuOption.Segundos;
                case 2: return MenuOption.Minutos;
                default: return MenuOption.Unknow;
            }
        }

        static int GetTimerValue(string timerType)
        {
            Console.WriteLine($"Quanto tempo em {timerType} você deseja cronometrar?");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int ConvertMinuteToSecond(int minutos)
        {
            return minutos * 60;
        }

        static void Start(int timer)
        {
            while (timer != 0)
            {
                Console.Clear();
                if (timer > 1)
                {
                    Console.WriteLine($"{timer} segundos");
                }
                else
                {
                    Console.WriteLine($"{timer} segundo");
                }
                timer--;
                Thread.Sleep(1000);
            }

            Console.Clear();
        }
    }

    enum MenuOption
    {
        Segundos = 1,
        Minutos = 2,
        Unknow
    }
}