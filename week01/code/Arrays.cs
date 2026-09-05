public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // 1. Create a new array with the specified length.
        // 2. Use a loop to go through each position in the array.
        // 3. Calculate each multiple by multiplying the number by the position plus 1.
        // 4. Store each multiple in the array.
        // 5. Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples [i] = number * (i + 1);
        }

        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // 1. Find the index where the last 'amount' items begin.
        // 2. Get the last 'amount' items.
        // 3. Get the items before those items.
        // 4. Clear the original list.
        // 5. Add the last items first.
        // 6. Add the beginning items after them.

        int splitIndex = data.Count - amount;
        List<int> end = data.GetRange(splitIndex, amount);
        List<int> beginning = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(end);
        data.AddRange(beginning);
    }
}
