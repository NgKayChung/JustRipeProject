using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using JustRIpeFarm;

namespace JustRipeFarmUnitTest
{
    [TestClass]
    public class UnitTestTaskHandler
    {
        [TestMethod]
        public void TestAddNewTask()
        {
            DbConnector dbC = new DbConnector();
            string respString = dbC.connect();
            Assert.AreSame("Done", respString);

            Task task = new Task();
            task.Title = "Harvest Wheat 2018-11-05";
            task.Category = "HARVESTING";
            task.Description = "The harvesting task is needed to be completed before 2018/11/08.";
            task.StartDate = new DateTime(2018, 11, 6, 0, 0, 0);
            task.DueDate = new DateTime(2018, 11, 8, 0, 0, 0);
            task.Status = "PENDING";

            TaskHandler taskHand = new TaskHandler();
            bool respCode = taskHand.addNewTask(dbC.getConn(), task);
            Assert.IsTrue(respCode);
        }
    }
}
