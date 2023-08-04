# Software1-Knowledge-Check-1

Packed everything within a while loop so that you can re prompt to continue operations until desired.
User now has the option to input "exit" to quit the application.
Switched calculator class to static so that the methods could be called without instating a new object. 
Created "CaptureValues" method for handling the input capture during the switch cases that also handles the parsing and returns true if successful.
After CaptureValues completes the parsed values are then passed into appropriate their calculator operation methods.
Rather than returning the values from each operation they are now simply printed to the console within the method.
Created a method overload of CaptureValues for handling the doubles type specifically when using the division operation.

