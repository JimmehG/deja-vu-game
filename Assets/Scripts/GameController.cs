using UnityEngine;
using System.Collections;

public static class GameController //: MonoBehaviour
{
    /*public static GameController instance;

    void Awake()
    {
        if (instance != null){
            Destroy(instance);
        }
        else {
            instance = this;
        }

        DontDestroyOnLoad(this);
    }*/

    public static bool open(int DoorID)
    {
        return true;
        //check if door has been opened (dictionary?)
    }
}
