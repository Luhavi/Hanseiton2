using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPut : MonoBehaviour
{
    public GameObject Prebox;
    public GameObject Box;
    public int weightMultiple;
    public int sumWeight;
    public int revise;

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
        if (Box == null)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    private void OnMouseExit()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
    }

    private void OnMouseDown()
    {
        if (Prebox != null && Box == null&& Prebox.transform.parent == null)
        {
            Vector3 preTr = gameObject.transform.position;
            preTr.y += 1.5f;
            preTr.z -= revise;
            Prebox.transform.parent = transform;
            Prebox.transform.position = preTr;
            Box = Prebox;
            sumWeight = Box.GetComponent<BoxSelect>().weight * weightMultiple;
        }
        Prebox = null;
    }
}
