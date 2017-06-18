using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Synerion.Helper;

namespace SynerionTest
{
    [TestClass]
    public class UnitTestRound15
    {
        private readonly TimeSpan _15MinutTimeSpan = TimeSpan.FromMinutes(15);
       
        private readonly List<DateTime> _inputTestDataList = new List<DateTime>
        {
            DateTime.Parse("2015-05-18 7:01"),
            DateTime.Parse("2015-05-18 7:07"),
            DateTime.Parse("2015-05-18 7:08"),
            DateTime.Parse("2015-05-18 7:15"),
            DateTime.Parse("2015-05-18 7:22"),
            DateTime.Parse("2015-05-18 7:23")
        };
        private readonly List<DateTime> _expectedTestDataList = new List<DateTime>
        {
            DateTime.Parse("2015-05-18 7:00"),
            DateTime.Parse("2015-05-18 7:00"),
            DateTime.Parse("2015-05-18 7:15"),
            DateTime.Parse("2015-05-18 7:15"),
            DateTime.Parse("2015-05-18 7:15"),
            DateTime.Parse("2015-05-18 7:30")
        };

       
        [TestMethod]
        public void Round15TestMethod()
        {
            List<DateTime> actualTestDataList =  new List<DateTime>();
            foreach (var curDateTime in _inputTestDataList)
            {
                actualTestDataList.Add(Round15.Round(curDateTime, _15MinutTimeSpan));
            }
            CollectionAssert.AreEqual(_expectedTestDataList, actualTestDataList);
        }
    }
}
