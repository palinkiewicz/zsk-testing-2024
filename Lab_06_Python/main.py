import unittest
import pytest

class TestClass(unittest.TestCase):
    def test_1(self):
        self.assertEqual(1, 1)

    def test_2(self):
        self.assertEqual(3, fibonacci(3))

def test_3():
    assert 1 == 1

def test_4():
    assert fibonacci(4) == 5

def fibonacci(n):
    if n <= 1:
        return 1
    else:
        return fibonacci(n - 1) + fibonacci(n - 2)


if __name__ == '__main__':
    unittest.main()
    pytest.main()
