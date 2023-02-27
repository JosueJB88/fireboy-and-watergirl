using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menulogic : MonoBehaviour
{
    // Start is called before the first frame update
    public Button menu;
    public Button repetir;
    void Start()
    {
        menu.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("Menu");
        });
        repetir.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("LEVEL1");
        });
    }
}
