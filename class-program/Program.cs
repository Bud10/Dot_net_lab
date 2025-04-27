// See https://aka.ms/new-console-template for more information
using dotnet_class;

Console.WriteLine("Hello, World!");

functionOverloading numObj = new functionOverloading();
int addIntegerResult = numObj.Add(2, 3);
Console.WriteLine(addIntegerResult);
double addDoubleResult = numObj.Add(2.5, 4.6);
Console.WriteLine(addDoubleResult);

int  multiplyIntegerResult = numObj.Multiply(2, 3);
Console.WriteLine(multiplyIntegerResult);
double multiplyDoubleResult = numObj.Multiply(2.4, 4.5);
Console.WriteLine(multiplyDoubleResult);

Interface interfaceObj = new Interface();
Console.WriteLine(interfaceObj.Add(2,3));
Console.WriteLine(interfaceObj.Multiply(2,3));
Console.WriteLine(interfaceObj.Divide(2,3));
Console.WriteLine(interfaceObj.Subtract(2,4));

Palindrome checkingPalindrome = new Palindrome();
checkingPalindrome.checkPalindrome();


