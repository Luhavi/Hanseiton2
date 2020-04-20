using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UhFavorable : MonoBehaviour
{
    public static float UhFP = 0f;
    public Text UHFPTEXT;
    public Image Favor;
    public GameObject EndingButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UHFPTEXT.text = UhFP.ToString();
        Favor.fillAmount = UhFP / 100f;
        if(UhFP >= 100)
        {
            EndingButton.SetActive(true);
        }
    }
}
