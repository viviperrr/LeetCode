#include <iostream>
#include <unordered_map>

using namespace std;

// Time & Space Complexity: O(n), O(n)
int getNumberGoodPairsCountHashTable(int nums[], unsigned int size){
    int res = 0;

    unordered_map<int, int> hashmap;

    for(int i = 0; i < size; i++){
        if(hashmap.count(nums[i]) == 0){
            hashmap[nums[i]] = 1;
        }
        else {
            hashmap[nums[i]] = hashmap[nums[i]] + 1;
        }

        res += hashmap[nums[i]] - 1;
    }

    return res;
}

// Time & Space Complexity: O(n^2), O(1) 
int getNumberGoodPairsCountBruteForce(int nums[], unsigned int size){
    int res = 0;

    for(int i = 0; i < size - 1; i++){
        for(int j = i + 1; j < size; j++){
            if(nums[i] == nums[j]){
                res++;
            }
        }
    }

    return res;
}

int main(){

    int nums[] = {1, 2, 3, 1, 1, 3};
    // int nums[] = {1, 1, 1, 1};
    
    int len = sizeof(nums) / sizeof(nums[0]);

    int res = getNumberGoodPairsCountBruteForce(nums, len);

    cout << "Result(Brute-Force): " << res << endl;

    res = getNumberGoodPairsCountHashTable(nums, len);

    cout << "Result(HashTable): " << res << endl;

    return 0;
}