using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public static int Round = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Loby()
    {
        SceneManager.LoadScene("Loby");

    }
    public void Ending()
    {
        SceneManager.LoadScene("Ending");
    }
    public void Ending1()
    {
        SceneManager.LoadScene("Ending1");
    }
    public void Ending2()
    {
        SceneManager.LoadScene("Ending2");
    }

    public void gameStart()
    {
        if(Round == 1)
        {
            SceneManager.LoadScene("1");
            Round++;
        }
        else if(Round == 2)
        {
            SceneManager.LoadScene("2");
            Round++;
        }
        else if (Round == 3)
        {
            SceneManager.LoadScene("3");
            Round++;
        }
        else if (Round == 4)
        {
            SceneManager.LoadScene("4");
            Round++;
        }
        else if (Round == 5)
        {
            SceneManager.LoadScene("5");
            Round++;
        }
        else if (Round == 6)
        {
            SceneManager.LoadScene("6");
            Round++;
        }
        else if (Round == 7)
        {
            SceneManager.LoadScene("7");
            Round++;
        }
        else if (Round == 8)
        {
            SceneManager.LoadScene("8");
            Round++;
        }
        else if (Round == 9)
        {
            SceneManager.LoadScene("9");
            Round++;
        }
    }
}
