#pragma once
#include "ParentClass.h"
class OtherClass : public ParentClass
{
public:
	OtherClass();
	~OtherClass();
	virtual void TestMethod() override;
};

