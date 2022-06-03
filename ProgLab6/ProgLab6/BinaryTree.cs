using System;
namespace ProgLab6
{
    class Node
    {
        private char _data;
        private Node _leftNode;
        private Node _rightNode;

        public Node(char data)
        {
            _data = data;
        }

        public void Add(char data)
        {
            if (data >= _data)
            {
                if (_rightNode == null)
                    _rightNode = new Node(data);
                else
                    _rightNode.Add(data);
            }
            else
            {
                if (_leftNode == null)
                    _leftNode = new Node(data);
                else
                    _leftNode.Add(data);
            }
        }

        public void Find(char data, ref int amount)
        {
            if (_leftNode != null)
                _leftNode.Find(data, ref amount);
            if (_rightNode != null)
                _rightNode.Find(data, ref amount);

            if (_data == data)
                amount++;
        }

        public void Display(int space, string parent = "")
        {
            Console.WriteLine();
            for (int i = 0; i < space; i++)
            {
                Console.Write("\t");
            }
            Console.WriteLine(_data.ToString() + $"({parent})");
            if (_leftNode != null)
            {
                _leftNode.Display(space - 1, _data.ToString());
            }

            if (_rightNode != null)
                _rightNode.Display(++space, _data.ToString());
            Console.SetCursorPosition(0, Console.CursorTop - 1);

        }



        public char GetData()
        {
            return _data;
        }
    }

    class BinaryTree
    {
        public Node _root;

        public void Add(char data)
        {
            if (_root == null)
                _root = new Node(data);
            else
                _root.Add(data);
        }

        public void Find(char data, ref int amount)
        {
            if (_root != null)
                _root.Find(data, ref amount);
        }

        public void Display(int space)
        {
            if (_root == null) return;
            _root.Display(space);
        }
    }
}
