using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{
    public GameObject Win;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Jugador")
        {
            Win.SetActive(true);
        }
    }
}
