using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float life = 3;
    public AudioSource audioSource;
    public GameObject menu;
    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Jugador")
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            audioSource.Play();

            if (currentSceneName != "LEVEL1")
            {
                StartCoroutine(play());
            }
            // SceneManager.LoadScene("LEVEL1");
        }
    }

    IEnumerator play()
    {
        yield return new WaitForSeconds(1);
        GameObject g = Instantiate(menu);
        g.transform.SetParent(gameObject.transform.transform.parent, false);
        g.SetActive(true);
        // menu.SetActive(true);
    }
}
