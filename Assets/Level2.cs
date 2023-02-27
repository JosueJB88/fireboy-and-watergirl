using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("LEVEL2");
    }
}