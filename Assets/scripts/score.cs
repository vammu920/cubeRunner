using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public Transform player;
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
         ScoreText .text = (player.position.z + 457.97f).ToString("0");

    }
}
