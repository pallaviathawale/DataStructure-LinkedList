﻿namespace DataStructure_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            Console.ReadLine();
        }
    }
    
}