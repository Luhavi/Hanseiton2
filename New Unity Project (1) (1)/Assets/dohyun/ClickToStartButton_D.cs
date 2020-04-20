using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickToStartButton_D : MonoBehaviour
{
    // Start is called before the first frame update


    public bool ButtonOn;

    public GameObject First;
    public GameObject Second;
    public GameObject Third;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;

    float Timer = 0;
    public float[] Delay = { 0.5f,1.7f,0.2f,0.5f,1.7f };

    // Update is called once per frame

    private void Start()
    {
        for (int i = 1; i < 5; i++)
            Delay[i] += Delay[i - 1];
    }
    void Update()
    {
        if (ButtonOn)
        {
            Timer += Time.deltaTime;
            if (Timer >= Delay[4])
            {
                SceneManager.LoadScene("Loby");
            }
            else if (Timer >= Delay[3])
            {
                Four.SetActive(true);
            }
            else if (Timer >= Delay[2])
            {
                Third.SetActive(true);
            }
            else if(Timer >= Delay[1])
            {
                Second.SetActive(false);
                First.SetActive(false);
            }
            else if (Timer >= Delay[0])
            {
                Second.SetActive(true);
            }
            else if (Timer >= 0)
            {
                First.SetActive(true);
                Five.SetActive(false);
                Six.SetActive(false);
                this.gameObject.transform.localScale = new Vector3(0, 0, 0);
            }
        }
    }

    public void ButtonStart()
    {
        ButtonOn = true;
    }
}
