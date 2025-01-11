using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP03.Operators_Overloading
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operators Overloading

        // Overloading Operator: Must be Non-Private Class Member Function
        public static ComplexNumber operator +(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0),
            };
            // Left?.Real
            // Left != null? Left.Real : null
        }

        public static ComplexNumber operator -(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0),
            };
        }

        #endregion

        #region Unary Operators
        public static ComplexNumber operator ++(ComplexNumber C)
        {
            return new ComplexNumber
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = (C?.Imag ?? 0)
            };
        }
        public static ComplexNumber operator --(ComplexNumber C)
        {
            return new ComplexNumber
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = (C?.Imag ?? 0)
            };
        } 
        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
