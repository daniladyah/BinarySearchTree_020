﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //constructor for the node class

        public node(string i, node l,node r )
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }
    class BinaryTree
    {
        public node ROOT;
        public BinaryTree()
        {
            ROOT = null; //initializing root to null
        }
        public void insert(string element) //insert a node in the binary
        {
            node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if(currentnode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else //if the specified node is not present
            {
                tmp = new node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) <0 )
                {
                    if (string.Compare(element, parent.info) <0 )
                        parent.lchild = tmp;
                }
                else
                {
                    parent.lchild = tmp;
                }
            }
        }
        public void find(string elemnt, ref node parent, ref node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != elemnt))
            {
                parent = currentnode;
                if (string.Compare(elemnt, currentnode.info) <0)
                    currentnode = currentnode.lchild;
            }
        }
        public void inorder(node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("Tree is Empty");
                return;
            }
            if (ptr != null)
            {
                inorder(ptr.lchild);
                Console.WriteLine(ptr.info + "");
                inorder(ptr.rchild);
            }
        }
        public void preorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
            }
        }
        public void postorder(node ptr)
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
