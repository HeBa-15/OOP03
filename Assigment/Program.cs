using System;

namespace Assigment
{
    #region Q03

    //public class ComplexNumber
    //{

    //    public int Real { get; set; }
    //    public int Imag { get; set; }
        

    //    public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
    //    {
    //        return new ComplexNumber
    //        {
    //            Real = (left?.Real ?? 0) + (right?.Real ?? 0),
    //            Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0),
    //        };

    //    }

    //    public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
    //    {
    //        return new ComplexNumber
    //        {
    //            Real = (left?.Real ?? 0) - (right?.Real ?? 0),
    //            Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0),
    //        };
    //    }
    //}
    #endregion


    #region Q05

    //public class BaseClass
    //{
      
    //    public virtual void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from BaseClass");
    //    }
    //}

    //public class DerivedClass1 : BaseClass
    //{
      
    //    public override void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from DerivedClass1");
    //    }
    //}

    //public class DerivedClass2 : BaseClass
    //{
        
    //    public new void DisplayMessage()
    //    {
    //        Console.WriteLine("Message from DerivedClass2");
    //    }
    //}


    #endregion


    #region Part02 
  

    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

       
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int totalSeconds)
        { 
            Hours = totalSeconds / 3600; 
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }


        public override string ToString() 
        {
            if (Hours > 0) 
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            } 
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}"; 
            }
            else 
            { 
                return $"Seconds: {Seconds}"; 
            } 
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

        
        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
    }

   
   
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q05

            //BaseClass Base;
            //DerivedClass1 derived1 = new DerivedClass1();
            //DerivedClass2 derived2 = new DerivedClass2();

            //Base = derived1;
            //Base.DisplayMessage(); // Message from DerivedClass1

            //Base = derived2;
            //Base.DisplayMessage(); // Message from BaseClass

            //derived2.DisplayMessage(); // Message from DerivedClass2

            #endregion

            #region part02 

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString()); // Output: Hours: 1, Minutes: 10, Seconds: 15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); // Output: Hours: 1, Minutes: 0, Seconds: 0

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); // Output: Hours: 2, Minutes: 10, Seconds: 0

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString()); // Output: Minutes: 11, Seconds: 6 }


            #endregion


        }
    }
}