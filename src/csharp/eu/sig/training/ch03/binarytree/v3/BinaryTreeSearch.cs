namespace eu.sig.training.ch03.binarytree.v3
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
            else
            {
                return TraverseByValue(t, n);
            }
        }

        private static int TraverseByValue(BinaryTreeNode<int> t, int n)
        {
            BinaryTreeNode<int> childNode = GetChildNode(t, n);
            if (childNode == null)
            {
                throw new TreeException("Value not found in tree!");
            }
            else
            {
                return 1 + CalculateDepth(childNode, n);
            }
        }

        private static BinaryTreeNode<int> GetChildNode(
            BinaryTreeNode<int> t, int n)
        {
            if (n < t.Value)
            {
                return t.Left;
            }
            else
            {
                return t.Right;
            }
        }
        // end::calculateDepth[]
    }
}
