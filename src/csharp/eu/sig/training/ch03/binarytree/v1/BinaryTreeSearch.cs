using System;
using eu.sig.training.ch03.binarytree;

namespace eu.sig.training.ch03.binarytree.v1 {

    public class BinaryTreeSearch {

        // tag::calculateDepth[]
        public static int calculateDepth(BinaryTreeNode<int> t, int n) {
            int depth = 0;
            if (t.getValue () == n) {
                return depth;
            } else {
                if (n < t.getValue ()) {
                    BinaryTreeNode<int> left = t.getLeft ();
                    if (left == null) {
                        throw new TreeException ("Value not found in tree!");
                    } else {
                        return 1 + calculateDepth (left, n);
                    }
                } else {
                    BinaryTreeNode<int> right = t.getRight ();
                    if (right == null) {
                        throw new TreeException ("Value not found in tree!");
                    } else {
                        return 1 + calculateDepth (right, n);
                    }
                }
            }
        }
        // end::calculateDepth[]
    }
}