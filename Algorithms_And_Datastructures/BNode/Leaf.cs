using BNode;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_And_Datastructures.BNode
{
    public class Leaf<E> where E : IComparable<E>
    {
        private BNode<E> _root;
        private List<BNode<E>> _leafs;

        public void AddItem(E e)
        {
            _root = AddNode(_root, e);
        }

        private BNode<E> AddNode(BNode<E> currentNode, E element)
        {
            /* If the tree is empty, return a new node */
            if (currentNode == null)
            {
                currentNode = new BNode<E>(element);
                return currentNode;
            }

            /* Otherwise, recur down the tree */
            if (element.CompareTo(currentNode.UserObject) < 0)
            {
                BNode<E> newChild = AddNode(currentNode.LeftChild, element);
                currentNode.LeftChild = newChild;
                newChild.Parent = currentNode;
            }
            else if (element.CompareTo(currentNode.UserObject) > 0)
            {
                BNode<E> newChild = AddNode(currentNode.RightChild, element);
                currentNode.RightChild = newChild;
                newChild.Parent = currentNode;
            }
            // else, element already in tree, so don't insert (it's a search tree)
            return currentNode;
        }

        public void PrintLeafs()
        {
            _leafs = new List<BNode<E>>();
            FindLeafs(_root);
            PrintLeafsRoute();
        }

        private void FindLeafs(BNode<E> current)
        {
            if (current.LeftChild == null && current.RightChild == null)
            {
                _leafs.Add(current);
            }

            if (current.LeftChild != null)
            {
                FindLeafs(current.LeftChild);
            }

            if (current.RightChild != null)
            {
                FindLeafs(current.RightChild);
            }
        }

        private void PrintLeafsRoute()
        {
            foreach (var leaf in _leafs)
            {
                Console.WriteLine(CreateLeafRoute(leaf));
            }
        }

        private string CreateLeafRoute(BNode<E> current)
        {
            if (current.Parent != null)
            {
                return current.UserObject + " --> " + CreateLeafRoute(current.Parent);
            }
            else { return current.UserObject + ""; }
        }
    }
}
