public class Solution {
    public bool hasDuplicate(int[] nums) {
        int size = nums.Length;
        HashSet <int> seen = new HashSet<int>(); 
        for (int i=0; i<size ; i++)
        {
            if (!seen.Add(nums[i]))
            return true;
            else
            seen.Add(nums[i]);
            
        }
        return false;
    }
}