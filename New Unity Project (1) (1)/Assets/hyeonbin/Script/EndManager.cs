using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public GameObject[] Box;
    public GameObject SeeSaw;
    public int totalScore = 0;
    public Text JsText;
    public Text UhText;
    public GameObject canvas;
    int Notready;

    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (totalScore == 0) {
            for (int i = 0; i < Box.Length; i++)
            {
                if (Box[i].transform.parent == null)
                {
                    Notready += 1;
                }
            }
            if (Notready == 0)
            {
                for (int i = 0; i < SeeSaw.GetComponent<Compareweight>().Right.Length; i++)
                {
                    SeeSaw.GetComponent<Compareweight>().RightTotal += SeeSaw.GetComponent<Compareweight>().Right[i].GetComponent<BoxPut>().sumWeight;
                    SeeSaw.GetComponent<Compareweight>().LeftTotal += SeeSaw.GetComponent<Compareweight>().Left[i].GetComponent<BoxPut>().sumWeight;
                }
                if (SeeSaw.GetComponent<Compareweight>().RightTotal < SeeSaw.GetComponent<Compareweight>().LeftTotal)
                {
                    if (JsFavorable.JSFP < 100 && UhFavorable.UhFP < 100)
                    {
                        totalScore = SeeSaw.GetComponent<Compareweight>().LeftTotal - SeeSaw.GetComponent<Compareweight>().RightTotal;
                        JsFavorable.JSFP += totalScore / 2;
                        JsText.text = "+ " + totalScore / 2;
                        UhFavorable.UhFP -= totalScore / 2;
                        UhText.text = "- " + totalScore / 2;
                    }
                    else
                    {
                        JsText.text = "+ 00";
                        UhText.text = "+ 00";
                    }

                }
                else if (SeeSaw.GetComponent<Compareweight>().RightTotal > SeeSaw.GetComponent<Compareweight>().LeftTotal)
                {
                    if (JsFavorable.JSFP < 100 && UhFavorable.UhFP < 100)
                    {
                        totalScore = SeeSaw.GetComponent<Compareweight>().RightTotal - SeeSaw.GetComponent<Compareweight>().LeftTotal;
                        JsFavorable.JSFP -= totalScore / 2;
                        JsText.text = "- " + totalScore / 2;
                        UhFavorable.UhFP += totalScore / 2;
                        UhText.text = "+ " + totalScore / 2;
                    }
                    else
                    {
                        JsText.text = "+ 00";
                        UhText.text = "+ 00";
                    }
                }
                else
                {
                    if (JsFavorable.JSFP < 100 && UhFavorable.UhFP < 100)
                    {
                        totalScore = (SeeSaw.GetComponent<Compareweight>().RightTotal + SeeSaw.GetComponent<Compareweight>().LeftTotal) / 4;
                        JsFavorable.JSFP += totalScore / 2;
                        JsText.text = "+ " + totalScore / 2;
                        UhFavorable.UhFP += totalScore / 2;
                        UhText.text = "+ " + totalScore / 2;
                    }
                    else
                    {
                        JsText.text = "+ 00";
                        UhText.text = "+ 00";
                    }
                }
                canvas.SetActive(true);
                Debug.Log("gameOver" + totalScore);

            }
            Notready = 0;
        }
    }
}
