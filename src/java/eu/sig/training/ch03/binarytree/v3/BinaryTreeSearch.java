package eu.sig.training.ch03.binarytree.v3;

import eu.sig.training.ch03.binarytree.BinaryTreeNode;
import eu.sig.training.ch03.binarytree.TreeException;

public class BinaryTreeSearch {

    // tag::calculateDepth[]
    public static int calculateDepth(BinaryTreeNode<Integer> t, int n) {
        int depth = 0;
        if (t.getValue() == n)
            return depth;
        else
            return traverseByValue(t, n);
    }

    private static int traverseByValue(BinaryTreeNode<Integer> t, int n) {
        BinaryTreeNode<Integer> childNode = getChildNode(t, n);
        if (childNode == null) {
            throw new TreeException("Value not found in tree!");
        } else {
            return 1 + calculateDepth(childNode, n);
        }
    }

    private static BinaryTreeNode<Integer> getChildNode(
        BinaryTreeNode<Integer> t, int n) {
        if (n < t.getValue()) {
            return t.getLeft();
        } else {
            return t.getRight();
        }
    }
    // end::calculateDepth[]

}
