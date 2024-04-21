using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int count = 0; //счетчик нажатий на большую красную кнопку
    public Slider slider; //слайдер концовки 1
    public GameObject butt; //большая красная кнопка
    public Text text; //текст на окне
   public Button button; //кнопка рестарта
    void Start()
    {
        count = 0;
        if (count % 2 == 0)
        {
            slider.gameObject.SetActive(false);
           button.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    public void ButClick() //нажатие на большую красную кнопку
    {
        if(slider.value == 1)
        {
            text.text = "ENDING 1";
          button.gameObject.SetActive(true);
        }
        count++;
        if(count > 0)
        {
            slider.gameObject.SetActive(true);
        }
    }
    public void ButRestartClick()
    {
        SceneManager.LoadScene(1);
    }
}
