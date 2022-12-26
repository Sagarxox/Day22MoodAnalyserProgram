using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC_4_MoodAnalyserFactory;

namespace TC_4._3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenImproperClassName_ShouldReturnMoodAnalyserExpection()
        {
            string expected = "Constructor is Not Found";
            try
            {
                object moodAnalyseObject = MoodAnalyserFactory.CreateMoodAnalyse("UC_4_Return_MoodAnalyser_Object.MoodAnalyser", "MoodAnalyser");
            }
            catch (MoodAnalyserCustomException expection)
            {
                Assert.AreEqual(expected, expection.Message);
            }
        }
    }
}

