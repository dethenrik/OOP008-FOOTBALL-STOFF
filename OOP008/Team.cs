using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP008
{
    internal class Team : SharedProperties
    {

        public List<GetTeam> SuperLigaTeams = new List<GetTeam> {


                new GetTeam{ TeamName="AAB",TeamId="1",TeamCity="AALBORG",TeamSponsor="MACRON", 
                    PlayerName="jon", 
                    PlayerName2="peter", 
                    PlayerName3="anton", 
                    PlayerName4="lars", 
                    PlayerName5="jasonmamoa", 
                    PlayerName6="tom cruise", 
                    PlayerName7="leonardo dicaprio", 
                    PlayerName8="peter lundin", 
                    PlayerName9="lars larsen", 
                    PlayerName10="peter madsen", 
                    PlayerName11="lucas", 
                    PlayerName12="usama", 
                    PlayerName13="johan"},

                new GetTeam{ TeamName="AC HORSENS",TeamId="2",TeamCity="HORSENS",TeamSponsor="HUMMEL",
                    PlayerName="jon",
                    PlayerName2="peter",
                    PlayerName3="anton",
                    PlayerName4="lars",
                    PlayerName5="jasonmamoa",
                    PlayerName6="tom cruise",
                    PlayerName7="leonardo dicaprio",
                    PlayerName8="peter lundin",
                    PlayerName9="lars larsen",
                    PlayerName10="peter madsen",
                    PlayerName11="lucas",
                    PlayerName12="usama",
                    PlayerName13="johan"},

                new GetTeam{ TeamName="AGF",TeamId="3",TeamCity="AARHUS",TeamSponsor="HUMMEL"},

                new GetTeam{ TeamName="BRØDNBY IF",TeamId="4",TeamCity="BRØDNBY",TeamSponsor="HUMMEL",
                    PlayerName="jon",
                    PlayerName2="peter",
                    PlayerName3="anton",
                    PlayerName4="lars",
                    PlayerName5="jasonmamoa",
                    PlayerName6="tom cruise",
                    PlayerName7="leonardo dicaprio",
                    PlayerName8="peter lundin",
                    PlayerName9="lars larsen",
                    PlayerName10="peter madsen",
                    PlayerName11="lucas",
                    PlayerName12="usama",
                    PlayerName13="johan"},

                new GetTeam{ TeamName="F.C. KØBENHAVN",TeamId="5",TeamCity="KØBENHAVN",TeamSponsor="ADIDAS"},

                new GetTeam{ TeamName="FC MIDTJYLLAND",TeamId="6",TeamCity="HERNING",TeamSponsor="NIKE"},

                new GetTeam{ TeamName="FC NORDSJÆLLAND",TeamId="7",TeamCity="FARUM",TeamSponsor="Adidas"},
                
                new GetTeam{ TeamName="LYNGBY BOLDKLUB",TeamId="8",TeamCity="LYNGBY",TeamSponsor="ADIDAS"},

                new GetTeam{ TeamName="OB",TeamId="9",TeamCity="ODENSE",TeamSponsor="HUMMEL"},

                new GetTeam{ TeamName="RADNERS FC",TeamId="10",TeamCity="RANDERS",TeamSponsor="ADIDAS"},

                new GetTeam{ TeamName="SILKEBORG IF",TeamId="11",TeamCity="SILKEBORG",TeamSponsor="UHLSPORT"},

                new GetTeam{ TeamName="VIRBORG FF",TeamId="12",TeamCity="VIRBORG",TeamSponsor="CAPELLI SPORT"},

            };
    }
    internal class GetTeam : SharedProperties
    {
        public string TeamName { get; set; }
        public string TeamId { get; set; }
        public string TeamCity { get; set; }
        public string TeamSponsor { get; set; }
    }
}
