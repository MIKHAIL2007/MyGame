using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    public GameObject layout;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ButClick()
    {
       text.text = "";
        layout.gameObject.SetActive(false);
    }
}
