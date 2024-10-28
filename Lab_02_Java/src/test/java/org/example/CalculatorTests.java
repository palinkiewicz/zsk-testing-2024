package org.example;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

public class CalculatorTests {
    @Test
    public void Calculator_AddIntegers_ReturnsCorrectResult() {
        Calculator calc = new Calculator();
        int a = 1;
        int b = 2;
        int expectedResult = 3;

        int result = calc.Add(a, b);

        Assertions.assertEquals(expectedResult, result);
    }

    @Test
    public void Calculator_AddDoubles_ReturnsCorrectResult() {
        Calculator calc = new Calculator();
        double a = 1.5;
        double b = 2.5;
        double expectedResult = 4.0;

        double result = calc.Add(a, b);

        Assertions.assertEquals(expectedResult, result);
    }

    @Test
    public void Calculator_SubtractIntegers_ReturnsCorrectResult() {
        Calculator calc = new Calculator();
        int a = 1;
        int b = 2;
        int expectedResult = -1;

        int result = calc.Subtract(a, b);

        Assertions.assertEquals(expectedResult, result);
    }

    @Test
    public void Calculator_SubtractDoubles_ReturnsCorrectResult() {
        Calculator calc = new Calculator();
        double a = 1.5;
        double b = 2.5;
        double expectedResult = -1.0;

        double result = calc.Subtract(a, b);

        Assertions.assertEquals(expectedResult, result);
    }

    // Parameterized
    @ParameterizedTest
    @CsvSource({
            "1, 2, 3",
            "4, 5, 9",
            "-5, 1, -4"
    })
    public void Calculator_AddIntegers_ReturnsCorrectResult_Parameterized(int a, int b, int expectedResult) {
        Calculator calc = new Calculator();

        int result = calc.Add(a, b);

        Assertions.assertEquals(expectedResult, result);
    }
}
