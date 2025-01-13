using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Polymorphism
{
    class TypeA
    {
        public int A { get; set; }
        public TypeA(int A)
        {
            this.A = A;
        }
        // 1. Apply overriding using "New" keyword => Hiding/Masking old method --> New method
        public void MyFun01()
        {
            Console.WriteLine(" MyFun01 => Iam Base [Parent]");
        }
        // 2. Apply overriding using "override" keyword [Method must be non-private and virtual in the first Class]
        public virtual void MyFun02()
        {
            Console.WriteLine($"MyFun02 => TypeA: A = {A}");
        }
    }
    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int A, int B) : base(A)
        {
            this.B = B;
        }
        //1. Apply Overriding Using "new" Keyword
        public new void MyFun01()  /*Static Binding Method*/
        {
            Console.WriteLine(" MyFun01 => Iam Derived [Child]");
        }

        // 2. Apply Overriding Using "override" Keyword [Must be Non-Private Virtual in the 1st]
        public override void MyFun02()  /*Dynamic Binding Method*/
        {
            Console.WriteLine($"MyFun02 => TypeB: A = {A} , B = {B}");
        }
    }
}
