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
            const decimal pitch = 261.63m;
            var name = NotesItalian.Do;
            
            // act
            var note1 = new Note(name);

            // assert
            Assert.AreEqual(NotesItalian.Do.ToString(), note1.Name);
            Assert.AreEqual(pitch, note1.Pitch);
        }


        [TestMethod]
        public void Test_Flatten()
        {
            // arrange
            const decimal pitchExpected = 420.00m;
            var note1 = new Note(NotesItalian.La);

            // act
            note1.Flatten();

            // assert
            Assert.AreEqual($"{NotesItalian.La}♭", note1.Name);
            Assert.AreEqual(pitchExpected, note1.Pitch);
        }

        [TestMethod]
        public void Test_Sharpen()
        {
            // arrange
            const decimal pitchExpected = 460.00m;
            var note1 = new Note(NotesItalian.La);

            // act
            note1.Sharpen();

            // assert
            Assert.AreEqual($"{NotesItalian.La}#", note1.Name);
            Assert.AreEqual(pitchExpected, note1.Pitch);
        }

        [TestMethod]
        public void Test_Tonal()
        {
            // arrange
            const decimal pitchExpected = 440.00m;
            var note1 = new Note(NotesItalian.La);

            // act
            note1.Sharpen();
            note1.Tonal();

            // assert
            Assert.AreEqual(NotesItalian.La.ToString(), note1.Name);
            Assert.AreEqual(pitchExpected, note1.Pitch);
        }

        [TestMethod]
        public void Test_OctaveUp()
        {
            // arrange
            const decimal pitchExpected = 620.00m;
            var note1 = new Note(NotesItalian.La);

            // act
            note1.OctaveUp();

            // assert
            Assert.AreEqual(NotesItalian.La.ToString(), note1.Name);
            Assert.AreEqual(pitchExpected, note1.Pitch);
        }

        [TestMethod]
        public void Test_OctaveDown()
        {
            // arrange
            const decimal pitchExpected = 260.00m;
            var note1 = new Note(NotesItalian.La);

            // act
            note1.OctaveDown();

            // assert
            Assert.AreEqual(NotesItalian.La.ToString(), note1.Name);
            Assert.AreEqual(pitchExpected, note1.Pitch);
        }
    }
}
