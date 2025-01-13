using System;

namespace Assigment
{
    #region Q03

    public class ComplexNumber
    {

        public int Real { get; set; }
        public int Imag { get; set; }
        

        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0),
            };

        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0),
            };
        }
    }
    #endregion


    #region Q05

    public class BaseClass
    {
      
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }

    public class DerivedClass1 : BaseClass
    {
      
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }

    public class DerivedClass2 : BaseClass
    {
        
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }


    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q05

            BaseClass Base;
            DerivedClass1 derived1 = new DerivedClass1();
            DerivedClass2 derived2 = new DerivedClass2();

            Base = derived1;
            Base.DisplayMessage(); // Message from DerivedClass1

            Base = derived2;
            Base.DisplayMessage(); // Message from BaseClass

            derived2.DisplayMessage(); // Message from DerivedClass2

            #endregion
        }
    }
}