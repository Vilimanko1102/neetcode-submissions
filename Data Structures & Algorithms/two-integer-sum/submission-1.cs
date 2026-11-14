public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            int comp = target - nums[i];
            if(dict.ContainsKey(comp)){
                return new int[2] {Math.Min(i, dict[comp]), Math.Max(i, dict[comp])};
            }
            else{
                dict.Add(nums[i], i);
            }
        }

        return null;
    }
}
