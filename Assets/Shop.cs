using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject player;
    public Text mainText;
    public Button buyButton;

    private Health health;
    private Item item;
    private GameObject gItem;
   


    // Start is called before the first frame update
    void Start()
    {
        health = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleShop()
    {
        shopUI.SetActive(!shopUI.activeSelf);
        mainText.text = "Do you want to buy the " + item.name + " ? It costs " + item.price + " lifies";
        buyButton.enabled = true;
    }

    public void Buy()
    {
        if(item.price > health.getHealth())
        {
            mainText.text = "Not enough life";
            return;
        }
        health.Bought(item.price);
        mainText.text = "Item bought!";
        buyButton.enabled = false;
        pickUp();
    }

    void pickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gItem);
        }
    }

    public void whatItem(Item buyItem, GameObject gOitem)
    {
        item = buyItem;
        gItem = gOitem;
    }
}
