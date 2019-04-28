using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names: MonoBehaviour {
    public List<Prefix> prefix = new List<Prefix>();
    public List<string> swordNames = new List<string>();

    #region Singleton

    public static Names instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one istance of ItemNames found!");
            return;
        }
        instance = this;

        // prefixes (worst -> best)
        prefix.Add(new Prefix("Blunt", 0.5f, 0.5f));
        prefix.Add(new Prefix("Weak", 0.75f, 0.75f));
        prefix.Add(new Prefix("Old", 0.9f, 0.9f));
        prefix.Add(new Prefix("Normal", 1f, 1f));
        prefix.Add(new Prefix("Strong",1.25f,1.25f));
        prefix.Add(new Prefix("Sharp", 1.5f, 1.5f));
        prefix.Add(new Prefix("Unholy", 1.75f, 1.75f));
        prefix.Add(new Prefix("Demonic", 2f, 2f));
        prefix.Add(new Prefix("Godlike", 2.25f, 2.25f));
        prefix.Add(new Prefix("Satanic", 4f, 4f));
        // swordNames
        swordNames.Add("Ginger Sword");
        swordNames.Add("Orphan Destroyer");
        swordNames.Add("Blackest Heart");
        swordNames.Add("Butter Sword");
        swordNames.Add("Cutlass of Storm");
        swordNames.Add("Shadow Striker");
        swordNames.Add("Will Breaker");
        swordNames.Add("God Devourer");
        swordNames.Add("Possesed Razor");
        swordNames.Add("Satans Sacrificer");
    }
    #endregion

}

public class Prefix : ScriptableObject
{
    public string prefixName;
    public float dmg;
    public float price;

    public Prefix(string name, float dmg, float price)
    {
        this.prefixName = name;
        this.dmg = dmg;
        this.price = price;
    }

}
