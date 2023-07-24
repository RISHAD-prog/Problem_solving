#include<bits/stdc++.h>
using namespace std;
int Ckt(int R1, int IT)
{
    int V=IT*R1;
    return V;
}
double Ckt(int R1,double R2 )
{
    int IT=10;
    double CDR=IT*R1/(R1+R2);
    return CDR;
}
double Ckt(double R1,double R2)
{
    int VT=100;
    double VDR=VT*R1/(R1+R2);
    return VDR;
}
int main()
{
    cout<<"ohm's law:"<<Ckt(10,10)<<endl;
    cout<<"CDR:"<<Ckt(12,10.5)<<endl;
    cout<<"VDR:"<<Ckt(11.5,12.5)<<endl;
}
