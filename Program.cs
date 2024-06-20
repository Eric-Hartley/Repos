namespace MethodsExercise2
{
    class MethodsExercise2
    {                   //Operation for adding
        public static int addVals(params int[] nums)
        {
            int result = 0;

            foreach (int j in nums)
            {
                result += j;

            }
            return result;

        }
                        //Operation for multiplying
        public static int multiplyVals(params int[] nums)
        {
            int result = 1;

            foreach (int j in nums)
            {
                result *= j;

            }
            return result;
        }
                        //Operation for subtracting
        public static int subtractVals(params int[] nums)
        {
            int result = 0;

            foreach (int j in nums)
            {
                result -= j;

            }
            return result;
        }
        public static void Main(string[] args)
        {
                        //Enter which operation, then the numbers into (a,b,...)
            int numbers = addVals(3,4,6,7,9);

            Console.WriteLine(numbers);
        }
    }
}