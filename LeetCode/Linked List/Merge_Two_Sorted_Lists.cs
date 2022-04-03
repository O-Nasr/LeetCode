namespace LeetCode.Linked_List
{

    //Definition for singly-linked list.
/*    internal class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }*/


    internal class Merge_Two_Sorted_Lists
    {
        //https://leetcode.com/problems/merge-two-sorted-lists/submissions/
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if(list1 == null)
            {
                return list2;
            }

            if(list2 == null)
            {
                return list1;
            }

            ListNode cur1 = list1;
            ListNode prev1 = null;
            ListNode cur2 = list2;
            ListNode prev2 = null;
            ListNode head = null;

            while (cur1 != null)
            {
                if(cur1.val <= cur2.val)
                {
                    if(head == null)
                    {
                        head = list1;
                    }
                    if(prev2 != null)
                    {
                        prev1 = cur1;
                        cur1 = cur1.next;
                        prev2.next = prev1;
                        prev1.next = cur2;
                        prev2 = prev2.next;
                    }
                    else // if at minimum first two element in list1 < the first element in list2 
                    {
                        prev1 = cur1;
                        cur1 = cur1.next;
                        prev1.next = cur2;
                        prev2 = prev1;
                    }
                }
                else
                {
                   
                    if(head == null)
                    {
                        head = list2;
                    }

                    prev2 = cur2;
                    cur2 = cur2.next;

                    if(cur2 == null)
                    {
                        prev2.next = cur1;
                        break;
                    }
                }
            }

            return head;
        }
    }
}
