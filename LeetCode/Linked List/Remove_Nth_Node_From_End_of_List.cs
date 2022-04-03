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

    internal class Remove_Nth_Node_From_End_of_List
    {
        //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head == null)
            {
                return head;
            }

            ListNode current = head;
            ListNode getLength = head;
            int nodeCount = 1;

            while (getLength.next != null) // get node length
            {
                getLength = getLength.next;
                nodeCount++;
            }

            int counter = nodeCount - n;

            if(counter == 0 && nodeCount == 1)
            {
                head = null;
                return head;
            }

            if(counter == 0 && nodeCount > 1)
            {
                head = head.next;
            }
            else
            {
                while (counter != 1)
                {
                    current = current.next;
                    counter--;
                }

                current.next = current.next.next;
            }

            return head;
        }


    }
}
