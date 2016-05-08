using UnityEngine;
using System.Collections;

public class FlagChair : MonoBehaviour {
    public GameController.Flag flagID;

    // Use this for initialization
    void Start()
    {
        if (GameController.CheckFlag(flagID))
        {
            Debug.Log("1");
            transform.position = new Vector3(2.11f, -1.67f, -1f);
            GetComponentInChildren<PolygonCollider2D>().enabled = false;
            GetComponentInParent<Animator>().enabled = false;
        }
    }
}
