using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ListNode
{
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
      {
        this.val = val;
        this.next = next;
      }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode initialListNode = new ListNode(0);
        ListNode l3 = initialListNode;
        int carry = 0;
        int sum = 0;
        int LinkedListNum = 0;

        while (l1 != null || l2 != null)
        {
            int l1Val = (l1 != null) ? l1.val : 0;
            int l2Val = (l2 != null) ? l2.val : 0;

            sum = l1Val + l2Val + carry;
            carry = sum / 10;
            LinkedListNum = sum % 10;

            ListNode newListNode = new ListNode(LinkedListNum);
            l3.next = newListNode;

            if (l1 != null)
            {
                l1 = l1.next;
            }
            if (l2 != null)
            {
                l2 = l2.next;
            }
            l3 = l3.next;

        }
        if (carry > 0)
        {
            ListNode firstListNode = new ListNode(carry);
            l3.next = firstListNode;
            l3 = l3.next;
        }
        return initialListNode.next;
    }
}


   

