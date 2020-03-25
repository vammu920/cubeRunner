using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomGenerate : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z % 100f > 0 && transform.position.z % 100f < 1){
            int x = Random.Range(-80, 80);
            Vector3 pos= transform.position;
            pos.x= x;
            pos.y = 10;
            pos.z +=400;
            Instantiate<GameObject>(prefab, pos, Quaternion.identity);
        }
        //
    }
}
