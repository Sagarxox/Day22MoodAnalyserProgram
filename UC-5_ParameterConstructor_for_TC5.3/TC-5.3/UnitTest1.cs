using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC_5_Parameter_Constructor;

namespace TC_5._3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("UC_5_Parameter_Constructor.MoodAnalyser", "MoodAnalyser", "HAPPY");
            }
            catch (MoodAnalyserCustomException expection)
            {
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }
}
