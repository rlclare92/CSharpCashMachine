Cash machine
Program using C# language to recreate a cash machine function, the program allows the user to check balance, withdraw cash, deposit cash and cancel the program. 

Pre-install
Need to download to be able to access cash machine program effectively

Download the C# extension on VS Code
Download this: https://dotnet.microsoft.com/download
Download Visual Studio for Mac 

Program Breakdown 

User details
Due to the program not having access to a database, use hardcoding user details.
User pin: 1234
User Account nUmber: 123456789

Check Pin() & CheckAccountNumber()
Both used encase as a security measurement however with no backend database, decided to add an extra securely measure, for the user to confirm their account number as well. 

This is through using a simple if statement to confirm the user input value is correct to what has been 



Further Development
- Add a console log that shows main meun options after user pin & account number have been inputed correctly.
- Focus on restirictions and limitations to user input i.e. invalid user input when required number, user inputed symbols/ letters.