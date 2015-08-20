using System;
using System.Linq;

namespace Readify.RedPill.Service
{
    /// <summary>
    /// RedPill manager
    /// </summary>
    public class RedPillManager
    {
        /// <summary>
        /// Whats the is your token.
        /// </summary>
        /// <returns>Token as guid</returns>
        public Guid WhatIsYourToken()
        {
            return new Guid("1fc7ffe8-b06c-4484-97df-7b0629fd2b68");
        }

        /// <summary>
        /// Fibonaccis the number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>Value as long</returns>
        /// <exception cref="ArgumentOutOfRangeException">s;Fib(> 92) will cause a 64 - bit integer overflow.</exception>
        public long FibonacciNumber(long n)
        {
            if (n > 92)
                throw new ArgumentOutOfRangeException("s", "Fib(> 92) will cause a 64 - bit integer overflow.");

            long firstnumber = 0, secondnumber = 1, result = 0;

            if (n == 0) return 0; //To return the first Fibonacci number    
            if (n == 1) return 1; //To return the second Fibonacci number    

            for (var count = 2; count <= n; count++)
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

            return result;
        }

        /// <summary>
        /// Reverses the words.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>Reverse words as string</returns>
        /// <exception cref="ArgumentNullException">s;Value cannot be null</exception>
        public string ReverseWords(string s)
        {
            if (s == null)
                throw new ArgumentNullException("s", "Value cannot be null.");

            return string.Join(" ", s.Split(' ').Select(x => new String(x.Reverse().ToArray())).ToArray());
        }

        /// <summary>
        /// Whats the shape is this.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns>Triangle type as Enum value</returns>
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            // keeping this as the first check in case someone passes invalid parameters that could also be a triangle type. 
            //Example: -2,-2,-2 could return Equilateral instead of Error without this check.  
            //We also have a catch all at the end that returns Error if no other condition was met.
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return TriangleType.Error;
            }

            if (!(a + b > c && a + c > b && b + c > a))
            {
                return TriangleType.Error;
            }

            //Placing items in an array for processing 
            int[] values = new int[3] { a, b, c };

            int distinctValue = values.Distinct().Count();
            switch (distinctValue)
            {
                case 1:
                    return TriangleType.Equilateral;
                case 2:
                    return TriangleType.Isosceles;
                case 3:
                    return TriangleType.Scalene;
                default:
                    return TriangleType.Error;
            }
        }
    }

}
