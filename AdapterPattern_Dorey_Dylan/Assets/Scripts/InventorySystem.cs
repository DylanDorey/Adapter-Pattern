using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/30/2024]
 * [MOCK VERSION OF AN IMPORTED ASSET PACKAGE FOR AN INVENTORY SYSTEM]
 */

public class InventorySystem
{
    /// <summary>
    /// Adds an inventory item to the cloud save version of the user's inventory
    /// </summary>
    /// <param name="item"> the inventory item being saved to the cloud version </param>
    public void AddItem(InventoryItem item)
    {
        //Debug out the item has been saved to the cloud version
        Debug.Log("Adding item to the cloud save version");
    }

    /// <summary>
    /// Removes an inventory item from the cloud save version of the user's inventory
    /// </summary>
    /// <param name="item"> the inventory item being removed from the cloud version </param>
    public void RemoveItem(InventoryItem item)
    {
        //Debug out the item has been removed from the cloud version
        Debug.Log("Removing item from the cloud save version");
    }

    /// <summary>
    /// Gets an inventory from the cloud save version of the user's inventory
    /// </summary>
    public List<InventoryItem> GetInventory()
    {
        //Debug out the inventory has been retrieved from the cloud version
        Debug.Log("Returning inventory list from cloud");

        //return the inventory list
        return new List<InventoryItem>();
    }
}
