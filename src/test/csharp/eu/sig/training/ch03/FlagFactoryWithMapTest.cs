using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Drawing;

namespace eu.sig.training.ch03 {
    [TestFixture]
    public class FlagFactoryWithMapTest {

        [Test]
        public void testGetFlagColors() {
            FlagFactoryWithMap factory = new FlagFactoryWithMap();

            IList<Color> colors = factory.getFlagColors(Nationality.DUTCH);

            Assert.AreEqual(Color.Red, colors[0]);
            Assert.AreEqual(Color.White, colors[1]);
            Assert.AreEqual(Color.Blue, colors[2]);
        }

    }
}
