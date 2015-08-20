using System.Runtime.Serialization;

namespace Readify.RedPill.Service
{
    /// <summary>
    /// Triangle Type
    /// </summary>
    [DataContract(Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {
        /// <summary>
        /// The error
        /// </summary>
        [EnumMember()]
        Error = 0,

        /// <summary>
        /// The equilateral
        /// </summary>
        [EnumMember()]
        Equilateral = 1,

        /// <summary>
        /// The isosceles
        /// </summary>
        [EnumMember()]
        Isosceles = 2,

        /// <summary>
        /// The scalene
        /// </summary>
        [EnumMember()]
        Scalene = 3,
    }
}