/* Target
    - Create simple calculator with.
    - What will we have learned in this first project?
        - Here, ...
    - What is the next thing?
        - Here, ...

*/

/* syntax
    - The language is case-sensitive (So A and a are different)
    - Lines terminate with semi-colons
    - Code is put in code blocks { }
    - XML comments start with ///
        - XML comments are used for doc. your code by compiler, so when you use any method of code it show its doc. as you typed in XML comment
*/

/* variables
    Syntax:
        DataType varName = value;
            - [varName] is case sensitive;
            - [DataType]s are: int, string, float, double, char, long, short, decimal, 
    Example:
        string username = "mahros";
        int age = 19;

*/
// int age = 19;
// float GPA = 4.0F;
// string name = "Mahros";
// const string TAB = "    ";
// double scores = 9999.99999D;
// Console.WriteLine("Variables:");
// Console.WriteLine($"{TAB}Info:\n{TAB}Name: {name},\n{TAB}Age: {age},\n{TAB}GPA: {GPA},\n{TAB}Scores: {scores}");
// Console.WriteLine($"{TAB}Hi, My name is {name}, and i'm a new learner in C# and .NET framework.");

/* input/output(s)
    Syntax:
        Console.ReadLine(); // this return string value
        Console.WriteLine(text); // any value
    Note:
        - Use `Console.Write(text);` for prevent a new line from created as Console.WriteLine(string);
*/
// Console.WriteLine("What is your name? "); 
// string name = Console.ReadLine();
// Console.WriteLine($"Yeh! Your name is {name}.");
// Console.Write("Ho, My name is mahros, and you? "); string name = Console.ReadLine(); Console.WriteLine($"Hi, {name}.");

/* conditions
    Syntax:
        IF:
            if(condition){
                ...
            }else if(condition){
                ...
            }else{
                ...
            }

            ShortenIf:
                variable = condition ? valueWhenTrue : valueWhenFalse;
                NOTE: this shortenIf must be assigned to a variable.
        Switch:
            switch(value){
                case value1:
                    // do thing
                    break;
                case value2:
                    // do thing
                    break;
                default:
                    // do thing
                    break; // you can remove this, because it runs finally after test all cases.
            }
*/

// int age = 0;
// Console.Write("Enter your age: "); 
// age = Convert.ToInt32(Console.ReadLine());

// if(age > 0){
//     if(age < 18){
//         Console.WriteLine("Sorry! You aren't allowed.");
//     }else{
//         Console.WriteLine("Hi! You are allowed.");
//     }
// }else{
//     Console.WriteLine("Please! Enter correct age.");
// }

// string message = age < 18 ? "Sorry! You aren't allowed.": "Hi! You are allowed.";
// Console.WriteLine(message);

// switch(age){
//     // I know this isn't real, practical in the world but it is an example for practice.
//     case 10:
//         Console.WriteLine("Your aren't allowed here.");
//         break;
//     case 20:
//         Console.WriteLine("Your are allowed here.");
//         break;
//     default:
//         Console.WriteLine("Please! Enter correct age.");
//         break;
// }

/* loops, iterations
    Syntax:
        While:
            while(condition){
                // your code here
            }
        Do While:
            do{
                // your code here
            }while(condition);
        For:
            for(variable; condition; update){
                // your code here
            }
            NOTE:
                - We can convert (for loop) to (while loop) by:
                    for(;condition;){
                        // your code here
                    }
        ForEach:
            foreach(DataType varName in list){
                // your code here
            }
*/  

// print numbers from 1 to 100;
// int currentNumber = 1;

// while(currentNumber <= 100){
//     Console.WriteLine(currentNumber);
//     currentNumber++; // this is a simple increment.
// }

// for(currentNumber = 1; currentNumber <= 100; currentNumber++){
//     Console.WriteLine(currentNumber);
// }

// int[] numbers = {1, 2, 3}; // this is list
// foreach(int number in numbers){
//     Console.WriteLine(number);
// }

/* string operations
    - Type Casting
        Syntax:
            Convert.toInt[32/64/16](string);
*/


/* functions
    - function are like c++ syntax
    Syntax:
        Declaration:
            returnType functionName(param1, param2){ // can be void > i mean can take no param
                // your code here
            }
        Calling:
            functionName(param1, param2);

*/

// void welcome(string name){
//     Console.WriteLine($"Hi, {name}, How can i help you?");
// }

// welcome("Mahros");


/* pointers, references
    ptrType ptrName = anyReferenceValue; // reference like this &varName
    NOTE:
        - Only used in unsafe methods
*/

/* Exceptions
    Syntax:
        try{
            // your code here
        }catch(Exception ERROR){
            // code when expected error happen
        }finally{
            // code when both try and catch end.
            // this code will run certainly at any case of the try, catch.
        }
*/

// try{
//     int number = 0; 
//     Console.Write("Enter integer here: "); 
//     number = Convert.ToInt16(Console.ReadLine()); // this will show type conversion error
// }catch(Exception ERROR){
//     // Console.WriteLine(ERROR);
//     // do nothing if you want
// }finally{
//     Console.WriteLine("Code ended successfully.");
// }

/* I/O With files
    Syntax:
        - There is a OOP class that handle file
        - Reference: https://www.w3schools.com/cs/cs_files.php;
*/

using System.IO; // it's already loaded as global in Application.GlobalUsing.g.cs

// write
string path = Path.Combine("C:\\Users\\Mahros\\Desktop\\", "Mahros.txt");
File.WriteAllText(path, "START\nHi, This file created By System.IO;\n\n\nMahros.txt file\nEND");

// read
Console.WriteLine(File.ReadAllText(path));

// keep console window opened
Console.ReadLine();



/* I almost have finished C# Basic concepts, now i can move to next level as i believe. */