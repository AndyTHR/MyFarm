using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

public class User 
{
    public string name { get; set; }
    public int Gold { get; set; }
    public int Diamond { get; set; }    
    public Map MapInGame { get; set; }
    
    public User()
    {

    }

    public User(string name, int gold, int diamond, Map mapInGame)
    {
        this.name = name;
        Gold = gold;
        Diamond = diamond;
        MapInGame = mapInGame;
    }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);

    }
}
