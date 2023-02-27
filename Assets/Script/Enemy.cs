using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource; public GameObject menu;
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
        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "LEVEL1")
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
                audioSource.Play();
                StartCoroutine(reset());
            }
        }

        if (currentSceneName == "LEVEL2")
        {
            if (other.gameObject.name == "Jugador")
            {
                Debug.Log("user dead");
                audioSource.Play();
                StartCoroutine(reset());
            }
        }

    }

    IEnumerator reset()
    {
        // yield return new WaitForSeconds(3);
        yield return new WaitForSeconds(1);
        menu.SetActive(true);
    }
}
