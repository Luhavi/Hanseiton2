using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compareweight : MonoBehaviour
{
    public GameObject[] Right;
    public int RightTotal;
    public GameObject[] Left;
    public int LeftTotal;
    public float speed = 0.01f;
    public bool RightMove = false;
    public bool LeftMove = false;
    Quaternion rightRotation = Quaternion.Euler(new Vector3(10,0,0));
    Quaternion leftRotation = Quaternion.Euler(new Vector3(-10, 0, 0));
    Quaternion midRotation = Quaternion.Euler(new Vector3(00, 0, 0));
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Right.Length; i++)
        {
            RightTotal += Right[i].GetComponent<BoxPut>().sumWeight;
            LeftTotal += Left[i].GetComponent<BoxPut>().sumWeight;
        }
        if (RightTotal > LeftTotal)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, rightRotation , Time.time * speed);
        }
        else if (RightTotal < LeftTotal)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, leftRotation, Time.time * speed);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, midRotation, Time.time * speed);
        }
        RightTotal = 0;
        LeftTotal = 0;
    }
}
