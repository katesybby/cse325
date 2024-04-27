//LOGGING AND TRACING IN .NET APPLICATIONS
using System.Diagnostics;

//Write information to output windows ----------------------------------------------
Console.WriteLine("This message is readable by the end user.");
Trace.WriteLine("This is a trace message when tracing the app.");
Debug.WriteLine("This is a debug message just for developers.");

Debug.Write("Debug - ");
Debug.WriteLine("This is a full line.");
Debug.WriteLine("This is another full line.");


//Conditional tracing --------------------------------------------------------------
if(count == 0)
{
    Debug.WriteLine("The count is 0 and this may cause an exception.");   
}

Debug.WriteLineIf(count == 0, "The count is 0 and this may cause an exception.");   //WriteLineIf

bool errorFlag = false;  
System.Diagnostics.Trace.WriteIf(errorFlag, "Error in AppendData procedure.");  
System.Diagnostics.Debug.WriteIf(errorFlag, "Transaction abandoned.");  
System.Diagnostics.Trace.Write("Invalid value for data request");


//Verify that certain conditions exist ---------------------------------------------
int IntegerDivide(int dividend, int divisor)
{
    Debug.Assert(divisor != 0, $"{nameof(divisor)} is 0 and will cause an exception.");

    return dividend / divisor;
}

