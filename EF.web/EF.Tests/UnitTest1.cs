using System;
using EF.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EF.Tests
{
    [TestClass]
    public class UnitTest1
    {
        SchoolContext ctx;

        [TestInitialize]
        public  void INit()
        {
            var conn = @"Server=PRAMOD-MACBOOK\PRAMODDB;Database=EFTest;User Id=sa;
Password=syneity;";
            ctx = new SchoolContext(conn);
        }

        [TestMethod]
        public void TestMethod1()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            
            
                var stud = new Student() { StudentName = "Bill" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            
            sw.Stop();
            System.Diagnostics.Debug.WriteLine("1");
            System.Diagnostics.Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        [TestMethod]
        public void TestMethod2()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();


            var stud = new Student() { StudentName = "Bill" };

            ctx.Students.Add(stud);
            ctx.SaveChanges();

            sw.Stop();
            System.Diagnostics.Debug.WriteLine("2");
            System.Diagnostics.Debug.WriteLine(sw.ElapsedMilliseconds);
        }

        
        
    }
}
