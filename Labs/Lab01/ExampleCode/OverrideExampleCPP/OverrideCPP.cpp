// OverrideCPP.cpp 

#include "pch.h"
#include <iostream>
#include "ParentClass.h"
#include "OtherClass.h"
using namespace std;

void PauseForKeyPress(); 

int main()
{
    //std::cout << "Hello World!\n"; 
	ParentClass* PC1 = new ParentClass(); 
	ParentClass* PC2 = new OtherClass();
	
	cout << "\nTest 1";
	PC1->TestMethod(); 
	
	cout << "\nTest 2";
	PC2->TestMethod();
	
	PauseForKeyPress(); 
	
}

void PauseForKeyPress()
{
	cout << "\nPress Any Key To Continue";
	cin.get();

}
