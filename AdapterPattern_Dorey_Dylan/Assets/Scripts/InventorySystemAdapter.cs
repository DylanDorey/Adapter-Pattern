using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/30/2024]
 * [Inventory system adapter that also saves locally rather than just to the cloud]
 */

//UTILIZES THE ORIGINAL INVENTORY SYSTEM BUT EXPANDS UPON IT BY SAVING LOCALLY TOO UTILIZING THE ADAPTER PATTREN
//THIS METHOD USES THE ORIGINAL ARCHITECTURE OF THE INVENTORY SYSTEM BUT WRAPS IT WITH A UNIQUE INVENTORY SYSTEM ADAPTER
public class InventorySystemAdapter : InventorySystem, IInventorySystem
{
    //reference to the user's retrieved cloud inventory
    private List<InventoryItem> cloudInventory;

    /// <summary>
    /// Syncs the cloud version and local version of the inventories
    /// </summary>
    public void SyncInventories()
    {
        //retrieve the cloud version of the user's inventory and initialize cloudInventory
        var cloudInventory = GetInventory();

        //Debug out the inventories are synchronizing
        Debug.Log("Synchronizing Local Drive and Cloud Inventories");
    }

    /// <summary>
    /// Adds an inventory item to a specific save location
    /// </summary>
    /// <param name="item"> the inventory item being saved to a specific save location </param>
    /// <param name="location"> the desired save location </param>
    public void AddItem(InventoryItem item, SaveLocation location)
    {
        //if the desired save location is the cloud version
        if(location == SaveLocation.Cloud)
        {
            //add the item to the cloud version
            AddItem(item);
        }

        //if the desired save location is the local version
        if (location == SaveLocation.Local)
        {
            //Debug out adding the item to the local version
            Debug.Log("Adding Item to local version");
        }

        //if the desired save location is both versions
        if (location == SaveLocation.Both)
        {
            //Debug out adding the item to both versions
            Debug.Log("Adding item to local and cloud versions");
        }
    }

    /// <summary>
    /// Removes an inventory item from a specific save location
    /// </summary>
    /// <param name="item"> the inventory item being removed from a specific save location </param>
    /// <param name="location"> the desired save location </param>
    public void RemoveItem(InventoryItem item, SaveLocation location)
    {
        //Debug out removing the item from the desired save location
        Debug.Log("Remove item from local/cloud/both");
    }

    /// <summary>
    /// Gets an inventory from a specific save location
    /// </summary>
    /// <param name="location"> the desired save location to retrieve from </param>
    /// <returns> the inventory that was retrieved </returns>
    public List<InventoryItem> GetInventory(SaveLocation location)
    {
        //Debug out that the inventory is being retrieved from the desired save location
        Debug.Log("Get inventory from local/cloud/both");

        //return the inventory retrieved
        return new List<InventoryItem>();
    }
}
