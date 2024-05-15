using System;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList tryNode = new LinkedList(9);
            tryNode.Append(5);
            tryNode.Append(8);
            tryNode.Append(1);
            Node n = tryNode.GetMaxNode();
            Node y = tryNode.GetMinNode();

        }
    }
}
