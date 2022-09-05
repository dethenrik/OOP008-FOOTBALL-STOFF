using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP008
{
    internal class Gui
    {

        GetTeam team = new GetTeam(); // Is an intance of a class called lists containing lists need for the code.
        Lists lists = new Lists();


        public Gui()
        {
            
            while (true)
            {
                
                Menu();

            }

        }
        // TODO - jeg skal ha sørget for at man kan trykke på esc for at komme til hovedmenuen og ikke hvilken son helst knap(som det er nu).
        // Så skal jeg ha indført resten af divisionernes hold og lavet stave fejl.




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
            Console.Clear();


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
            Console.Clear();

            Console.WriteLine($"\n TEAM ID:{t.TeamId}\n TEAM: {t.TeamName}\n CITY {t.TeamCity} \n SPONSOR: {t.TeamSponsor}\n\n LINE-UP: \n\n GK: {t.PlayerName}\n LB: {t.PlayerName2}\n CB: {t.PlayerName3}\n CB: {t.PlayerName4}\n RB: {t.PlayerName5}\n CM: {t.PlayerName6}\n CDM: {t.PlayerName7}\n CM: {t.PlayerName8}\n LW: {t.PlayerName9}\n RW: {t.PlayerName10}\n ST: {t.PlayerName11}\n \n RESERVE: {t.PlayerName12}\n RESERVE: {t.PlayerName13} \n\n\n\n ESC = BACK TO MENU");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Escape:
                    Menu();
                    break;

            }
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
