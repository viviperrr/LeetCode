#include <iostream>
#include <vector>
#include <unordered_map>

using namespace std;

// Time & space Complexity: O(n) / O(n)
class Solution {
    public:
        vector<int> twoSum(vector<int>& nums, int target){
            unordered_map<int, int> hashmap;

            for(int i = 0; i < nums.size(); i++){
                if(hashmap.count(nums[i])){
                    int left = hashmap[nums[i]];
                    int right = i;
                    return { left, right };
                }

                hashmap[target - nums[i]] = i;
            }

            return {0, 0};        
        }
};

int main(){
    // vector<int> nums = {2,7,11,15};
    // int target = 9;

    vector<int> nums = {3,2,4};
    int target = 6;

    // vector<int> nums = {3, 3};
    // int target = 6;

    Solution twoSumObj;

    vector<int> ret = twoSumObj.twoSum(nums, target);

    cout << "Result: [ " << ret[0] << ", " << ret[1]  << " ]" << endl;

    return 0;
}
