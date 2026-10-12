using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Mod8BSTDemo
{
    internal class Node
    {
        public int Data { get; set; }
        public Node left;//left pointer
        public Node right;//right pointer
        public Node(int val)
        {
            this.Data = val;
            this.left = null;
            this.right = null;

        }
    }

    class BinarySearchTree
    {
        private Node root;
        public Node Root
        {
            get { return root; }
        }
        public BinarySearchTree()
        {
            this.root = null;
        }
        public void Add(int val)
        {
            Node newNode = new Node(val);
            Node tempRoot = this.root;
            Node temp = null;
            if(this.root==null)
            {
                this.root = newNode;
            }
            else
            {
                //temproot helps to navigate and reach null. temp is pointing to the node before temproot
                //temp will become the parent of newnode
                while(tempRoot!=null)
                {
                    temp = tempRoot;
                    if (tempRoot.Data == val)
                    {
                        Console.WriteLine("Value already exists, no duplicates");
                        return;
                    }
                    else if (val<tempRoot.Data )
                    {
                        tempRoot = tempRoot.left;
                    }
                    else
                    {
                        tempRoot = tempRoot.right;
                    }
                }
                //temp points to the leaf node
                if(val<temp.Data)
                {
                    temp.left = newNode;
                }
                else
                {
                    temp.right = newNode;
                }


            }
        }

        public bool Search(int val)
        {
            Node temp = this.root;
            while(temp!=null)
            {
                if(temp.Data==val)
                {
                    return true;
                }
                else if(val<temp.Data)
                {
                    temp = temp.left;
                }
                else
                {
                    temp = temp.right;
                }
            }
            return false;
        }

        public void InOrder(Node tempRoot)
        {
            if(tempRoot!=null)
            {
                InOrder(tempRoot.left);
                Console.Write(tempRoot.Data + " ");
                InOrder(tempRoot.right);
            }
        }

        public void PreOrder(Node tempRoot)
        {
            if(tempRoot!=null)
            {
                Console.Write(tempRoot.Data + " ");
                PreOrder(tempRoot.left);
                PreOrder(tempRoot.right);
            }
        }
        public void PostOrder(Node tempRoot)
        {
            if(tempRoot!=null)
            {
                PostOrder(tempRoot.left);
                PostOrder(tempRoot.right);
                Console.Write(tempRoot.Data + " ");
            }
        }

    }
}
