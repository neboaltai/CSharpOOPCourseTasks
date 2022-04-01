﻿using System;

namespace ListTask
{
    class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T> Head { get; private set; }

        public int Count { get; private set; }

        public SinglyLinkedList() { }

        public SinglyLinkedList(SinglyLinkedListNode<T> head)
        {
            Head = head;

            for (SinglyLinkedListNode<T> node = head; node != null; node = node.Next)
            {
                Count++;
            }
        }

        public T GetFirstValue()
        {
            return Head.Data;
        }

        public T GetValue(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Parameter value {index} is invalid. The index must be between 0 and {Count - 1} inclusive");
            }

            SinglyLinkedListNode<T> node = Head;

            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            return node.Data;
        }

        public T SetValue(int index, T newValue)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Parameter value {index} is invalid. The index must be between 0 and {Count - 1} inclusive");
            }

            SinglyLinkedListNode<T> node = Head;

            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }

            T oldValue = node.Data;

            node.Data = newValue;

            return oldValue;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), $"Parameter value {index} is invalid. The index must be between 0 and {Count - 1} inclusive");
            }

            SinglyLinkedListNode<T> currentNode = Head;

            SinglyLinkedListNode<T> previousNode = null;

            for (int i = 0; i < index; i++)
            {
                previousNode = currentNode;

                currentNode = currentNode.Next;
            }

            T value = currentNode.Data;

            if (currentNode.Next == null)
            {
                if (previousNode == null)
                {
                    Head = null;
                }
                else
                {
                    previousNode.Next = null;
                }
            }
            else
            {
                if (previousNode == null)
                {
                    Head = currentNode.Next;
                }
                else
                {
                    previousNode.Next = currentNode.Next;
                }
            }

            Count--;

            return value;
        }
    }
}