using UnityEngine;
using System.Collections;

public class CheckInventory : Action {
    public GameController.Item itemID;
    public GameController.Flag flagID;
    public GameObject[] droppings;
    //add noisemaker

	public override void Perform()
    {
        if (GameController.CheckInventory(itemID)){
            GameController.SetFlag(flagID);
            GameController.RemoveItem();
            Poop();
            Destroy(this.gameObject);
        }
        else
        {
            //play bad noise
        }

    }

    void Start()
    {
        if (GameController.CheckFlag(flagID))
        {
            Poop();
            Destroy(this.gameObject);
        }
    }

    void Poop()
    {
        foreach (GameObject dropping in droppings)
        {
            GameObject faeces = Instantiate(dropping);
            faeces.transform.parent = transform.parent;
        }
    }
}
