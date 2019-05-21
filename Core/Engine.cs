using System;
using System.Collections.Generic;
using System.IO;

namespace Core
{
public class Engine
{
private static bool isUserLogged = false;
private static bool ShowAllUsers = false;

   public static bool Show
   { 
        get { return ShowAllUsers; }
        set { ShowAllUsers = value; }

   }
   public static bool Logged
   { 
        get { return isUserLogged; }
        set { isUserLogged = value; }

   }
}
}