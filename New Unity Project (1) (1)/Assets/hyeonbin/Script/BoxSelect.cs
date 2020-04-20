using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSelect : MonoBehaviour
{
    public GameObject[] PutTr;
    public int weight = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()
    {
        if (transform.parent == null)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
    }

    private void OnMouseDown()
    {
        if (transform.parent == null)
        {
            for (int i = 0; i < PutTr.Length; i++)
            {
                PutTr[i].GetComponent<BoxPut>().Prebox = this.gameObject;
            }
        }
    }
}
