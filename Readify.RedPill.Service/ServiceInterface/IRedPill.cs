using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Readify.RedPill.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRedPill" in both code and config file together.
    /// <summary>
    /// RedPill
    /// </summary>
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        /// <summary>
        /// Whats the is your token.
        /// </summary>
        /// <returns>Token as Guid</returns>
        [OperationContract]
        Task<Guid> WhatIsYourToken();

        /// <summary>
        /// Fibonaccis the number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>FibonacciNumber as long</returns>
        [OperationContract]
        [FaultContract(typeof(ArgumentOutOfRangeException))]
        Task<long> FibonacciNumber(long n);

        /// <summary>
        /// Whats the shape is this.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns>TriangleType as Enum</returns>
        [OperationContract]
        Task<TriangleType> WhatShapeIsThis(int a, int b, int c);

        /// <summary>
        /// Reverses the words.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>ReverseWords as string</returns>
        [OperationContract]
        [FaultContract(typeof(ArgumentNullException))]
        Task<string> ReverseWords(string s);
    }
}
