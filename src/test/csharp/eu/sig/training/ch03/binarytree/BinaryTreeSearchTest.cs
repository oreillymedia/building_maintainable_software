using System;
using NUnit.Framework;

namespace eu.sig.training.ch03.binarytree {
    [TestFixture]
    public class BinaryTreeSearchTest {

        [Test]
        public void testSimpleTree() {
            BinaryTreeNode<Int32> root = new BinaryTreeNode<Int32>(5);
            root.insert(3);
            root.insert(10);
            root.insert(12);

            Assert.AreEqual(eu.sig.training.ch03.binarytree.v1.BinaryTreeSearch.calculateDepth(root, 12), 2);
            Assert.AreEqual(eu.sig.training.ch03.binarytree.v2.BinaryTreeSearch.calculateDepth(root, 12), 2);
            Assert.AreEqual(eu.sig.training.ch03.binarytree.v3.BinaryTreeSearch.calculateDepth(root, 12), 2);
        }

        [Test]
        public void testDepth0() {
            BinaryTreeNode<Int32> root = new BinaryTreeNode<Int32>(2);
            root.insert(5);
            root.insert(1);
            root.insert(16);

            Assert.AreEqual(eu.sig.training.ch03.binarytree.v1.BinaryTreeSearch.calculateDepth(root, 2), 0);
            Assert.AreEqual(eu.sig.training.ch03.binarytree.v2.BinaryTreeSearch.calculateDepth(root, 2), 0);
            Assert.AreEqual(eu.sig.training.ch03.binarytree.v3.BinaryTreeSearch.calculateDepth(root, 2), 0);
        }

        [Test]
        public void testNotInTree() {
            BinaryTreeNode<Int32> root = new BinaryTreeNode<Int32>(2);
            root.insert(5);
            root.insert(1);
            root.insert(16);
            bool exceptionCaught_v1 = false;
            bool exceptionCaught_v2 = false;
            bool exceptionCaught_v3 = false;

            #pragma warning disable 168
            try {
                Assert.AreEqual(eu.sig.training.ch03.binarytree.v1.BinaryTreeSearch.calculateDepth(root, 17), 0);
            } catch (TreeException e) {
                exceptionCaught_v1 = true;
            }
            try {
                Assert.AreEqual(eu.sig.training.ch03.binarytree.v2.BinaryTreeSearch
                    .calculateDepth(root, 17), 0);
            } catch (TreeException e) {
                exceptionCaught_v2 = true;
            }
            try {
                Assert.AreEqual(eu.sig.training.ch03.binarytree.v3.BinaryTreeSearch
                    .calculateDepth(root, 17), 0);
            } catch (TreeException e) {
                exceptionCaught_v3 = true;
            }
            Assert.IsTrue(exceptionCaught_v1);
            Assert.IsTrue(exceptionCaught_v2);
            Assert.IsTrue(exceptionCaught_v3);
            #pragma warning restore 168
        }
    }
}
