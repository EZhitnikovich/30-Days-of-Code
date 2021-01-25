using System;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Day_22
{

    static int getHeight(Node root)
    {
        if (root == null)
            return 0;

        int h1 = 0, h2 = 0;
        
        if(root.left != null)
        {
            h1 = getHeight(root.left) + 1;
        }
        if(root.right != null)
        {
            h2 = getHeight(root.right) + 1;
        }
        return h1 > h2 ? h1 : h2;
    }

    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        int height = getHeight(root);
        Console.WriteLine(height);

    }
}