#include <bits/stdc++.h>
using namespace std;
int main()
{
    int input, n;
    int arr[1000];
    int arr2[1000];
    int arr3[1000];
    int Count = 0;
    cin >> n;
    for (int i = 0; i < n; i++)
    {
        cin >> input;

        for (int j = 1; j <= input; j++)
        {
            arr[j] = j;
            arr2[j] = arr[j];
        }
        for (int k = 1; k <= 9; k++)
        {

            for (int l = k + 9; l <= input; l++)
            {
                Count = 1;

                if (arr[k] % 2 != 0)
                {

                    while (arr[l] != 0)
                    {

                        if (arr[l] % 10 == 1)
                        {
                            Count++;
                        }
                        else if (arr[l] % 10 == 3)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 5)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 7)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 9)
                        {

                            Count++;
                        }
                        arr[l] = arr[l] / 10;
                        arr3[k] = Count;
                    }
                }
                else
                {
                    while (arr[l] != 0)
                    {
                        if (arr[l] % 10 == 0)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 2)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 4)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 6)
                        {

                            Count++;
                        }
                        else if (arr[l] % 10 == 8)
                        {

                            Count++;
                        }
                        arr[l] = arr[l] / 10;
                        arr3[k] = Count;
                    }
                }

                arr[l] = arr2[l];
            }
        }
        for (int k = 1; k <= 9; k++)
        {
            cout << arr3[k] << " ";
        }
    }
}
