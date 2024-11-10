using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23DH113104_PhamVietTang
namespace PhamVietTang_Thi
{
    internal class LinkedListNode
    {
        public BookNode Data;
        public LinkedListNode Next;

        public LinkedListNode(BookNode data)
        {
            Data = data;
            Next = null;
        }
    }
}
