/*  EndLevelTrigger checks when the player reaches the end of the level and activiates a end level panel.
 *  after 4 seconds, the next level loads.
 *
 *  CS 583 Fall 2021
 *  12/3/21
 *  @author Alexander Kuzdal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTrigger : MonoBehaviour {

    // public GameManager gameManager;
    public GameObject completeLevelUI;

    void OnTriggerEnter() {
        completeLevelUI.SetActive(true);
        Invoke("loadNextScene", 4);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void loadNextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
