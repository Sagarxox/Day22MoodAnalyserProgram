using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC_4__MoodAnalyserFactory;
namespace TC_4._2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenImproperClassName_ShouldReturnMoodAnalyserExpection()
        {
            string expected = "Class Not Found";
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
