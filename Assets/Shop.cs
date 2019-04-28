using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{

    #region Singleton

    public static Shop instance;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one istance of Shop found!");
            return;
        }
        instance = this;
    }

    #endregion

    public GameObject shopUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleShop()
    {
        shopUI.SetActive(!shopUI.activeSelf);
    }

    public void Buy()
    {

    }
}
