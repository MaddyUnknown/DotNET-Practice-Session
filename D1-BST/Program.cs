using System;

namespace BST
{
    public class BST
    {
        private class Node
        {
            public int Data { get; set; }

            public Node? Left { get; set; }

            public Node? Right { get; set; }

            public Node()
            {

            }

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        private Node? root;

        public void Insert(int data)
        {
            Node node = new Node(data);

            if(root == null)
            {
                root = node;
            }
            else
            {
                Node temp = root;
                while (true)
                {
                    if (node.Data == temp.Data)
                    {
                        return;
                    }
                    else if (node.Data < temp.Data)
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = node;
                            return;
                        }
                        else
                        {
                            temp = temp.Left;
                        }
                    }
                    else
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = node;
                            return;
                        }
                        else
                        {
                            temp = temp.Right;
                        }
                    }
                }
                
            }

        }

        public void PeakInOrder()
        {
            Node? temp = root;
            Console.Write("The data in order in BST is: ");
            PeakInOrder(temp);
            Console.WriteLine("");
        }

        private void PeakInOrder(Node? node)
        {
            if(node != null)
            {
                PeakInOrder(node.Left);
                Console.Write(node.Data + " ");
                PeakInOrder(node.Right);
            }
        }

        public void Delete(int data)
        {
            Node? parentNode = null;
            Node? matchingNode = root;

            while(matchingNode != null)
            {
                if(matchingNode.Data == data)
                {
                    Node? tempNode;

                    if (matchingNode.Left == null && matchingNode.Right == null)
                    {
                        tempNode = null;
                    }
                    else if (matchingNode.Left == null)
                    {
                        tempNode = matchingNode.Right;
                    }
                    else if (matchingNode.Right == null)
                    {
                        tempNode = matchingNode.Left;
                    }
                    else
                    {
                        Node largestNodeInLeftSubtree = DetachLargestLeftSubtreeElement(matchingNode);
                        largestNodeInLeftSubtree.Left = matchingNode.Left;
                        largestNodeInLeftSubtree.Right = matchingNode.Right;
                        tempNode = largestNodeInLeftSubtree;
                    }

                    if(parentNode == null)
                    {
                        root = tempNode;
                    }
                    else
                    {
                        if(parentNode.Left.Data == matchingNode.Data)
                        {
                            parentNode.Left = tempNode;
                        }
                        else
                        {
                            parentNode.Right = tempNode;
                        }
                    }
                    break;


                }
                else if(matchingNode.Data < data)
                {
                    parentNode = matchingNode;
                    matchingNode = matchingNode.Right;
                }
                else
                {
                    parentNode = matchingNode;
                    matchingNode = matchingNode.Left;
                }
            }
        }

        private Node DetachLargestLeftSubtreeElement(Node? node)
        {
            if(node is null || node.Left is null)
            {
                throw new ArgumentException("No left subtree found");
            }

            Node parent = node;
            Node matchingNode = parent.Left;
            while (matchingNode.Right != null)
            {
                parent = matchingNode;
                matchingNode = matchingNode.Right;
            }

            if(parent.Left.Data == matchingNode.Data)
            {
                parent.Left = matchingNode.Left;
            }
            else
            {
                parent.Right = matchingNode.Left;
            }

            matchingNode.Right = null;
            matchingNode.Left = null;
            return matchingNode;
            
        }
    }

    public class Driver
    {
        static void Main(string[] args)
        {
            BST bst = new BST();
            bst.Insert(56);
            bst.Insert(1234);
            bst.Insert(43);
            bst.Insert(54);
            bst.Insert(23);
            bst.Insert(1);
            bst.Insert(34);
            bst.Insert(27);

            bst.PeakInOrder();

            bst.Delete(23);

            bst.PeakInOrder();
        }
    }
}