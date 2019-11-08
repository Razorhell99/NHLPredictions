using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class GamePlayed
    {
        public int ID { get; set; }
        public int HomeTeamID { get; set; }
        public int HomeGoalieID { get; set; }
        public int HomeScore { get; set; }
        public int AwayTeamID { get; set; }
        public int AwayGoalieID { get; set; }
        public int AwayScore { get; set; }


        private string sqlConnectionString = @"Data Source = DESKTOP-OO91RFN\Utilisateur";

    }
}
