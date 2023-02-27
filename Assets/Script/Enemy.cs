using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Restart scene");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Debug.Log("hola");
        // Debug.Log("other " + other.gameObject.name);
        // Debug.Log("gameObject " + gameObject.name);
        if (other.gameObject.name == "bottom" && gameObject.name != "Florerroja")
        {
            Debug.Log("die");
        }
        else
        {
            Debug.Log("user dead");
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

    }
}
