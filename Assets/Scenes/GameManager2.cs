using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int count = 0; //������� ������� �� ������� ������� ������
    public Slider slider; //������� �������� 1
    public GameObject butt; //������� ������� ������
    public Text text; //����� �� ����
   public Button button; //������ ��������
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
    public void ButClick() //������� �� ������� ������� ������
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
