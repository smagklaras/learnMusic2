using learnMusic.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace learnMusicTests
{
    [TestClass]
    public class NotesTests
    {
        [TestMethod]
        public void Test_Name_Italian()
        {
            // arrange
            var pitch = 120.5m;
            var name = NotesItalian.Do;
            
            // act
            var note1 = new Note(name, pitch);

            // assert
            Assert.AreEqual(NotesItalian.Do.ToString(), note1.Name);
            Assert.AreEqual(pitch, note1.Pitch);
        }
    }
}
