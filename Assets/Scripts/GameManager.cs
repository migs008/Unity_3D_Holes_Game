/*  GameManager is the Singleton that saves the level complete state as well as the PlayerData
 *  after the character is rolled
 *
 *  CS 583 Fall 2021
 *  11/8/21
 *  @author Alexander Kuzdal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager Instance { get; private set; }

    public PlayerData currentPlayerData;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else {
            Destroy(gameObject);
        }
    }


    public GameObject completeLevelUI;

    public void LevelComplete() {
        completeLevelUI.SetActive(true);
    }
}