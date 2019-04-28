using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Names: MonoBehaviour {
    public List<string> prefix = new List<string>();
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
        prefix.Add("Blunt");
        prefix.Add("Weak");
        prefix.Add("Old");
        prefix.Add("Normal");
        prefix.Add("Strong");
        prefix.Add("Sharp");
        prefix.Add("Unholy");
        prefix.Add("Demonic");
        prefix.Add("Godlike");
        prefix.Add("Satanist");
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
