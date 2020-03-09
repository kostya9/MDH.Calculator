# MDH.Calculator
Coding Standards and Naming Conventions
***************************************************************
1.do use PascalCasing for class names and method names.
public class ClientActivity
{
    public void ClearStatistics()
    {
        //...
    }
    public void CalculateStatistics()
    {
        //...
    }
}
***************************************************************
2.do use camelCasing for method arguments and local variables.
public class UserLog
{
    public void Add(LogEvent logEvent)
    {
        int itemCount = logEvent.Items.Count;
        // ...
    }
}
***************************************************************
3.do not use Hungarian notation or any other type identification in identifiers
// Correct
int counter;
string name;
 
// Avoid
int iCounter;
string strName;
