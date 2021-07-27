﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //FindObjectOfType<AudioManager>().Play("PlayerDeath");
            SceneManager.LoadScene("Victory");
            Debug.Log("Winner winner chicken dinner!");
            Destroy(gameObject);
        }
    }
}
