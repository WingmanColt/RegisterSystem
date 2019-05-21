using System;
using Core;

public class user:Engine
 {
    private string user_id;
    public string ID {
        get { return user_id; }
        set { user_id = value; }
    }

    private string user_pass;
    public string PASS {
        get { return user_pass; }
        set { user_pass = value; }
    }

    public override string ToString () {
        return user_id + user_pass;
    }

}