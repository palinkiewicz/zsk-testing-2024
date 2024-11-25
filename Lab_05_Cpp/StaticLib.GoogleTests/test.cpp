#include "pch.h"
#include "../StaticLib/StaticLib.cpp"

class GCDTest : public ::testing::Test {
protected:
    SomeClass someClass;
};

TEST_F(GCDTest, GCDTest_ValidInputs) {
    // Test GCD for some valid pairs
    EXPECT_EQ(someClass.gcd(54, 24), 6);  // GCD of 54 and 24 is 6
    EXPECT_EQ(someClass.gcd(101, 10), 1); // GCD of 101 and 10 is 1 (they are coprime)
    EXPECT_EQ(someClass.gcd(56, 98), 14); // GCD of 56 and 98 is 14
}

TEST_F(GCDTest, GCDTest_EqualInputs) {
    // Test when both numbers are equal
    EXPECT_EQ(someClass.gcd(100, 100), 100); // GCD of 100 and 100 is 100
    EXPECT_EQ(someClass.gcd(12345, 12345), 12345); // GCD of 12345 and 12345 is 12345
}