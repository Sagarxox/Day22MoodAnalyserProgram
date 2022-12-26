using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC_3_Custom_Exception;

namespace MoodAnalyserMSTest_3._2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Give_Empty_Mood_Throw_MoodAnalyserExpection_Indicating_EmptyMood()
        {
            try
            {
                // Arrange
                string message = "";
                string expected = "HAPPY";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                //Act
                string mood = moodAnalyse.AnalyseMood();
                //Assert
                Assert.AreEqual(expected, mood);
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
