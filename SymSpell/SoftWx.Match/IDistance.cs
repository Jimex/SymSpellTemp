// Copyright ©2015-2018 SoftWx, Inc.
// Released under the MIT License the text of which appears at the end of this file.
// <authors> Steve Hatchett

namespace SoftWx.Match {
    /// <summary>Types implementing the IDistance interface provide methods
    /// for computing a relative distance between two strings.</summary>
    public interface IDistance {
        /// <summary>Return a measure of the distance between two strings.</summary>
        /// <param name="string1">One of the strings to compare.</param>
        /// <param name="string2">The other string to compare.</param>
        /// <returns>0 if the strings are equivalent, otherwise a positive number whose
        /// magnitude increases as difference between the strings increases.</returns>
        double Distance(string string1, string string2);

        /// <summary>Return a measure of the distance between two strings.</summary>
        /// <param name="string1">One of the strings to compare.</param>
        /// <param name="string2">The other string to compare.</param>
        /// <param name="maxDistance">The maximum distance that is of interest.</param>
        /// <returns>-1 if the distance is greater than the maxDistance, 0 if the strings
        /// are equivalent, otherwise a positive number whose magnitude increases as
        /// difference between the strings increases.</returns>
        double Distance(string string1, string string2, double maxDistance);
    }
}