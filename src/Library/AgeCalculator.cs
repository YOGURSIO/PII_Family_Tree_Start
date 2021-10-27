using System;

namespace Library
{
    public class AgeCalculator : Visitor
    {
        public double AgeSum
        {
            get
            {
                return this.ageSum;
            }
            set
            {
                this.ageSum = value;
            }
        }
        private double ageSum = 0;
        public override void Visit(Node node)
        {
            this.AgeSum = node.Person.Age + this.AgeSum;
            foreach (Node item in node.Children)
            {
                this.Visit(item);
            }
        }
    }
}