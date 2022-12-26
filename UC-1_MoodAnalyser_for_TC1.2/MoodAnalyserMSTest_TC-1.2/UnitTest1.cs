using Microsoft.VisualStudio.TestTools.UnitTesting;
using TC_1._2;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenAnyMoodShouldReturnHAPPY()
        {
            // Arrange
            string expected = "HAPPY";
            string message = "I am in Any Mood";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood1();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
