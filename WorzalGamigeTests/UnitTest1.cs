using NUnit.Framework;
using System;
using WorzalGamige;

namespace WorzalGamigeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GreenLetterWithCharAPosition2WithWordSmart()
        {
            var l = new Letter('a', 2);

            l.Check("smart");
            Assert.IsTrue(l.ColourState == Letter.State.G);
        }

        [Test]
        public void AmberLetterWithCharAPosition1WithWordSmart()
        {
            var l = new Letter('a', 1);

            l.Check("smart");
            Assert.IsTrue(l.ColourState == Letter.State.A);
        }

        [Test]
        public void RedLetterWithCharBPosition3WithWordSmart()
        {
            var l = new Letter('b', 3);

            l.Check("smart");
            Assert.IsTrue(l.ColourState == Letter.State.R);
        }

        [Test]
        public void ExceptionWithCharAPosition2WithWordNull()
        {
            var l = new Letter('a', 7);

            Assert.Throws<IndexOutOfRangeException>(() => l.Check("smarty"));
        }

        [Test]
        public void AmberLetterWithCharBPosition3WithWordBoombastic()
        {
            var l = new Letter('b', 3);

            l.Check("boombastic");
            Assert.IsTrue(l.ColourState == Letter.State.A);
        }
    }
}