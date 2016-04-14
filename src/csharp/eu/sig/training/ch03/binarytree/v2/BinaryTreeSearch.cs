namespace eu.sig.training.ch03.binarytree.v2
{

    public class BinaryTreeSearch
    {

        // tag::calculateDepth[]
        public static int CalculateDepth(BinaryTreeNode<int> t, int n)
        {
            int depth = 0;
            if (t.Value == n)
            {
                return depth;
            }
            if ((n < t.Value) && (t.Left != null))
            {
                return 1 + CalculateDepth(t.Left, n);
            }
            if ((n > t.Value) && (t.Right != null))
            {
                return 1 + CalculateDepth(t.Right, n);
            }
            throw new TreeException("Value not found in tree!");
        }
        // end::calculateDepth[]
    }
}
