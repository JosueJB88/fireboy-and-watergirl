using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fondoanimacion : MonoBehaviour
{
    // Start is called before the first frame update
    private bool beingHandled = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (beingHandled)
        {

            StartCoroutine(Animation());
        }
        else {
            StartCoroutine(Animation2());
        }
        // beingHandled = false;
        // Debug.Log("end" + DateTime.Now.ToString());
    }

    IEnumerator Animation()
    {
        beingHandled = true;
        string datetime = DateTime.Now.ToString();
        Debug.Log("start" + datetime);
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        yield return new WaitForSeconds(1);

    }

    IEnumerator Animation2()
    {
        beingHandled = false;
        string datetime = DateTime.Now.ToString();
        Debug.Log("start" + datetime);
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
