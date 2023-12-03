using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

Console.WriteLine("Enter home phone number:");
var homePhone = Console.ReadLine();
static bool ValidHomePhone(string homePhone)
{
    string validHomePhone = @"^[0-9]{9}$";
    bool nameVal = Regex.IsMatch(homePhone, validHomePhone);
    return nameVal;
}
bool result_ValidHomePhone = ValidHomePhone(homePhone);
while (!result_ValidHomePhone)
{
    Console.WriteLine("Incorrect format. Try agan:");
    homePhone = Console.ReadLine();
    result_ValidHomePhone = ValidHomePhone(homePhone);
}
Console.WriteLine(result_ValidHomePhone);
Console.WriteLine();
Console.WriteLine("Enter mobile phone number:");
var mobileNumber = Console.ReadLine();
static bool ValidMobilePhone(string modilNumber)
{
    string validMobileNumber = @"^\+?[0-9]{12}$";
    bool nameVal = Regex.IsMatch(modilNumber, validMobileNumber);
    return nameVal;
}
bool result_ValidMobilePhone = ValidMobilePhone(mobileNumber);
while (!result_ValidMobilePhone)
{
    Console.WriteLine("Incorrect format. Try agan:");
    mobileNumber = Console.ReadLine();
    result_ValidMobilePhone = ValidHomePhone(mobileNumber);
}
Console.WriteLine(result_ValidMobilePhone);
Console.WriteLine();
Console.WriteLine("Enter email adress:");
var email = Console.ReadLine();
static bool ValidEmail(string email)
{
    string validEmail = @"[0-9a-zA-Z]{2,30}\.?[0-9a-zA-Z]+[@][a-zA-Z]{2,}[.][a-zA-Z]{2,}";
    bool nameVal = Regex.IsMatch(email, validEmail);
    return nameVal;
}
bool result_ValidEmail = ValidEmail(email);
while (!result_ValidEmail)
{
    Console.WriteLine("Incorrect format. Try agan:");
    email = Console.ReadLine();
    result_ValidEmail = ValidEmail(email);
}
Console.WriteLine(result_ValidEmail);
Console.WriteLine();
Console.WriteLine("Enter your full name:");
var name = Console.ReadLine();
static bool ValidName(string name)
{
    string validName = @"[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}";
    bool nameValid = Regex.IsMatch(name, validName);
    return nameValid;
}
bool result_ValidName = ValidName(name);
while (!result_ValidName)
{
    Console.WriteLine("Incorrect format. Try agan:");
    name = Console.ReadLine();
    result_ValidName = ValidEmail(name);
}
Console.WriteLine(result_ValidName);
Console.ReadLine();