﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public static class GameController {
    private static Item inventory = Item.None;
    private static Dictionary<Flag, bool> Flags = new Dictionary<Flag, bool>();
    private static GameObject[] cursorItems =
    {
        Resources.Load("LabEntry") as GameObject,
        Resources.Load("LabKey") as GameObject,
        Resources.Load("LabExit") as GameObject
    };


    public enum Item
    {
        None, LabEntry, LabExit, Chair, LabKey
    }

    public enum Flag
    {
        LabKeycard, DoorLabEntry, Chair, ChairMoved, LabBoxUnlocked, LabPipeBroken, LabKeyCardExit,
		RefineryBrokenUnlocked,
		Locked
    }

    public static void PickupItem(Item itemID)
    {
        inventory = itemID;
        switch (itemID)
        {
            case Item.LabEntry:
                GameObject.Instantiate(cursorItems[0]);
                break;
            case Item.LabKey:
                GameObject.Instantiate(cursorItems[1]);
                break;
            case Item.LabExit:
                GameObject.Instantiate(cursorItems[2]);
                break;
            default:
                break;
        }
    }

    public static void SetFlag(Flag flagID)
    {
        Flags.Add(flagID, true);
    }

    public static void RemoveItem()
    {
        inventory = Item.None;
        GameObject.Destroy(GameObject.FindGameObjectWithTag("CursorItem"));
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
