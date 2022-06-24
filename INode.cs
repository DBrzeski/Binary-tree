namespace Binary_tree
{
    interface INode
    {
        int Id { get; set; }
        string Name { get; set; }
        Node Next { get; set; }

        void addNext(int id, string name);
        void print();
    }
}