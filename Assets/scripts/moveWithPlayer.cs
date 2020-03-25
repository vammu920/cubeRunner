using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWithPlayer : MonoBehaviour
{

    public Transform player;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(player.position.x, player.position.y + 20, player.position.z - 50);
        transform.position = position;
    }
}
