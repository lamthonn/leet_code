
using System;

namespace Exam
{
    public class LeetCode2
    {
        //static void Main(string[] args)
        //{
        //    // create 2 linked-list
        //    ListNode lst1 = new ListNode();
        //    ListNode lst2 = new ListNode();

        //    // input two numbers
        //    Console.Write("Nhap so thu 1: ");
        //    int so1 = int.Parse(Console.ReadLine());

        //    if (so1 == 0)
        //    {
        //        lst1.Add(so1);
        //        so1 = -1;
        //    }
        //    else
        //    {
        //        while (so1 > 0)
        //        {
        //            if (so1 % 10 >= 1)
        //            {
        //                lst1.Add(so1 % 10);
        //                so1 = so1 / 10;
        //            }
        //            else
        //            {
        //                lst1.Add(so1);
        //                so1 = -1;
        //            }
        //        }
        //    }

        //    Console.Write("Nhap so thu 2: ");
        //    int so2 = int.Parse(Console.ReadLine());

        //    if (so2 == 0)
        //    {
        //        lst2.Add(so2);
        //        so2 = -1;
        //    }
        //    else
        //    {
        //        while (so2 > 0)
        //        {
        //            if (so2 % 10 >= 1)
        //            {
        //                lst2.Add(so2 % 10);
        //                so2 = so2 / 10;
        //            }
        //            else
        //            {
        //                lst2.Add(so2);
        //                so2 = -1;
        //            }
        //        }
        //    }

        //    ListNode result = AddTwoNumbers(lst1, lst2);
        //    result.PrintAllNode();
        //}

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Console.Write("\nlinked-list 1: ");
            l1.PrintAllNode();

            Console.Write("\nlinked-list 2: ");
            l2.PrintAllNode();

            // xử lý tính tổng 2 linked-list
            Node nodeOfL1 = l1.head;
            Node nodeOfL2 = l2.head;

            ListNode result = new ListNode();
            bool isBigger10 = false;

            while (nodeOfL1 != null || nodeOfL2 != null)
            {
                int num1 = 0;
                if (nodeOfL1 != null)
                {
                    num1 = nodeOfL1.data;
                    nodeOfL1 = nodeOfL1.next;
                }

                int num2 = 0;
                if (nodeOfL2 != null)
                {
                    num2 = nodeOfL2.data;
                    nodeOfL2 = nodeOfL2.next;
                }

                int sum = num1 + num2;

                if (isBigger10)
                {
                    int sumWithRemember = sum % 10 + 1;
                    if(sumWithRemember > 9)
                    {
                        result.Add(sumWithRemember % 10);
                    }
                    else
                    {
                        result.Add(sumWithRemember);
                        isBigger10 = false;

                    }
                }
                else
                {
                    result.Add(sum % 10);
                }

                if (sum > 9)
                {
                    isBigger10 = true;
                }
            }

            // nếu vẫn còn nhớ
            if (isBigger10)
            {
                result.Add(1);
            }

            // in danh sách kết quả
            return result;
        }

        // Create class Node
        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }

        // create class linked list
        public class ListNode
        {
            public Node head;

            // hàm thêm vào cuối
            public void Add(int data)
            {
                Node newNode = new Node(data);

                if (head == null)
                {
                    head = newNode;
                    return;
                }

                Node temp = head;

                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = newNode;
            }

            public void PrintAllNode()
            {
                Node temp = head;

                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }

                Console.WriteLine("null");
            }
        }
    }
}