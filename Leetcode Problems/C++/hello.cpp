#include <iostream>
#include <vector>
using namespace std;
class Solution
{
public:
    bool containsDuplicate(vector<int> &nums)
    {
        vector<int>::iterator iter;
        for (size_t i = 0; i < nums.size(); i++)
        {
            iter = nums.begin() + i;
            cout << *iter << " ";
        }
    }
};
int main()
{
    Solution sl;
    vector<int> nums = {1, 2, 3, 1};
    sl.containsDuplicate(nums);
}