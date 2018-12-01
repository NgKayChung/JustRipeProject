using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRIpeFarm
{
    public class LabourerHandler
    {
        public int addNewLabourer(MySqlConnection conn, Labourer labourer)
        {
            string sql = "INSERT INTO labourer (name, age, gender) " 
                + "VALUES ('" + labourer.Name + "', " + labourer.Age
                + " , '" + labourer.Gender + "')";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);

            return sqlComm.ExecuteNonQuery();
        }

        public List<Labourer> getLabourers(MySqlConnection conn)
        {
            string sql = "SELECT * FROM labourer";

            MySqlCommand sqlComm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = sqlComm.ExecuteReader();

            if (reader.HasRows)
            {
                List<Labourer> labourersList = new List<Labourer>();

                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string name = reader.GetString("name");
                    int age = reader.GetInt32("age");
                    string gender = reader.GetString("gender");

                    Labourer labourer = new Labourer();
                    labourer.Id = id;
                    labourer.Name = name;
                    labourer.Age = age;
                    labourer.Gender = gender;

                    labourersList.Add(labourer);
                }

                return labourersList;
            }
            else
            {
                return null;
            }
        }
    }
}
