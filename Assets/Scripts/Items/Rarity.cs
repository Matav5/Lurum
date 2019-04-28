using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Rarity", menuName = "Inventory/Rarity")]
public class Rarity : ScriptableObject
{

    public string rarityTitle;
    public float dropChance;
    public Color color;
    public Sprite ring;
    public float price;
    public float damageModifier;
    public Sprite image;
}
