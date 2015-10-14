package eu.sig.training.ch03.binarytree.v2;

import eu.sig.training.ch03.binarytree.BinaryTreeNode;
import eu.sig.training.ch03.binarytree.TreeException;

public class BinaryTreeSearch {

    // tag::calculateDepth[]
    public static int calculateDepth(BinaryTreeNode<Integer> t, int n) {
        int depth = 0;
        if (t.getValue() == n)
            return depth;
        if (n < t.getValue() && t.getLeft() != null)
            return 1 + calculateDepth(t.getLeft(), n);
        if (n > t.getValue() && t.getRight() != null)
            return 1 + calculateDepth(t.getRight(), n);
        throw new TreeException("Value not found in tree!");
    }
    // end::calculateDepth[]

}
