using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    public Item item;
    private bool wasBought;

    void OnMouseUp()
    {
        Shop.instance.whatItem(item, gameObject);
        Shop.instance.toggleShop();
    }

    void pickUp()
    {
        Debug.Log("Picking up " + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
            Destroy(gameObject);
        }
    }

}
