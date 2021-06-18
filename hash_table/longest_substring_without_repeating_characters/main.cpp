#include <iostream>
#include <string>
#include <set>
#include <algorithm>

using namespace std;

// Time & Space Complexity: O(n), O(n)

class Solution {
    public:
        int lengthOfLongestSubstring(string s){
            int res = 0;
            int i = 0, j = 0;
            set<char> map;

            if (s.empty())
                return res;
            
            while(j < s.length()){
                if(map.count(s[j]) == 0){
                    map.insert(s.at(j));
                    res = max(res, (int)map.size());
                    j++;
                }
                else {
                    map.erase(s[i]);
                    i++;
                }
            }

            return res;
        }
};

int main(){
    Solution solution;
    string s = "abcabcbb";

    cout << "result: " << solution.lengthOfLongestSubstring(s);

    return 0;
}