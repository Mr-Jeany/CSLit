using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Bank bank = new Bank();
    }
}

class Bank
{
    public Bank()
    {
        while (true)
        {
            bool resultUsAm = int.TryParse(Console.ReadLine(), out int userAmount);
            
            if (!resultUsAm) {
                Console.WriteLine("Amount must be a number");
            } else {
                User[] users = new User[userAmount];
                for (int i = 0; i < userAmount; i++)
                {
                    users[i] = new User();
                }
                break;
            }
            
            
            
        }
    }
    
    public void Command()
    {
        string[] cmds = Console.ReadLine().Split(" ");
        
        if (cmds[0] == "Show") {
            if (cmds.Length < 3) {
                Console.WriteLine("Missing arguments")
            } else {
                if (IsExisting(cmds[1]))
                {
                    FindPerson(cmds[1]).Show();
                }
                
            }
        }
    }
    
    public User FindPerson(string nme)
    {
        for (int i = 0; i < userAmount; i++)
        {
            if (userAmount[i].name == nme)
            {
                return userAmount[i];
            }
        }
        
        return userAmount[0];
    }
    
    public bool IsExisting(string name)
    {
        for (int i = 0; i < userAmount; i++)
        {
            if (userAmount[i].name == nme)
            {
                return true;
            }
        }
        
        return false;
    }
}

class User
{
    public string name;
    public decimal amount;
    public string currency;
    private string[] curs = {"rub", "usd", "eur"};
    var converters = new Dictionary<string, int>()
    {
        {"rubusd", 0.02}, // 50 rub = usd
        {"rubeur", 0.01}, // 100 rub = eur
        {"usdeur", 0.5}, // 2 usd = eur
        {"usdrub", 50}, // usd = 50 rub
        {"eurusd", 2},  // eur = 2 usd
        {"eurrub", 100}, // eur = 100 rub
        
    }
    
    public User()
    {
        while (true)
        {
            string[] args = Console.ReadLine().Split(" ");
            
            if (args.Length < 3 || !(decimal.TryParse(args[1], out amount)) || Array.IndexOf(curs, args[2]) == -1) {
                Console.WriteLine("Incorrect input");
            } else {
                name = args[0];
                currency = args[2];
                Console.WriteLine("User made successfull");
                break;
            }
        }
    }
    
    public void Show(string cur)
    {
        
    }
    
    public decimal Convert(string cur)
    {
        if (cur == currency)
        {
            return currency;
        } else if (cur == rub && currency = )
    }
}
