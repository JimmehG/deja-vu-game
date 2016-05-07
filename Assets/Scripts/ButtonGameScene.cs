using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonGameScene: MonoBehaviour {

	public void Button()
    {
        SceneManager.LoadScene("game");
    }
}
