﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using JustRIpeFarm;

namespace JustRipeFarmUnitTest
{
    //Hey im miss Asia u c me mou?
    [TestClass]
    public class UnitTestLabourerHandler
    {
        [TestMethod]
        public void TestAddNewLabourer()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Labourer labrA = new Labourer();
            labrA.Name = "Bob";
            labrA.Age = 39;
            labrA.Gender = "MALE";

            LabourerHandler labrHand = new LabourerHandler();
            int resp2 = labrHand.addNewLabourer(dbC.getConn(), labrA);
            Assert.AreEqual(1, resp2);
        }
    }
}
