/*  GuideManager loads the title screen when the back button is placed.
 *
 *  CS 583 Fall 2021
 *  11/8/21
 *  @author Alexander Kuzdal
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuideManager : MonoBehaviour {

    public void GuideBackButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}