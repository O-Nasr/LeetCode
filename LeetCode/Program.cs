using LeetCode.Array;
using LeetCode.Linked_List;
using System;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Longest_Consecutive_Sequence.LongestConsecutive(new int[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 });

            /*int numberOfNodes = Convert.ToInt32(Console.ReadLine());
            ListNode head = null;
            for (int i = 0; i < numberOfNodes; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                insertNodeAtTail(ref head, value);
            }
            Console.WriteLine("------------------------------------");
            int n = Convert.ToInt32(Console.ReadLine());
            Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(head, n);*/
        }

        public static void DisplayCollection(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static ListNode insertNodeAtTail(ref ListNode head ,int val)
        {
            ListNode node = new ListNode(val: val);
            ListNode tail = head;
            if(head == null)
            {
                head = node;
            }
            else
            {
                if(head.next == null)
                {
                    head.next = node;
                }
                else
                {
                    while (tail.next != null)
                    {
                        tail = tail.next;
                        if (tail.next == null)
                        {
                            tail.next = node;
                            tail = node;
                        }
                    }
                }
            }
            return head;
        }
    }
}
