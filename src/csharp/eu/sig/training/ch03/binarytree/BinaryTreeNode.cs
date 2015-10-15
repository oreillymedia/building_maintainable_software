using System;

namespace eu.sig.training.ch03.binarytree {

	public class BinaryTreeNode<T> where T: IComparable {
		private readonly T value;
		private BinaryTreeNode<T> left;
		private BinaryTreeNode<T> right;

		public BinaryTreeNode (T value) {
			this.value = value;
		}

		public void insert(T value) {
			if (value.CompareTo(this.value) < 0) {
				if (left != null) {
					left.insert(value);
				} else {
					left = new BinaryTreeNode<T> (value);
				}
			} else {
				if (right != null) {
					right.insert(value);
				} else {
					right = new BinaryTreeNode<T> (value);
				}
			}
		}

		public BinaryTreeNode<T> getLeft() {
			return left;
		}

		public BinaryTreeNode<T> getRight() {
			return right;
		}

		public T getValue() {
			return value;
		}

		public bool isLeaf() {
			return left == null && right == null;
		}
	}
}