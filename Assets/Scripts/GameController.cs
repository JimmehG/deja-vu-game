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
        LabKeycard, DoorLabEntry, Chair, ChairMoved, LabBoxUnlocked, LabPipeBroken, LabKeyCardExit, Locked
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

    private static float armDistance = 0.85f;

    private static float oneArmX = -2.7f;
    private static float oneArmY = 3f;

    private static int armX = 3;
    private static int armY = 7;

    public static void UpdateArmPos(int x, int y)
    {
        armX = x;
        armY = y;
    }

    public static float GetArmXPos()
    {
        return oneArmX + (armX * armDistance);
    }

    public static float GetArmYPos()
    {
        return oneArmY + (armY * armDistance);
    }

}
