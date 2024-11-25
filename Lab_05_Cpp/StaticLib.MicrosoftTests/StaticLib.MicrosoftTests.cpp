#include "pch.h"
#include "CppUnitTest.h"
#include "../StaticLib/StaticLib.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace StaticLibMicrosoftTests
{
	TEST_CLASS(StaticLibMicrosoftTests)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			int expected = 10;

			int a = 30;
			int b = 100;

			SomeClass sc;
			int result = sc.gcd(a, b);

			Assert::AreEqual(expected, result);
		}

		TEST_METHOD(TestMethodPrimeNumbers)
		{
			int expected = 1;

			int a = 13;
			int b = 7;

			SomeClass sc;
			int result = sc.gcd(a, b);

			Assert::AreEqual(expected, result);
		}
	};
}
