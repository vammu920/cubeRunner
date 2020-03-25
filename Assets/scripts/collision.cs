using UnityEngine;

public class collision : MonoBehaviour
{
    public randomGenerate rg;
    public playerMovement moment;
   void OnCollisionEnter(Collision colli){ 
        if(colli.collider.tag == "enemy"){
            moment.enabled = false; 
            rg.enabled= false;      
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
