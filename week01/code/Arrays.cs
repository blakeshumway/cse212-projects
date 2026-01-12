using System.Diagnostics;

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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //step 1: create an array the size of the given length
        //step 2: create a for loop that will iterate through each value in the array
        //step 3: insert the number multiplied by the number of the position in the array + 1 since the first position would be zero
        //step 4: return the array 

        double[] numbers = new double[length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = number * (i + 1);
        }
        return numbers; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //step 1: using the amount given select the same amount of numbers at the end of the list 
        //step 2: move those numbers into a new list
        //step 3: select the remaining numbers and move them into another new list
        //step 4: clear the data from the original list
        //step 5: merge the two lists into the original list with the remaining new numbers being added second


        List<int> firstList = data.GetRange(data.Count - amount, amount);
        List<int> secondList = data.GetRange(0, data.Count - amount);

        data.Clear();

        data.AddRange(firstList);
        data.AddRange(secondList);

    }
}
