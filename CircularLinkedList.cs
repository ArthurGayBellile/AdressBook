using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace AdressBook
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        
        public new IEnumerator GetEnumerator()
        {
            return new CircularLinkedListEnumerator<T>(this);
        }

    }
}
