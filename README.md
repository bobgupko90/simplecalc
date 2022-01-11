# Simple calculator

This is a simplest task for practicing AutoCode. It's required to create a simple calculator with addition and subtraction operations for two integer numbers

# How to solve the task

1. Download the skeleton code from cloned repository. The skeleton repository contains one or more projects for inserting the target code and unit tests for task self-checking before submition in Autocode
1. Open downloaded solution with Visual Studio
1. Change the skeleton code according to the description and requirements of the task
1. Run downloaded unit tests in Visual Studio until all test will be passed
1. Remember to remove all comment lines with "TODO" becouse Sonar will cause an issue when you initiate the task check in AutoCode
1. Put changed solution into remote repository and initiate checking on Autocode 

For example, how to find the sum of given integer values **a** and **b**. 
You have a skeleton code:
   `

    public static int Add(int a, int b)
    {
        //TODO Delete line below and write your own solution 
        throw new NotImplementedException();
    }


Assume that the values for **a** and **b** have already been set and that it is a mistake to assign new values to them. The result of addition should be stored in an integer variable, for example result. Сomplete your code with an operator return result. 
Code to check in Autocode:
   `

    public static int Add(int a, int b)
    {
        int result = a + b; 
        return result;
    }




