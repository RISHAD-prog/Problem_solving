#include<iostream>
using namespace std;
class Rectangle

{
private:
    float length,breadth;

public:
    void setLength(int x)
    {
        length=x;
    }
    void setBreadth(int x)
    {
        breadth=x;
    }
    float getLength()

    {
        return length;

    }
    float getBreadth()
    {
        return breadth;
    }
    float returnArea()
    {
        int area;
        area = length * breadth;

        return area;
    }
};
int main()
 {
     int a,b;
     Rectangle prop;

    cout<< "Enter the length  : ";
    cin>>a;
    prop.setLength(a);
    cout<< "Enter the breadth  : ";
    cin>>b;
    prop.setBreadth(b);
    cout<<endl;


    cout<< "Area of Rectangle : "<<prop.getLength()<<" x "<<prop.getBreadth()<<" is "<<prop.returnArea();



    return 0;
}
