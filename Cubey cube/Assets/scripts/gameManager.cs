///using System.Collections;
///using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float RestartDelay = 1f;
    public GameObject CompleteLevelUI;

    public void CompleteLevel ()
    {
        CompleteLevelUI.SetActive(true);
        
    }

    public void EndGame ()
    {
        if (GameEnded == false)
        {
            GameEnded = true;
            Debug.Log("game over");
            Invoke("Restart", RestartDelay);
        }
      
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    // Start is called before the first frame update
    ///void Start()
    ///{
        
    ///}

    // Update is called once per frame
   /// void Update()
    ///{
        
    ///}
}
