using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC_3_Custom_Expection;

namespace MoodAnalyserMSTest_3._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void Give_Null_Mood_Throw_MoodAnalyserExpection()
        {
            try
            {
                string message = null;
                string expected = "HAPPY";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                string mood = moodAnalyse.AnalyseMood();
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Null", e.Message);
            }
        }

    }
}
