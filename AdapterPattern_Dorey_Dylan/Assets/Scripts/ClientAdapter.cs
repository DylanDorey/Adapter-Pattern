using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: [Dorey, Dylan]
 * Last Updated: [04/30/2024]
 * [The client component that allows the user to interact with the demo]
 */

public class ClientAdapter : MonoBehaviour
{
    //the inventory item being added to the save location
    public InventoryItem item;

    //the inventory system without the adapter
    private InventorySystem _inventorySystem;

    //the inventory system with the adapter
    private IInventorySystem _inventoryAdapter;

    private void Start()
    {
        //initialize both inventory systems by creating a new version of each
        _inventorySystem = new InventorySystem();
        _inventoryAdapter = new InventorySystemAdapter();
    }

    /// <summary>
    /// TESTING PURPOSES ONLY ( DO NOT USE IN PRODUCTION CODE ) EXTREMELY INEFFICIENT
    /// </summary>
    private void OnGUI()
    {
        //creat a button to add an item to the inventory without the adapter
        if (GUILayout.Button("Add Item (no adapter)"))
        {
            //if pressed, add the item to the inventory without the adapter
            _inventorySystem.AddItem(item);
        }

        //creat a button to add an item to the inventory with the adapter
        if (GUILayout.Button("Add item (with adapter)"))
        {
            //if pressed, add the item to the inventory with the adapter
            _inventoryAdapter.AddItem(item, SaveLocation.Both);
        }
    }
}
