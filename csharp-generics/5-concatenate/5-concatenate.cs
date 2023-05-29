﻿﻿using System;

/// <summary> Custom Generic Queue class </summary>
/// <typeparam name="T"> Generic type </typeparam>
public class Queue<T>
{
    /// <summary>
    /// node head of the Queue
    /// </summary>
    public Node head = null;

    /// <summary>
    /// node tail of the Queue
    /// </summary>
    public Node tail = null;

    // Number of nodes in the Queue
    private int count = 0;

    /// <summary>
    /// Check the type of the Queue
    /// </summary>
    /// <returns>Return the Queue's type</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }

    /// <summary>
    /// Node - singly linked list
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Value is the value stored in the node
        /// </summary>
        /// <returns>default value null</returns>
        public T value = default(T);

        /// <summary>
        /// Next node in the Queue
        /// </summary>
        public Node next = null;

        /// <summary>
        /// Constructor for Node class
        /// </summary>
        /// <param name="value">can be any type</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// that creates a new Node and adds it to the end of the queue.
    /// </summary>
    /// <param name="value">Value of node can be any type</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
            head.next = null;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        this.count++;
    }

    /// <summary>
    /// count of nodes in the Queue
    /// </summary>
    /// <returns> Number of node in Queue </returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// removes the first node in the queue.
    /// </summary>
    /// <returns>returns value of deleted node</returns>
    public T Dequeue()
    {
        Node temp = head;

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        head = head.next;
        count--;
        return temp.value;
    }

    /// <summary>
    /// returns the value of the first node of the queue without removing the node.
    /// </summary>
    /// <returns> returns the value of the first node</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }

    /// <summary>
    /// prints the queue, starting from the head.
    /// if is empty prints "Queue is empty"
    /// </summary>
    public void Print()
    {
        Node temp = head;
        if (temp == null)
            Console.WriteLine("Queue is empty");
        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }

    /// <summary>
    /// concatenates all values in the queue only if the queue is of type String or Char.
    /// </summary>
    /// <returns>returns a string with all the values of the queue</returns>
    public string Concatenate()
    {
        Node temp = head;
        if (temp == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        string result = "";
        while (temp != null)
        {
            result += temp.value;
            if (typeof(T) == typeof(string) && temp.next != null)
                result += " ";
            temp = temp.next;
        }
        return result;
    }
}
