/*  PlayerColor checks the selected player color from the CC and sets it to the color based on user
 *  choice. If none was selected, the character color will be set to red.
 *
 *  CS 583 Fall 2021
 *  12/1/21
 *  @author Alexander Kuzdal
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour {

    private GameManager gameManager;
    [SerializeField] private Material playerMaterial;


    void Start() {
        gameManager = GameManager.Instance;

        string selectedColor = GameManager.Instance.currentPlayerData.Color;

        // playerMaterial = GetComponent<Renderer>().material;

        Color purpleColor = new Color(128/255f, 0, 128/255f);
        Color orangeColor = new Color(255/255f, 165/255f, 0);

        if (selectedColor == "Red") {
            playerMaterial.color = Color.red;
        }
        else if (selectedColor == "Orange") {
            playerMaterial.color = orangeColor;
        }
        else if (selectedColor == "Yellow") {
            playerMaterial.color = Color.yellow;
        }
        else if (selectedColor == "Green") {
            playerMaterial.color = Color.green;
        }
        else if (selectedColor == "Blue") {
            playerMaterial.color = Color.blue;
        }
        else if (selectedColor == "Purple") {
            playerMaterial.color = purpleColor;
        }
        else {
            playerMaterial.color = Color.red;
        }
    }
}
