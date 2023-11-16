using System;
using System.Collections.Generic;
using Задача.Games;

namespace Задача
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tБольшие гонки\n");
            List<string> countries = new List<string> { "Россия", "Франция", "Китай", "Казахстан" };
            Console.WriteLine("\tКоманда России\n");
            PlayerOrOrg Boris = new PlayerOrOrg();
            PlayerOrOrg Andrey = new PlayerOrOrg();
            PlayerOrOrg Sasha = new PlayerOrOrg();
            PlayerOrOrg Konstantin = new PlayerOrOrg();
            PlayerOrOrg Maxim = new PlayerOrOrg();
            PlayerOrOrg Fedor = new PlayerOrOrg();
            PlayerOrOrg Victoria = new PlayerOrOrg();
            PlayerOrOrg Anna = new PlayerOrOrg();
            PlayerOrOrg Yana = new PlayerOrOrg();
            PlayerOrOrg Elizaveta = new PlayerOrOrg();
            PlayerOrOrg Sofia = new PlayerOrOrg();
            PlayerOrOrg Stepan = new PlayerOrOrg();
            PlayerOrOrg Michail = new PlayerOrOrg();
            PlayerOrOrg Anastasia = new PlayerOrOrg();
            PlayerOrOrg Petr  = new PlayerOrOrg();

            Console.WriteLine("Команда Франции");
            PlayerOrOrg Andre = new PlayerOrOrg();
            PlayerOrOrg Pedro = new PlayerOrOrg();
            PlayerOrOrg Fedro = new PlayerOrOrg();
            PlayerOrOrg Dedro= new PlayerOrOrg();
            PlayerOrOrg Kedro = new PlayerOrOrg();
            PlayerOrOrg Medro = new PlayerOrOrg();
            PlayerOrOrg Lendro = new PlayerOrOrg();
            PlayerOrOrg Jerome = new PlayerOrOrg();
            PlayerOrOrg Jules = new PlayerOrOrg();
            PlayerOrOrg Mules = new PlayerOrOrg();
            PlayerOrOrg Sofa = new PlayerOrOrg();
            PlayerOrOrg Stepo = new PlayerOrOrg();
            PlayerOrOrg Micha = new PlayerOrOrg();
            PlayerOrOrg Anasta = new PlayerOrOrg();
            PlayerOrOrg Pero = new PlayerOrOrg();

            Console.WriteLine("Команда Китая");
            PlayerOrOrg An = new PlayerOrOrg();
            PlayerOrOrg Pe = new PlayerOrOrg();
            PlayerOrOrg Fe = new PlayerOrOrg();
            PlayerOrOrg Ded = new PlayerOrOrg();
            PlayerOrOrg Ked = new PlayerOrOrg();
            PlayerOrOrg Med = new PlayerOrOrg();
            PlayerOrOrg Len = new PlayerOrOrg();
            PlayerOrOrg Fu = new PlayerOrOrg();
            PlayerOrOrg Chu = new PlayerOrOrg();
            PlayerOrOrg Sha = new PlayerOrOrg();
            PlayerOrOrg Chi = new PlayerOrOrg();
            PlayerOrOrg Shi = new PlayerOrOrg();
            PlayerOrOrg Mi = new PlayerOrOrg();
            PlayerOrOrg Lee = new PlayerOrOrg();
            PlayerOrOrg Pa = new PlayerOrOrg();

            Console.WriteLine("Команда Казахстана");
            PlayerOrOrg Jan = new PlayerOrOrg();
            PlayerOrOrg Nurbek = new PlayerOrOrg();
            PlayerOrOrg Azamat = new PlayerOrOrg();
            PlayerOrOrg Amina = new PlayerOrOrg();
            PlayerOrOrg Karim = new PlayerOrOrg();
            PlayerOrOrg Murad = new PlayerOrOrg();
            PlayerOrOrg Samat = new PlayerOrOrg();
            PlayerOrOrg Daulet = new PlayerOrOrg();
            PlayerOrOrg Batyr = new PlayerOrOrg();
            PlayerOrOrg Shamil = new PlayerOrOrg();
            PlayerOrOrg Aby = new PlayerOrOrg();
            PlayerOrOrg Shim = new PlayerOrOrg();
            PlayerOrOrg Mim = new PlayerOrOrg();
            PlayerOrOrg Leem = new PlayerOrOrg();
            PlayerOrOrg Pam = new PlayerOrOrg();

            RacingGame racingGame = new RacingGame(countries);
            racingGame.AddGame(new BeachGame());
            racingGame.AddGame(new MousetrapGame());
            racingGame.AddGame(new SeaGame());
            racingGame.AddGame(new FishingGame());
            racingGame.AddGame(new PostmanGame());
            racingGame.AddGame(new SlideGame());

            racingGame.PlayGames();

            racingGame.AddGame(new CustomGame());
            racingGame.PlayGames();
        }
    }
}
