namespace eu.sig.training.ch03.binarytree.v1
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
                if (n < t.Value)
                {
                    BinaryTreeNode<int> left = t.Left;
                    if (left == null)
                    {
                        throw new TreeException("Value not found in tree!");
                    }
                    else
                    {
                        return 1 + CalculateDepth(left, n);
                    }
                }
                else
                {
                    BinaryTreeNode<int> right = t.Right;
                    if (right == null)
                    {
                        throw new TreeException("Value not found in tree!");
                    }
                    else
                    {
                        return 1 + CalculateDepth(right, n);
                    }
                }
            }
        }
        // end::calculateDepth[]
    }
}
