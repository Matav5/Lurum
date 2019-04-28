using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;
    public Rarity rarity;
    public float armorModifier;
    public float damageModifier;

    public override void Use()
    {
        base.Use();
        EquipmentManager.instance.Equip(this);
        RemoveFromInventory();
    }

    public Equipment(string name, float damageModifier, float armorModifier, Rarity rarity, float price, EquipmentSlot slot)
    {
        this.name = name;
        this.damageModifier = damageModifier;
        this.armorModifier = armorModifier;
        this.rarity = rarity;
        this.price = price;
        this.equipSlot = slot;
    }
}

public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shield, Feet }