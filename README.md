# Implement the TDD for given requirement:

#TDD Phase

-First, we write a test that represents a specific requirement of the functionality we’re trying to implement.

-We then make the test pass, writing the minimum amount of code we can get away with.

# Implementation 
-I've created a class called StringCalculator, with a single method.
-The method takes a string representing numbers separated by a comma, and return their sum.
-If we pass an empty string, the method should return zero.
-Passing a single number should result in the number itself.
-If we pass negative numbers, the method should throw an ArgumentException, with the message “Negative numbers are not allowed:” followed by the negatives that were specified.
