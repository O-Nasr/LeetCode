namespace LeetCode.Array
{
    public class Product_Except_Self
    {
        //https://leetcode.com/problems/product-of-array-except-self/
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];
            int temp = 1;
            //prefix 
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = temp;
                temp *= nums[i];
            }

            temp = 1;
            //suffix
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= temp;
                temp *= nums[i];
            }

            return result;
        }
    }
}
