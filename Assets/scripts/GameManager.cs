using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{   
    bool gameHasEnded = false;
   public void EndGame(){ 
        if(gameHasEnded == false){
            print("gameover");
            gameHasEnded = true;
            Invoke("restart",2f);
        }
    }
    void restart(){ 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
