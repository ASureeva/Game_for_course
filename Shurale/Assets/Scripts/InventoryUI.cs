using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{

    public Sprite defolt;

    [SerializeField] private List<Image> icons = new List<Image>();
    [SerializeField] private List<int> index = new List<int>();

    public Inventory inventory;



    public void UpdateUI(Inventory inventory)
    {
        for (int i = 0; i < inventory.GetSize() && i < icons.Count; i++){
            icons[i].sprite = inventory.GetItem(i).icon;
            index[i] = inventory.GetItem(i).id;
            Debug.Log(index[i]);

        }
    }

    public void UpdateDelUI(Inventory inventory){
        Debug.Log(inventory.item_del + " это та самая переменная она есть, смотри:::::");
        var indexOfIntegerValue = index.IndexOf(inventory.item_del);
        Debug.Log(indexOfIntegerValue);
        icons[indexOfIntegerValue].sprite = defolt;
        index[indexOfIntegerValue] = -1;
        inventory.item_del = -1;
    }
}