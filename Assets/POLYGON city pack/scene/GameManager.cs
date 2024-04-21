using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
       // StartCoroutine(waiter());
        text.text = "";

    }

    // Update is called once per frame
    public void ButClick()
    {
        //  text.text = "AAKDKJSGHCHYSUDUJC";
        // yield return new WaitForSeconds(4);
        SceneManager.LoadScene(1);
    }
}
//C:\MyGame\Assets\POLYGON city pack\scene\GameManager.cs
