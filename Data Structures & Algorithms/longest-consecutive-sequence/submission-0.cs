public class Solution {
    public int LongestConsecutive(int[] nums) {
        int res = 0;
        HashSet<int> store = new HashSet<int>(nums);

        foreach (int num in nums) {
            int streak = 0, curr = num;
            if(store.Contains(num-1)) continue;
            while (store.Contains(curr)) {
                streak++;
                curr++;
            }
            res = Math.Max(res, streak);
        }
        return res;
    }
}