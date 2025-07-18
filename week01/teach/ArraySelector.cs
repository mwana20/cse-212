public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        // Create result array with same length as select
        int[] result = new int[select.Length];
        
        // Track current position in each source array
        int list1Index = 0;
        int list2Index = 0;
        
        // Loop through the select array
        for (int i = 0; i < select.Length; i++)
        {
            if (select[i] == 1)
            {
                // Take next element from list1
                result[i] = list1[list1Index];
                list1Index++; // Move to next position in list1
            }
            else if (select[i] == 2)
            {
                // Take next element from list2
                result[i] = list2[list2Index];
                list2Index++; // Move to next position in list2
            }
        }
        
        return result;
    }
}