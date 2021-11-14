/*  UICharacterCreation controls all the user options and sets them using the GameManager
 *  Singleton. The scenes are also controlled.
 *
 *  CS 583 Fall 2021
 *  10/8/21
 *  @author Alexander Kuzdal
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UICharacterCreation : MonoBehaviour {

    public InputField nameField;
    public Text nameOut;

    public Dropdown colorDropdown;
    public Text colorOut;

    public Text difficultyOut;

    public Button playButton;

    [SerializeField]
    public PlayerData playerData;


    public void CreateName() {
        playerData.Name = nameField.text;
        nameOut.text = "Name: " + nameField.text;
    }


    public void CreateColor() {
        if (colorDropdown.value == 1) {
            playerData.Color = "Red";
            colorOut.text = "Color: Red";
        }
        else if (colorDropdown.value == 2) {
            playerData.Color = "Orange";
            colorOut.text = "Color: Orange";
        }
        else if (colorDropdown.value == 3) {
            playerData.Color = "Yellow";
            colorOut.text = "Color: Yellow";
        }
        else if (colorDropdown.value == 4) {
            playerData.Color = "Green";
            colorOut.text = "Color: Green";
        }
        else if (colorDropdown.value == 5) {
            playerData.Color = "Blue";
            colorOut.text = "Color: Blue";
        }
        else if (colorDropdown.value == 6) {
            playerData.Color = "Purple";
            colorOut.text = "Color: Purple";
        }
    }


    public void EasyDifficulty() {
        playerData.Difficulty = "Easy";
        difficultyOut.text = "Difficulty: Easy";
        playButton.interactable = true;
    }

    public void MediumDifficulty() {
        playerData.Difficulty = "Medium";
        difficultyOut.text = "Difficulty: Medium";
        playButton.interactable = true;
    }

    public void HardDifficulty() {
        playerData.Difficulty = "Hard";
        difficultyOut.text = "Difficulty: Hard";
        playButton.interactable = true;
    }


    public void PlayButton() {
        // GameManager.Instance.currentPlayerData = playerData; FIXME
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void BackButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}