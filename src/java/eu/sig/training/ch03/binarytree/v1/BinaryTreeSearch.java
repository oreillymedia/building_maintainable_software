package eu.sig.training.ch03.binarytree.v1;

import eu.sig.training.ch03.binarytree.TreeException;
import eu.sig.training.ch03.binarytree.BinaryTreeNode;

public class BinaryTreeSearch {

    // tag::calculateDepth[]
    public static int calculateDepth(BinaryTreeNode<Integer> t, int n) {
        int depth = 0;
        if (t.getValue() == n) {
            return depth;
        } else {
            if (n < t.getValue()) {
                BinaryTreeNode<Integer> left = t.getLeft();
                if (left == null) {
                    throw new TreeException("Value not found in tree!");
                } else {
                    return 1 + calculateDepth(left, n);
                }
            } else {
                BinaryTreeNode<Integer> right = t.getRight();
                if (right == null) {
                    throw new TreeException("Value not found in tree!");
                } else {
                    return 1 + calculateDepth(right, n);
                }
            }
        }
    }
    // end::calculateDepth[]
}
