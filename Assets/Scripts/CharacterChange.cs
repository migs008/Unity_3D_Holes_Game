using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterChange : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;

    void Start()
    {
        characterList = new GameObject[transform.childCount];

        // Fill array with models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        // Toggle model renderers off
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }

        // Toggle first index
        if (characterList[0])
        {
            characterList[0].SetActive(true);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Toggle off current model
            characterList[index].SetActive(false);

            index--;
            if (index < 0)
            {
                index = characterList.Length - 1;
            }

            // Toggle on new model

            characterList[index].SetActive(true);
        }

    }
}
