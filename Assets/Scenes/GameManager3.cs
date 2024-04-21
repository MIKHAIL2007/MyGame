using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager3 : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider layout;
    void Start()
    {
        layout.value = 0;
    }

    // Update is called once per frame
    public void Slide()
    {
        if(layout.value == 1)
        {
            layout.gameObject.SetActive(false);
        }
    }
}
