using System;

/// <summary>
/// Summary description for public class Account 
/// </summary>
public class Account
{
    private static decimal minIncome;
    private static int minAge;

    public static bool AccountAllowed(decimal income, int age)
    { if ((income >= minIncome) && (age >= minAge))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
