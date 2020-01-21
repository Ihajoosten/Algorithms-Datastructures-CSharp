using System;

namespace AdsTryoutCSharp.ExpressionTree
{
    public class BNode<E>
    {
        public const int Left = 0;
        public const int Right = 1;

        public BNode<E> Parent { get; set; }
        public BNode<E> LeftChild { get; set; }
        public BNode<E> RightChild { get; set; }
        public E UserObject { get; }

        public BNode()
        {
        }

        public BNode(E userObject)
        {
            UserObject = userObject;
        }

        public void Add(BNode<E> newChild)
        {
            if (LeftChild == null)
            {
                Insert(newChild, Left);
            }
            else if (RightChild == null)
            {
                Insert(newChild, Right);
            }
            else
            {
                throw new ArgumentException("More than 2 children");
            }
        }

        public void Insert(BNode<E> newChild, int childIndex)
        {
            if (IsAncestor(newChild))
            {
                throw new ArgumentException("Child is ancestor");
            }
            if (childIndex != Left && childIndex != Right)
            {
                throw new ArgumentException("Index should be 1 of 0");
            }
            if (newChild != null)
            {
                BNode<E> oldParent = newChild.Parent;
                if (oldParent != null)
                {
                    oldParent.Remove(newChild);
                }
            }
            newChild.Parent = this;
            if (childIndex == Left)
            {
                LeftChild = newChild;
            }
            else
            {
                RightChild = newChild;
            }
        }

        public bool IsChild(BNode<E> aNode)
        {
            return aNode == null ? false : aNode.Parent == this;
        }

        public bool IsAncestor(BNode<E> aNode)
        {
            BNode<E> ancestor = this;
            while (ancestor != null && ancestor != aNode)
            {
                ancestor = ancestor.Parent;
            }
            return ancestor != null;
        }

        public void Remove(BNode<E> aChild)
        {
            if (aChild == null)
            {
                throw new ArgumentNullException();
            }
            if (!IsChild(aChild))
            {
                throw new ArgumentException("Argument is not a child");
            }
            if (aChild == LeftChild)
            {
                LeftChild.Parent = null;
                LeftChild = null;
            }
            else
            {
                RightChild.Parent = null;
                RightChild = null;
            }
        }

        // root counts as depth 0
        public int GetTreeDepth(BNode<E> node)
        {
            int leftCount = 0;
            int rightCount = 0;

            BNode<E> leftChild = node.LeftChild;
            BNode<E> rightChild = node.RightChild;

            if (leftChild != null)
            {
                leftCount = GetTreeDepth(leftChild) + 1;
            }

            if (rightChild != null)
            {
                rightCount = GetTreeDepth(rightChild) + 1;
            }

            return Math.Max(leftCount, rightCount);
        }

        public override string ToString()
        {
            return UserObject.ToString();
        }

    }
}
