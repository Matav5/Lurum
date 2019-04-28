using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public Names names;
    public List<Equipment> equipment = new List<Equipment>();

    Rarity[] rarities;
    List<Rarity> rarList = new List<Rarity>();
    GameObject[] pedestals;

    // Start is called before the first frame update
    void Start()
    {

        pedestals = GameObject.FindGameObjectsWithTag("Pedestal");

        //names = Names.instance;
        rarities = Resources.LoadAll("Rarities", typeof(Rarity)).Cast<Rarity>().ToArray();
        foreach(Rarity r in rarities)
        {
            rarList.Add(r);
        }

        genSwords();
    }


    void genSwords()
    {
        for (int i = 0; i < 5; i++)
        {
            Prefix ranPrefix = names.prefix[Random.Range(0, names.prefix.Count)];
            Debug.Log(ranPrefix.prefixName);
            string ranName = ranPrefix.prefixName + " " + names.swordNames[Random.Range(0, names.swordNames.Count)];
            float ranNum = Random.Range(0f, 1f);
            Rarity ranRar;

            if(ranNum <= 0.5)
            {
                ranRar = rarList.Find(name => name.rarityTitle == "Imp");
            }else if (ranNum <= 0.75)
            {
                ranRar = rarList.Find(name => name.rarityTitle == "Goblin");
            }else if (ranNum <= 0.9)
            {
                ranRar = rarList.Find(name => name.rarityTitle == "Demon");
            }else if (ranNum <= 0.975)
            {
                ranRar = rarList.Find(name => name.rarityTitle == "Satan");
            }else
            {
                ranRar = rarList.Find(name => name.rarityTitle == "Antichrist");
            }

            float ranDmg = ranRar.damageModifier * ranPrefix.dmg;

            equipment.Add(new Equipment(ranName, ranDmg, 0, ranRar, ranRar.price * ranPrefix.price, EquipmentSlot.Weapon));

            equipment[i].icon = equipment[i].rarity.image;
            pedestals[i].GetComponent<OnClick>().item = equipment[i];
            pedestals[i].GetComponent<SpriteRenderer>().sprite = equipment[i].rarity.image;

        }
    }
}
