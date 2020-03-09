Cash machine
Program using C# language to recreate a cash mahcine function, the program allows the user to check balance, with draw cash, desposit cash and cancel the program. 

Perequisites
Need to download to be able to access cashmachine program effectively

Download the C# extension on VS Code
Download this: https://dotnet.microsoft.com/download
Download Visual Studio for Mac 

Program Breakdown 

User details
Due to the program not having acess to a database, use hardcosing user details.
User pin: 1234
User Account nUmber: 123456789

CheckPin() & CheckAccountNumber()
Both used to encase user details are correct, normally it is the pin that is only check as a security measurement however with no backend dtatabase, decied to add an extra securely measure, for the user to ocnfirm their account number as well. 

This is through using a simple if statement to confirm the user input value is correct to what has been 



Further Development
- Add a console log that shows main meun options after user pin & account number have been inputed correctly.
- Focus on restirictions and limitations to user input i.e. invalid user input when required number, user inputed symbols/ letters.