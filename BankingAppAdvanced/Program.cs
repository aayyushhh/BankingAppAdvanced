//using BankingAppAdvanced.Model;
using AccountLibrary;


public class Program
{

    
    static void Main(string[] args)
    {
        while (true)
        {
            AccountManager.accountlist = SerialDeserial.DeserializeData();
            AccountManager.CallMainMenu();
            
        }
        
    }
}