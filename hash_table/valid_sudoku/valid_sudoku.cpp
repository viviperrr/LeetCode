#include <iostream>
#include <vector>
#include <set>

using namespace std;

// Time & Space Complexity: O(n) & O(n)

class Solution{
    public:
        bool isValidSudoku(vector<vector<char>>& board){
            int r = 0, c = 0;
            int rowLen = board.size();
            int columnLen = board[0].size();

            set<char> map;

            // valid line by line

            while(r < rowLen)
            {
                while (c < columnLen)
                {
                    char val = board[r][c];

                    if(val != '.')
                    {
                        if(map.count(val) == 0){
                            map.insert(val);
                        }
                        else {
                            return false;
                        }
                    }
                    c++;
                }

                r++;
                c = 0;
                map.clear();
            }

            r = 0;
            c = 0;

            while(c < columnLen)
            {
                while (r < rowLen)
                {
                    char val = board[r][c];

                    if(val != '.')
                    {
                        if(map.count(val) == 0){
                            map.insert(val);
                        }
                        else {
                            return false;
                        }
                    }
                    r++;
                }

                c++;
                r = 0;
                map.clear();
            }

            r = 1;
            c = 1;

            while(r < rowLen){
                while(c < columnLen){
                    for(int i = -1; i < 2; i++){
                        for(int j = -1; j < 2; j++){
                            char val = board[r + i][c + j];

                            if(val != '.')
                            {
                                if(map.count(val) == 0){
                                    map.insert(val);
                                }
                                else {
                                    return false;
                                }
                            }
                        }
                    }

                    map.clear();
                    c += 3;
                }

                r += 3;
                c = 1;
                map.clear();
            }

            return true;
        }
};

int main(){
    return 0;
}