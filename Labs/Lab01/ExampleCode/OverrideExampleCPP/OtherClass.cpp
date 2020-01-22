#include "pch.h"
#include "OtherClass.h"
#include <iostream>
using namespace std;


OtherClass::OtherClass()
{
	// Constructor
}


OtherClass::~OtherClass()
{
	// Destructor
}

void OtherClass::TestMethod()
{
	ParentClass::TestMethod(); 
	cout << "\nOtherClass::TestMethod";
}