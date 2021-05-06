using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lempar : MonoBehaviour
{
    public GameObject bola; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.y == 0.306){
            GameObject a = Instantiate(bola) as GameObject;
            a.transform.position = new Vector3(a.transform.position.x,4, a.transform.position.z);
        }
    }
}
