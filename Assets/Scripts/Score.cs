using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    private int score = 0;

    public Text scoreText;

    public DeathMenu deathMenu;

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Win")
            score += 20;

    }

    public void OnDeath()
    {
        deathMenu.ToggleEndMenu(score);
    }
}
