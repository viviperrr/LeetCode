#include <iostream>
#include <unordered_map>
#include <vector>
#include <algorithm>

using namespace std;

// Time & space complexity: O(n*logn), O(n)

class Solution {
    public:
        vector<vector<string>> groupAnagrams(vector<string>& strs){
            vector<vector<string>> res;
            unordered_map<string, vector<string>> map;

            for(string str: strs){
                string orderedStr = str;
                sort(orderedStr.begin(), orderedStr.end());
                vector<string> val = map[orderedStr];

                val.push_back(str);
                map[orderedStr] = val;
            }

            for (auto it : map) {
                res.push_back(it.second);
            }

            return res;
        }
};

int main(){
    vector<string> strs = {"eat","tea","tan","ate","nat","bat"};

    Solution solution;
    solution.groupAnagrams(strs);

    return 0;
}