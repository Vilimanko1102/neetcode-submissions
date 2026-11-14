public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] answer = new int[nums.Length];

        int zeroCount=0;
        int zeroIndex=0;
        int prod = 1;

        for(int i=0;i<nums.Length;i++){
            if(nums[i]==0){
                zeroCount++;
                zeroIndex = i;
            }
            else{
                prod *= nums[i];
            }
        }

        if(zeroCount >= 2) return answer;
        if(zeroCount == 1){
            answer[zeroIndex] = prod;
            return answer;
        }

        for(int i=0;i<nums.Length;i++){
            answer[i] = prod / nums[i];
        }

        return answer;
    }
}