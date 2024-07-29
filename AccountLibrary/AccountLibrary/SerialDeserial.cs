using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace AccountLibrary
{
    public class SerialDeserial
    {
        public static void SerializeData(List<Account> accounts)
        {
            File.WriteAllText("ListAdvAccountData.json", JsonConvert.SerializeObject(accounts));

        }

        public static List<Account> DeserializeData()
        {
            List<Account> accounts = new List<Account>();
            string filename = "ListAdvAccountData.json";
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            return accounts;
        }
    }
}

