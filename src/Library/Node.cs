using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private Person person;
        public Person Person
        {
            get
            {
                return this.person;
            }
            private set
            {
                this.person = value;
            }
        }
        private List<Node> children = new List<Node>();
        public ReadOnlyCollection<Node> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }
        public Node(Person person)
        {
            this.Person = person;
        }
        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
        public double GetAgeSum()
        {
            AgeCalculator visitorAgeSum = new AgeCalculator();
            this.Accept(visitorAgeSum);
            return visitorAgeSum.AgeSum;
        }
        public double GetOldestSonAge() 
        {
            OldestSon visitorOldestSon = new OldestSon();
            this.Accept(visitorOldestSon);
            return visitorOldestSon.OldestSonAge;
        }
        public string GetLongestName()
        {
            LongestNameClass visitorLongestNameClass = new LongestNameClass();
            this.Accept(visitorLongestNameClass);
            return visitorLongestNameClass.LongestName;
        }
    }
}