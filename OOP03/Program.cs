using OOP03.Operators_Overloading;
using System.Numerics;

namespace OOP03
{
    internal class Program
    {
        static int sum(int X, int Y)
        {
            return X + Y;
        }
        static double sum(double X, double Y)
        {
            return X + Y;
        }
        static int sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }
        static double sum(int X, double Y)
        {
            return X + Y;
        }
        static void Main(string[] args)
        {
            #region OOP Pillars 3. PolyMorphism 1. Overloading

            //dynamic result = sum(2.2, 2.2);
            //result         = sum(1, 2, 3);

            //Console.WriteLine($"Result = {result}");

            //Console.WriteLine("Ahmed");
            //Console.WriteLine("A");
            //Console.WriteLine(10);
            //Console.WriteLine(true);
            //Console.WriteLineString();
            //Console.WriteLineChar();
            //Console.WriteLineInt();
            //Console.WriteLineBoolean(); 

            #endregion


            #region Operators Overloading - Binary Operators

            ComplexNumber C1 = new ComplexNumber() { Real = 2, Imag = 4 };
            ComplexNumber C2 = new ComplexNumber() { Real = 3, Imag = 5 };

            ComplexNumber C3 =default; //NULL

            C3 = C1 + C2;

            // C2 += C1  ===> C2 = C2 + C1

            Console.WriteLine($"C1 = {C1}");
            Console.WriteLine($"C2 = {C2}");
            Console.WriteLine("----------");
            Console.WriteLine($"C3 = {C3}");

            #endregion

            #region Unary Operator
            //Console.WriteLine($"C1 = {C1}");


            //Complex C3 = ++C1; Console.WriteLine("After ++C1");

            //Console.WriteLine($"C1 = {C1}");
            //Console.WriteLine($"C3 = {C3}"); 
            #endregion

            #region Relational Operator

            //if (C1 > C2)
            //    Console.WriteLine("C1 is Greater than C2");
            //else if (C1 < C2)
            //    Console.WriteLine("C1 is less than C2");
            //else
            //    Console.WriteLine("C1 Equals C2");

            #endregion




            #region Casting Operators

            #region Example 01

            //int Y = (int)C1; // Explicit Casting
            //Console.WriteLine($"Y = {Y}");
            //object O1 = 5;
            //int X = (int) O1;
            //Console.WriteLine(X); 

            #endregion

            #region Example 02

            //string Y = (string) C1; // Explicit Casting
            //Console.WriteLine($"Y = {Y}");

            //object O1 = "Ahmed";
            //string X = (string)O1;
            //Console.WriteLine(X);

            #endregion

            #endregion


            #region Casting Operators Overloading - Business Need [Mapping]

            //User user = new User()
            //{
            //    Id = 12345,
            //    FullName = "Ahmed Nasr ",
            //    Email = "AhmedNasr43@gmail.com",
            //    Password = "Password",
            //    SecurityStmp = Guid.NewGuid()
            //};

            //// Mapping [Manual] 

            //UserViewModel userViewModel = (UserViewModel)user;
            //Console.WriteLine(userViewModel.Id);
            //Console.WriteLine(userViewModel.FName);
            //Console.WriteLine(userViewModel.LName);
            //Console.WriteLine(userViewModel.Email);
            //Console.WriteLine(userViewModel.Password); 
            #endregion


        }
    }
}