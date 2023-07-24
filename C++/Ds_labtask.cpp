#include <iostream>
using namespace std;


int main()
{
    int Size;
    cin>>Size;
    int array1[Size],i ;
    cout<<"Enter array element :";
    for( i=0; i <Size; i++)
    {cin>>array1[i];}


    cout << "Original array: ";

    for ( i=0; i <Size; i++)
   {
       cout << array1[i] <<" ";
   }
   bool check=true;
   int Count=1;
    cout <<"\nOutput: ";
    for (int i=0; i<Size; i++)
    {
        int j;
        for (j=i+1; j<Size; j++)
           {
               if (array1[i] == array1[j])
               {
                Count++;
                   for(int k=j;k<Size;k++)
                   {
                       int temp=array1[j];
                       array1[k]=array1[k+1];
                       array1[k+1]=temp;
                   }
                   Size--;
                   check=false;

               }


            }
            cout<<array1[i]<<"occurs="<<Count<<"times"<<endl;
               Count=1;

}
       /* if(check==false)
            {
                for (int i=0; i<Size; i++)
                {
                    cout<<array1[i]<<" ";
                }
            }
            else{
                cout<<"Array already Unique";
            }*/
}


