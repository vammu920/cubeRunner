using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(Random.Range(20, 50), 20, 20);   
    }
}
