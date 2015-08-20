using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readify.RedPill.Service;

namespace Readify.RedPill.UnitTest
{
    /// <summary>
    /// RedPillManager UnitTest
    /// </summary>
    [TestClass]
    public class RedPillManagerUnitTest
    {
        private RedPillManager redPillManager;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            redPillManager = new RedPillManager();
        }

        #region WhatIsYourToken
        /// <summary>
        /// Whats the is your token_ call method_ return valid unique identifier.
        /// </summary>
        [TestMethod]
        public void WhatIsYourToken_CallMethod_ReturnValidGuid()
        {
            var token = redPillManager.WhatIsYourToken();
            Assert.AreEqual(new Guid("1fc7ffe8-b06c-4484-97df-7b0629fd2b68"), token);
        }
        #endregion

        #region FibonacciNumber
        /// <summary>
        /// Fibonaccis the number_0 as value test_ return valid sum.
        /// </summary>
        [TestMethod]
        public void FibonacciNumber_0AsValueTest_ReturnValidSum()
        {
            var value = redPillManager.FibonacciNumber(0);
            Assert.AreEqual(value, 0);
        }

        /// <summary>
        /// Fibonaccis the number_1 as value test_ return valid sum.
        /// </summary>
        [TestMethod]
        public void FibonacciNumber_1AsValueTest_ReturnValidSum()
        {
            var value = redPillManager.FibonacciNumber(1);
            Assert.AreEqual(value, 1);
        }

        /// <summary>
        /// Fibonaccis the number_2 asl value test_ return valid sum.
        /// </summary>
        [TestMethod]
        public void FibonacciNumber_2AslValueTest_ReturnValidSum()
        {
            var value = redPillManager.FibonacciNumber(2);
            Assert.AreEqual(value, 1);
        }

        /// <summary>
        /// Fibonaccis the number_10 as value test_ return valid sum.
        /// </summary>
        [TestMethod]
        public void FibonacciNumber_10AsValueTest_ReturnValidSum()
        {
            var value = redPillManager.FibonacciNumber(10);
            Assert.AreEqual(value, 55);
        }

        /// <summary>
        /// Fibonaccis the number_93 as value test_ throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException),
    "Fib(> 92) will cause a 64 - bit integer overflow.")]
        public void FibonacciNumber_93AsValueTest_ThrowArgumentOutOfRangeException()
        {
            var value = redPillManager.FibonacciNumber(93);
        }
        #endregion

        #region ReverseWords
        /// <summary>
        /// Reverses the words_ hello world string_ return reversed words.
        /// </summary>
        [TestMethod]
        public void ReverseWords_HelloWorldString_ReturnReversedWords()
        {
            var token = redPillManager.ReverseWords("Hello World");
            Assert.AreEqual("olleH dlroW", token);
        }

        /// <summary>
        /// Reverses the words_null as value_ throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
    "Value cannot be null.")]
        public void ReverseWords_nullAsValue_ThrowArgumentOutOfRangeException()
        {
            var token = redPillManager.ReverseWords(null);
        }
        #endregion

        #region WhatShapeIsThis
        /// <summary>
        /// Whats the shape is this_ one side as zero value_ return error.
        /// </summary>
        [TestMethod]
        public void WhatShapeIsThis_OneSideAsZeroValue_ReturnError()
        {
            var triangleType = redPillManager.WhatShapeIsThis(0, 1, 1);
            Assert.AreEqual(TriangleType.Error, triangleType);
        }

        /// <summary>
        /// Whats the shape is this_ invalid triangle sides_ return error.
        /// </summary>
        [TestMethod]
        public void WhatShapeIsThis_InvalidTriangleSides_ReturnError()
        {
            var triangleType = redPillManager.WhatShapeIsThis(1, 1, 2);
            Assert.AreEqual(TriangleType.Error, triangleType);
        }

        /// <summary>
        /// Whats the shape is this_ two sides equal value_ return isosceles.
        /// </summary>
        [TestMethod]
        public void WhatShapeIsThis_TwoSidesEqualValue_ReturnIsosceles()
        {
            var triangleType = redPillManager.WhatShapeIsThis(10, 20, 20);
            Assert.AreEqual(TriangleType.Isosceles, triangleType);
        }

        /// <summary>
        /// Whats the shape is this_ three side equal value_ return equilateral.
        /// </summary>
        [TestMethod]
        public void WhatShapeIsThis_ThreeSideEqualValue_ReturnEquilateral()
        {
            var triangleType = redPillManager.WhatShapeIsThis(20, 20, 20);
            Assert.AreEqual(TriangleType.Equilateral, triangleType);
        }

        /// <summary>
        /// Whats the shape is this_ three side un equal value_ return scalene.
        /// </summary>
        [TestMethod]
        public void WhatShapeIsThis_ThreeSideUnEqualValue_ReturnScalene()
        {
            var triangleType = redPillManager.WhatShapeIsThis(10, 20, 21);
            Assert.AreEqual(TriangleType.Scalene, triangleType);
        }

        #endregion
    }
}
