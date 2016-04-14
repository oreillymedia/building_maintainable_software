using System;

namespace eu.sig.training.ch03.binarytree
{

    public class BinaryTreeNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            this.Value = value;
        }

        public void Insert(T value)
        {
            if (value.CompareTo(this.Value) < 0)
            {
                if (Left != null)
                {
                    Left.Insert(value);
                }
                else
                {
                    Left = new BinaryTreeNode<T>(value);
                }
            }
            else
            {
                if (Right != null)
                {
                    Right.Insert(value);
                }
                else
                {
                    Right = new BinaryTreeNode<T>(value);
                }
            }
        }

        public bool IsLeaf()
        {
            return Left == null && Right == null;
        }
    }
}
