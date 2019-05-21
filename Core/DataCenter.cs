using System;
using System.Collections.Generic;
using System.IO;

namespace Core
{
public class data:Engine
{
    const string FILE_DIR = @"/home/petroff/Projects/data.csv";
    //bool isUserLogged = Engine.Logged;
    
    public static void SaveData(Dictionary<user, user> dictionary, bool all)
    {
        using (var writer = new StreamWriter(FILE_DIR))
        {
            foreach (var pair in dictionary)
            {
                writer.WriteLine("{0};{1}", pair.Key, pair.Value);

                if(all)
                Console.WriteLine(string.Join(",", dictionary.Keys) + " saved with" + string.Join(",", dictionary.Values) );
            }
        }
    }
    public static void ReadData()
    {
        var lines  = File.ReadLines(FILE_DIR);
            foreach (var line in lines)
            {
               var res = line.Split(new char[] {';'});
               if (res[0] ==  Console.ReadLine())
                {                        
                Console.WriteLine("Password: ");
 
                if (res[1] == Console.ReadLine())
                {
                Engine.Logged = true;
                Console.WriteLine("You are logged in System !");  
                return;
                } else {
                Console.WriteLine("Wrong password !");  
                return;
                }

                }else{
                 Console.WriteLine("Wrong username !");
                return;
                }
            }
    }
    public static void ChangePass()
    {
            var dictionary = new Dictionary<user, user>();
            var lines  = File.ReadLines(FILE_DIR);
            foreach (var line in lines)
            {
               var res = line.Split(new char[] {';'});

               Console.WriteLine("Old Password: ");
               if (res[1] == Console.ReadLine())
               {
               Console.WriteLine("New Password: ");
               user person_id = new user { ID = res[0]};
               user person_pass = new user { PASS = Console.ReadLine()};

               dictionary.Add(person_id, person_pass);
               data.SaveData(dictionary, Engine.Show);
               Console.WriteLine("Password changed!");
               return;
               }
               
             }
                
    }
    
}
}