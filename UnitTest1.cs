using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.Userlnfo.Instance.UserCheck("Admin"));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Model.UserInfo user = new Model.UserInfo { userName = "Guset", passWord = "sql.123", type = "π‹¿Ì‘±" };
            Console.WriteLine(DAL.Userlnfo.Instance.Add(user));
            Console.WriteLine(JsonConvert.SerializeObject(DAL.Userlnfo.Instance.GetAll()));
            user.qq = "1983533647";
            Console.WriteLine(DAL.Userlnfo.Instance.Update(user));
            var model = DAL.Userlnfo.Instance.GetModel("Guest");
            Console.WriteLine(JsonConvert.SerializeObject(model));
            Console.WriteLine(DAL.Userlnfo.Instance.Delete("Guest"));
            var page = DAL.Userlnfo.Instance.GetPage(new Model.Page { pageIndex = 2, pageSize = 2 });
            Console.WriteLine(JsonConvert.SerializeObject(page));
            Console.WriteLine(DAL.Userlnfo.Instance.GetCount());
        }
    }
}
