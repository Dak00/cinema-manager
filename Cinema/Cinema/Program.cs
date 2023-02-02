﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        string[,] places = new string[10, 10]
        {
            {"[01,01]","[01,02]","[01,03]","[01,04]","[01,05]","[01,06]","[01,07]","[01,08]","[01,09]","[01,10]"},
            {"[02,01]","[02,02]","[02,03]","[02,04]","[02,05]","[02,06]","[02,07]","[02,08]","[02,09]","[02,10]"},
            {"[03,01]","[03,02]","[03,03]","[03,04]","[03,05]","[03,06]","[03,07]","[03,08]","[03,09]","[03,10]"},
            {"[04,01]","[04,02]","[04,03]","[04,04]","[04,05]","[04,06]","[04,07]","[04,08]","[04,09]","[04,10]"},
            {"[05,01]","[05,02]","[05,03]","[05,04]","[05,05]","[05,06]","[05,07]","[05,08]","[05,09]","[05,10]"},
            {"[06,01]","[06,02]","[06,03]","[06,04]","[06,05]","[06,06]","[06,07]","[06,08]","[06,09]","[06,10]"},
            {"[07,01]","[07,02]","[07,03]","[07,04]","[07,05]","[07,06]","[07,07]","[07,08]","[07,09]","[07,10]"},
            {"[08,01]","[08,02]","[08,03]","[08,04]","[08,05]","[08,06]","[08,07]","[08,08]","[08,09]","[08,10]"},
            {"[09,01]","[09,02]","[09,03]","[09,04]","[09,05]","[09,06]","[09,07]","[09,08]","[09,09]","[09,10]"},
            {"[10,01]","[10,02]","[10,03]","[10,04]","[10,05]","[10,06]","[10,07]","[10,08]","[10,09]","[10,10]"},
        };
        int currentY = 0;
        int currentX = 0;
        const int PLACE_POSITION_Y = 0;
        const int PLACE_POSITION_X = 0;
        ShowPlaces();
       
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nКоманды:");
            Console.WriteLine("1: Забронировать места");
            Console.WriteLine("2: Завершить программу\n");
            Console.Write("Введите команду: ");
            string inputCommand = Console.ReadLine();
            if (inputCommand == "1")
            {
                Console.Write("Выберите места в формате (ряд.место) черех пробел: ");
                string[] placeCMD = Console.ReadLine().Split(' ');

            }
            else
            {
                break;
            }
        }
        void ShowPlaces()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            int rows = places.GetUpperBound(0) + 1; // строки
            int cols = places.Length / rows; // столбцы

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(places[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
        void SetPlace()
        {

        }
    }
}
