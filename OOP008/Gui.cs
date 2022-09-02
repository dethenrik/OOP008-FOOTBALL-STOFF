using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP008
{
    internal class Gui
    {

        Team lists = new Team(); // Is an intance of a class called lists containing lists need for the code.



        public Gui()
        {
            
            while (true)
            {
                
                Menu();

            }

        }





        private void Menu()
        {
               
            Console.WriteLine("\nWELCOME!!! PLEASE CHOOSE A COUNTRY");
            Console.WriteLine("\n 1: DENMARK");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    DENMARK();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:

                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:

                    break;
            }
        }





        private void DENMARK()
        {
            
            Console.WriteLine("\nWELCOME!!! PLEASE CHOOSE A DIVISION");
            Console.WriteLine("\nSUPERLIGAEN");
            Console.WriteLine("\nNORDICBET LIGAEN");
            Console.WriteLine("\n2. DIVISION");
            Console.WriteLine("\n3. DIVISION");
            
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    SuperLigaen();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    //NordigbetLigaen();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    //AndenDivision();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    //TredjeDivision();
                    break;
            }
        }





        private void SuperLigaen()
        {
            Console.Clear();
            Console.WriteLine("\nWELCOME!!! PLEASE CHOOSE A TEAM");
            
            Console.WriteLine("\n1:     AAB");
            Console.WriteLine("\n2:     AC HORSENS");
            Console.WriteLine("\n3:     AGF");
            Console.WriteLine("\n4:     BRØNDBY IF");
            Console.WriteLine("\n5:     F.C. KØBENHAVN");
            Console.WriteLine("\n6:     FC MIDTJYLLAND");
            Console.WriteLine("\n7:     FC NORDSJÆLLAND");
            Console.WriteLine("\n8:     LYNGBY BK");
            Console.WriteLine("\n9:     OB");
            Console.WriteLine("\n10:    RANDERS FC");
            Console.WriteLine("\n11:    SILKEBORG IF");
            Console.WriteLine("\n12:    VIBORG FF");

            Console.Write("\nSearch: ");
            string? search = Console.ReadLine().ToLower();

            foreach (GetTeam team in lists.SuperLigaTeams)
            {
                if (search != null)
                {
                    if (team.TeamId.Contains(search))
                        ShowTeam(team);
                }
            }

        }

        private void ShowTeam(GetTeam t)
        {
            Console.WriteLine($"{t.TeamId} {t.TeamName} {t.TeamCity} {t.TeamSponsor}");
        }
























































        //private void NordigbetLigaen()
        //{
        //    Console.Clear();
        //    Console.WriteLine("\nWELCOME!!! PLEASE CHOOSE A TEAM");
        //    Console.Write("Search: ");
        //    string? search = Console.ReadLine().ToLower();
        //    foreach (GetTeam team in lists.SuperLigaTeams)
        //    {
        //        if (search != null)
        //        {
        //            if (team.TeamName.Contains(search))
        //                ShowTeam(team);
        //        }
        //    }
        //    Console.WriteLine("\n1:     AAB");
        //    Console.WriteLine("\n2:     AC HORSENS");
        //    Console.WriteLine("\n3:     AGF");
        //    Console.WriteLine("\n4:     BRØNDBY IF");
        //    Console.WriteLine("\n5:     F.C. KØBENHAVN");
        //    Console.WriteLine("\n6:     FC MIDTJYLLAND");
        //    Console.WriteLine("\n7:     FC NORDSJÆLLAND");
        //    Console.WriteLine("\n8:     LYNGBY BK");
        //    Console.WriteLine("\n9:     OB");
        //    Console.WriteLine("\n10:    RANDERS FC");
        //    Console.WriteLine("\n11:    SILKEBORG IF");
        //    Console.WriteLine("\n12:    VIBORG FF");
        //}








        //private void AndenDivision()
        //{
        //    Console.Clear();
        //    Console.WriteLine("\nWELCOME!!! PLEASE CHOOSE A TEAM");
        //    Console.Write("Search: ");
        //    string? search = Console.ReadLine().ToLower();
        //    foreach (GetTeam team in lists.SuperLigaTeams)
        //    {
        //        if (search != null)
        //        {
        //            if (team.TeamId.Contains(search))
        //                ShowTeam(team);
        //        }
        //    }
        //    Console.WriteLine("\n1:     AAB");
        //    Console.WriteLine("\n2:     AC HORSENS");
        //    Console.WriteLine("\n3:     AGF");
        //    Console.WriteLine("\n4:     BRØNDBY IF");
        //    Console.WriteLine("\n5:     F.C. KØBENHAVN");
        //    Console.WriteLine("\n6:     FC MIDTJYLLAND");
        //    Console.WriteLine("\n7:     FC NORDSJÆLLAND");
        //    Console.WriteLine("\n8:     LYNGBY BK");
        //    Console.WriteLine("\n9:     OB");
        //    Console.WriteLine("\n10:    RANDERS FC");
        //    Console.WriteLine("\n11:    SILKEBORG IF");
        //    Console.WriteLine("\n12:    VIBORG FF");
        //}








        //private void TredjeDivision()
        //{
        //    Console.Clear();
        //    Console.WriteLine("\nWELCOME!!! PLEASE CHOOSE A TEAM");
        //    Console.Write("Search: ");
        //    string? search = Console.ReadLine().ToLower();
        //    foreach (GetTeam team in lists.SuperLigaTeams)
        //    {
        //        if (search != null)
        //        {
        //            if (team.TeamId.Contains(search))
        //                ShowTeam(team);
        //        }
        //    }
        //    Console.WriteLine("\n1:     AAB");
        //    Console.WriteLine("\n2:     AC HORSENS");
        //    Console.WriteLine("\n3:     AGF");
        //    Console.WriteLine("\n4:     BRØNDBY IF");
        //    Console.WriteLine("\n5:     F.C. KØBENHAVN");
        //    Console.WriteLine("\n6:     FC MIDTJYLLAND");
        //    Console.WriteLine("\n7:     FC NORDSJÆLLAND");
        //    Console.WriteLine("\n8:     LYNGBY BK");
        //    Console.WriteLine("\n9:     OB");
        //    Console.WriteLine("\n10:    RANDERS FC");
        //    Console.WriteLine("\n11:    SILKEBORG IF");
        //    Console.WriteLine("\n12:    VIBORG FF");
        //}

    }
}
