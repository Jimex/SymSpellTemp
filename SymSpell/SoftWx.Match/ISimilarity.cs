namespace SoftWx.Match {
    /// <summary>Types implementing the ISimilarity interface provide methods
    /// for computing a normalized value of similarity between two strings.</summary>
    public interface ISimilarity {
        /// <summary>Return a measure of the similarity between two strings.</summary>
        /// <param name="string1">One of the strings to compare.</param>
        /// <param name="string2">The other string to compare.</param>
        /// <returns>The degree of similarity 0 to 1.0, where 0 represents a lack of any
        /// noteable similarity, and 1 represents equivalent strings.</returns>
        double Similarity(string string1, string string2);

        /// <summary>Return a measure of the similarity between two strings.</summary>
        /// <param name="string1">One of the strings to compare.</param>
        /// <param name="string2">The other string to compare.</param>
        /// <param name="minSimilarity">The minimum similarity that is of interest.</param>
        /// <returns>The degree of similarity 0 to 1.0, where -1 represents a similarity
        /// lower than minSimilarity, otherwise, a number between 0 and 1.0 where 0
        /// represents a lack of any noteable similarity, and 1 represents equivalent
        /// strings.</returns>
        double Similarity(string string1, string string2, double minSimilarity);
    }
}