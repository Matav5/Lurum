using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    public Image ring;
    public Button removeButton;

    Equipment itm;
    Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;

        icon.sprite = item.icon;
        icon.enabled = true;
        removeButton.interactable = true;

        itm = (Equipment)item;

        if (itm.rarity != null)
        {
            ring.sprite = itm.rarity.ring;
            ring.enabled = true;
        }

    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
        itm = null;
        ring.sprite = null;
        ring.enabled = false;
        
    }

    public void OnRemoveButton ()
    {
        Inventory.instance.Remove(item);
    }

    public void UseItem ()
    {
        if(item != null)
        {
            item.Use();
        }
    }
}
