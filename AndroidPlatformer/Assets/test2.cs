using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject batu;
    public float b = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   b -= 1 * Time.deltaTime;
        if(b <= 0.75){
         Instantiate(batu, this.transform.position, this.transform.rotation);
         b = 2;
         //Debug.Log("pressed");
        }
    }
}
