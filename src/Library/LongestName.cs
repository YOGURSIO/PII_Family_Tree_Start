using System;

namespace Library
{
    public class LongestNameClass : Visitor
    {
        public string LongestName
        {
            get
            {
                return this.longestName;
            }
            set
            {
                this.longestName = value;
            }
        }
        private string longestName = "";
        public override void Visit(Node node)
        {
            if (this.LongestName.Length <= node.Person.Name.Length) 
            {
                this.LongestName = node.Person.Name;
            }
            foreach (Node item in node.Children)
            {
                this.Visit(item);
            }
        }
    }
}