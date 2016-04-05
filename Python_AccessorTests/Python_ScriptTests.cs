using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Python_Accessor.Tests
{
    [TestClass()]
    public class Python_ScriptTests
    {
        [TestMethod()]
        public void RunTest()
        {
            Python_Script script = new Python_Script("test.py");
            //string res = script.Run();

            //Assert.AreEqual(res, "one");
        }

        [TestMethod()]
        public void Add_Call_Method()
        {
            Python_Script script = new Python_Script("calc_interface.py");
            string res = script.Call_Function("calc_pure_string", "+ 1 -2", true);

            Assert.AreEqual(res, "-1.0");
        }

        [TestMethod()]
        public void Add_Run()
        {
            Python_Script script = new Python_Script("calc_interface.py");
            string res = script.Run("test_calc_pure", "+ 1 -2");

            Assert.AreEqual(res, "-1.0");
        }

        [TestMethod()]
        public void Add_Call_Method_Multi()
        {
            Python_Script script = new Python_Script("calc_interface.py");
            string res = script.Call_Function("calc_pure_string", "+ - * /  3 2  10 6 -2 ", true);

            Assert.AreEqual(res, "7.0");
        }

        [TestMethod()]
        public void Add_Run_Multi()
        {
            Python_Script script = new Python_Script("calc_interface.py");
            string res = script.Run("test_calc_pure", "+ - * /  3 2  10 6 -2 ");

            Assert.AreEqual(res, "7.0");
        }
    }
}