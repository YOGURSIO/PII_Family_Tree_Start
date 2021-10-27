using System.Collections.Generic;

namespace Library
{
    public class OldestSon : Visitor
    {
        public double OldestSonAge
        {
            get
            {
                return this.oldestSonAge;
            }
            set
            {
                this.oldestSonAge = value;
            }
        }
        private double oldestSonAge = 0;
        public override void Visit(Node node)
        { 
            if (node.Children.Count == 0) 
            {
                if (node.Person.Age >= this.OldestSonAge)
                {
                    this.OldestSonAge = node.Person.Age; 
                }
            }
            else
            {
                foreach (Node item in node.Children)
                {
                    this.Visit(item);
                }
            }
        }
    }
}