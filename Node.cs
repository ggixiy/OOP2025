class Node
{
    public short Data { get; set; }
    public Node Next { get; set; }

    public Node(short data)
    {
        this.Data = data;
        this.Next = null;
    }
}
//TESTs