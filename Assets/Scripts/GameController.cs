using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class GameController {
    private static Item inventory = Item.None;
    private static Dictionary<Flag, bool> Flags = new Dictionary<Flag, bool>();

    public enum Item
    {
        None, LabEntry, LabExit, Chair, LabKey
    }

    public enum Flag
    {
        LabKeycard, DoorLabEntry, Chair, LabBoxUnlocked, LabPipeBroken
    }

    public static void PickupItem(Item itemID)
    {
        inventory = itemID;
    }

    public static void SetFlag(Flag flagID)
    {
        Flags.Add(flagID, true);
    }

    public static void RemoveItem()
    {
        inventory = Item.None;
    }

    public static bool CheckInventory(Item itemID)
    {
        return inventory == itemID;
    }

    public static bool CheckFlag(Flag flagID)
    {
        if (Flags.ContainsKey(flagID))
        {
            return Flags[flagID];
        }
        return false;
    }
}
