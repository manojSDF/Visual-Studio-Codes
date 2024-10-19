#include <iostream>
using namespace std;

main()
{

char name[20], address[50];

cout << "Name: ";
cin.getline(name, 20);

cout << "Address: ";
cin.getline(address, 50);

cout << endl<< "You entered " << endl;
cout << "Name = " << name << endl;
cout << "Address = " << address << endl;

}