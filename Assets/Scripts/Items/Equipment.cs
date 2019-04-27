using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;
    public Rarity rarity;
    public int armorModifier;
    public int damageModifier;

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }
}

[CreateAssetMenu(fileName = "New Rarity", menuName = "Inventory/Rarity")]
public class Rarity : ScriptableObject
{

    public string rarityTitle;
    public float dropChance;
    public Color color;
    public Sprite ring;

}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet }
