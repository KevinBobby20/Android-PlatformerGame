using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake (){
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");

    if(musicObj.Length > 1){
        Destroy(this.gameObject);
    }
    DontDestroyOnLoad(this.gameObject);
    }
}
