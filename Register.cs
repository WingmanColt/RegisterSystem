using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Core;

class Program
{
    const string FILE_DIR = @"/home/petroff/Projects/data.csv"; 

    static void Main (string[] args) 
    {
        var engine = new Engine();
        var dictionary = new Dictionary<user, user>();
        
        string input;

    Console.WriteLine("Welcome to Register System by iNexus !");
    Console.WriteLine("Type 'REGISTER' or 'LOGIN' ...");

    switch ((input = Console.ReadLine()))
    {
        case "REGISTER":
        {
         Console.WriteLine("Press enter to continue register...");
         Console.WriteLine("Type 'SHOW' to see all users in list...");
         Console.WriteLine("Type 'END' to exit from register systeM...");

        if((input = Console.ReadLine()) == "SHOW")
        {
        Engine.Show = true;
        Console.WriteLine("Show all users list is Activated !!!");
        Console.WriteLine("Press enter to continue...");
        }else Engine.Show = false;
       
        while ((input = Console.ReadLine()) != "END")
        {
            Console.WriteLine("Enter Username: ");
            user person_id = new user { ID = Console.ReadLine()};

            Console.WriteLine("Enter Password: ");
            user person_pass = new user { PASS = Console.ReadLine()};

            if(input != "END")
            {
            dictionary.Add(person_id, person_pass);
            data.SaveData(dictionary, Engine.Show);
            
            if(!Engine.Show)
            {
            Console.WriteLine(string.Join (",", person_id) + " saved with password " + string.Join(",", person_pass));
            Console.WriteLine("Press enter to continue ...");
            }
            }
        }
    } break;

case "LOGIN":
{
    if(data.Logged)
    {
       Console.WriteLine("You are already logged in system !"); 
       return;
    }
           Console.WriteLine("Press enter to continue login...");
    
            while ((input = Console.ReadLine()) != "END")
            {
                if(Engine.Logged)
                {
                Console.WriteLine("Type 'CHANGE' to change your password!");
                if((input = Console.ReadLine()) == "CHANGE")
                data.ChangePass();
                return;
                }
                
                Console.WriteLine("Username: ");
                data.ReadData();
            }            
} break;

}   
}    


}


