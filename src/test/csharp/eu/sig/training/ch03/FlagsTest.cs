using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03
{
    [TestFixture]
    public class FlagsTest
    {

        [Test]
        public void testGetFlag()
        {
            FlagFactory factory = new FlagFactory();

            IList<Color> colors = factory.GetFlagColors(Nationality.DUTCH);

            Assert.AreEqual(Color.Red, colors[0]);
            Assert.AreEqual(Color.White, colors[1]);
            Assert.AreEqual(Color.Blue, colors[2]);
        }

    }
}
