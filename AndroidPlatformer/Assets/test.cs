using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.localRotation = Quaternion.Euler(0f, 0f, 90f);
        Destroy(this.gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(new Vector2(10f, 0f) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Atas")
        {
            Destroy(this.gameObject);
        }
    }

}