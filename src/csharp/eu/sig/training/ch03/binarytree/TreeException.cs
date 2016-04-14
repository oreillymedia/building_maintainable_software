using System;

namespace eu.sig.training.ch03.binarytree
{
    [Serializable]
    public class TreeException : SystemException
    {
        public TreeException(string msg) : base(msg)
        {
        }
    }
}
