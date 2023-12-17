/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        
 //1- basic way. foreach in nums. foreach in current position in foreach nums+1
        int index =0;
        foreach(int a in nums){
            for(int b= index+1;b<nums.Length; b++){
                if(a+nums[b]==target){
                    return new int[] {index,b};
                    }
                }
            index++;
            }
        return null;
    }
}
// @lc code=end

