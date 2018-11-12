using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustRIpeFarm
{
public class TaskHandler
{
    public bool addNewTask(MySqlConnection conn, Task task)
    {
        string sql = "INSERT INTO task (title, category, description, start_date, due_date, status) "
            + "VALUES ('" + task.Title + "', '" + task.Category + "', '" + task.Description
            + "', '" + task.StartDate.ToString("yyyy-MM-dd HH:mm:ss")
            + "', '" + task.DueDate.ToString("yyyy-MM-dd HH:mm:ss")
            + "', '" + task.Status + "')";

        MySqlCommand mysqlComm = new MySqlCommand(sql, conn);
        return (mysqlComm.ExecuteNonQuery() != 0);
    }
}
}
