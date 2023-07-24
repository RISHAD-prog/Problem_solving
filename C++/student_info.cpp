#include<bits/stdc++.h>
using namespace std;

struct student
{
int id,credit;
double cgpa;
};
void StudentInfo(int studentId[],int studentCredit[],double studentCgpa[], int Size)
{
    student s[Size];
    for(int i=0;i<Size;i++)
    {
        s[i].id=studentId[i];
        s[i].credit=studentCredit[i];
        s[i].cgpa=studentCgpa[i];
    }
    for(int i=0;i<Size;i++)
    {
       cout<< s[i].id<<s[i].credit<<s[i].cgpa;
    }


}
int main()
{
    int Size;
    cout<<"Enter the number of student:";
    cin>>Size;
    int  studentId[Size],studentCredit[Size];
    double studentCgpa[Size];
    for(int i=0;i<Size;i++)
    {
        cin>>studentId[i];
        cin>>studentCredit[i];
        cin>>studentCgpa[i];
    }
    StudentInfo(studentId,studentCredit,studentCgpa,Size);

}


