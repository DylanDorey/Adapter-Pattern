using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/30/2024]
 * [Inventory system interface that implements a sync, add, remove, and retrieve method for inventories/items from a save location]
 */

public interface IInventorySystem
{
    void SyncInventories();
    void AddItem(InventoryItem item, SaveLocation location);
    void RemoveItem(InventoryItem item, SaveLocation location);
    List<InventoryItem> GetInventory(SaveLocation location);
}
