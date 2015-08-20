using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Readify.RedPill.Service
{
    /// <summary>
    /// RedPill
    /// </summary>
    [ServiceBehavior(Namespace = "http://KnockKnock.readify.net")]
    [ErrorBehavior(typeof(HttpErrorHandler))]
    public class RedPill : IRedPill
    {
        private readonly RedPillManager  manager = new RedPillManager();

        /// <summary>
        /// Fibonaccis the number.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        /// FibonacciNumber as long
        /// </returns>
        public async Task<long> FibonacciNumber(long n)
        {
            return await Task.Factory.StartNew(() => manager.FibonacciNumber(n));
        }

        /// <summary>
        /// Reverses the words.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>
        /// ReverseWords as string
        /// </returns>
        public async Task<string> ReverseWords(string s)
        {
            return await Task.Factory.StartNew(() => manager.ReverseWords(s));
        }

        /// <summary>
        /// Whats the is your token.
        /// </summary>
        /// <returns>
        /// Token as Guid
        /// </returns>
        public async Task<Guid> WhatIsYourToken()
        {
            //return await Task.Factory.StartNew(() => new Guid("1fc7ffe8-b06c-4484-97df-7b0629fd2b68"));
            return await Task.Factory.StartNew(() => manager.WhatIsYourToken());
        }

        /// <summary>
        /// Whats the shape is this.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <param name="c">The c.</param>
        /// <returns>
        /// TriangleType as Enum
        /// </returns>
        public async Task<TriangleType> WhatShapeIsThis(int a, int b, int c)
        {
            return await Task.Factory.StartNew(() => manager.WhatShapeIsThis(a,b,c));
        }
    }
}
