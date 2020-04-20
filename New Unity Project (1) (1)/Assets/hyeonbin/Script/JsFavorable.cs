using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsFavorable : MonoBehaviour
{
    public static float JSFP = 0f;
    public Image Favor;
    public Text JSFPTEXT;
    public GameObject EndingButton;
    public GameObject Ending2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Favor.fillAmount = JSFP / 100f;
        JSFPTEXT.text = JSFP.ToString();
        if(JSFP >= 100 && UhFavorable.UhFP >= 100)
        {
            Ending2.SetActive(true);
        }
        if (JSFP >= 100)
        {
            EndingButton.SetActive(true);
        }
    }
}
