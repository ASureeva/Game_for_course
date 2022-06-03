using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]

public class InventorySlot {
    public Item item;
    public int amount;

    public InventorySlot(Item item, int amount = 1){
        this.item = item;
        this.amount = amount;
    }
}


public class Inventory : MonoBehaviour
{
    [SerializeField] private List<InventorySlot> items = new List<InventorySlot>();
    [SerializeField] private int size = 4;

    [SerializeField] public UnityEvent OnInventoryChanged;
    [SerializeField] public UnityEvent OnInventoryDelete;
    public int item_del = -1;

    public bool AddItems(Item item, int amount = 1){
        foreach(InventorySlot slot in items){
            if (slot.item.id == item.id){
                slot.amount += amount;
                OnInventoryChanged.Invoke();
                return true;
            }
        }  

        if (items.Count >= size) return false;
        
        InventorySlot new_slot = new InventorySlot(item, amount);
        items.Add(new_slot);

        OnInventoryChanged.Invoke();

        return true;
    }

    public bool DeleteItems(int item_id,int amount = 1){
        foreach(InventorySlot slot in items){
            if (slot.item.id == item_id){
                slot.amount -= amount;
                item_del = item_id;
                items.Remove(slot);
                OnInventoryDelete.Invoke();
                return true;
            }
        }  

        if (items.Count < 0) return false;

        return true;
    }

    public Item GetItem(int i){
        return i < items.Count ? items[i].item : null;
    }

    public int GetAmount(int i){
        return i < items.Count ? items[i].amount:0;
    }

    public int GetSize(){
        return items.Count;
    }

}
