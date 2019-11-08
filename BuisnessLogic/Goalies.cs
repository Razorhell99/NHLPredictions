using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public class Goalies
    {
        public int ID { get; set; }
        public string GoalieFirstName { get; set; }
        public string GoalieLastName { get; set; }
        public int TeamID { get; set; }
        public List<Goalies> goalies  { get; set; }


        private string sqlConnectionString = @"Data Source = DESKTOP-OO91RFN\Utilisateur";
        private List<Goalies> GetAllGoalies()
        {
            List<Goalies> goalies = new List<Goalies>();
            using (var connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();
                goalies = connection.Query<Goalies>("Select ID, GoalieFirstName, GoalieLastName from Goalies").ToList();
                connection.Close();
            }
            return goalies;

            


        }


        
    }
}
