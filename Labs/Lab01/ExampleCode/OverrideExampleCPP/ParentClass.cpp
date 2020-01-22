#include "pch.h"
#include "ParentClass.h"
#include <iostream>
using namespace std;


ParentClass::ParentClass()
{
	// Constructor
}


ParentClass::~ParentClass()
{
	// Destructor
}

void ParentClass::TestMethod()
{
	cout << "\nParentClass::TestMethod"; 
}
