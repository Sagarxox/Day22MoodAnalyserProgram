using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppUC_2_Handle_Exception;

namespace MoodAnalyserMSTest2._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(null)]
        public void GivenHAPPYMoodShouldReturnHAPPY(string message)
        {
            // Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyse = new MoodAnalyser(message);

            //Act
            string mood = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);
        }
    }
}
