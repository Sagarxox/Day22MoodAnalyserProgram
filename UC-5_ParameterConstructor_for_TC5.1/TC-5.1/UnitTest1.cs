using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC_5_Parameter_Constructor;
namespace TC_5._1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser("HAPPY");

            object obj = MoodAnalyserFactory.CreateMoodAnalyse("UC_5_Parameter_Constructor.MoodAnalyser", "MoodAnalyser", "HAPPY" );
            expected.Equals(obj); 
        }

    }
}
