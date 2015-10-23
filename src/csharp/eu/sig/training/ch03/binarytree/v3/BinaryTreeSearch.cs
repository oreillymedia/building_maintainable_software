using System;
using eu.sig.training.ch03.binarytree;

namespace eu.sig.training.ch03.binarytree.v3 {

	public class BinaryTreeSearch {

		// tag::calculateDepth[]
		public static int calculateDepth(BinaryTreeNode<int> t, int n) {
			int depth = 0;
			if (t.getValue() == n)
				return depth;
			else
				return traverseByValue(t, n);
		}

		private static int traverseByValue(BinaryTreeNode<int> t, int n) {
			BinaryTreeNode<int> childNode = getChildNode(t, n);
			if (childNode == null) {
				throw new TreeException ("Value not found in tree!");
			} else {
				return 1 + calculateDepth(childNode, n);
			}
		}

		private static BinaryTreeNode<int> getChildNode(
			BinaryTreeNode<int> t, int n) {
			if (n < t.getValue()) {
				return t.getLeft();
			} else {
				return t.getRight();
			}
		}
		// end::calculateDepth[]

	}
}