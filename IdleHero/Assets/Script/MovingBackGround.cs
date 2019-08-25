using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackGround : MonoBehaviour
{
    public GameObject xlocation;
    public float maxlocation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x > maxlocation)
        {
            this.transform.position = new Vector3(this.transform.position.x - 0.01f, this.transform.position.y, this.transform.position.z);
        }

        else
        {
            this.transform.position = new Vector3(xlocation.transform.position.x - 0.01f, this.transform.position.y, this.transform.position.z);
        }
    }
}
