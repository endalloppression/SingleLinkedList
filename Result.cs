using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
     class Result
    {
        public static int maximumPages(SinglyLinkedListNode head)
        {
            var count = 0;
            for (var node = head; node != null; node = node.next)
            {
                count += node.data;                
            }

            return count;
               
        }
    }
}
