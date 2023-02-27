using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donut : MonoBehaviour
{
    float timeInterval = 0;
    public float time = 1;
    public float bulletSpeed = 100;
    public bool direction = false;
    private float horizontal;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeInterval += Time.deltaTime;
        if (timeInterval >= time)
        {
            timeInterval = 0;
            // GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.localPosition, bulletSpawnPoint.rotation);
            // bullet.SetActive(true);
            // bullet.transform.SetParent(CanvasParent.transform, false);
            // bullet.transform.position = gameObject.transform.position;
            if (direction)
            {
                // gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().transform.right * bulletSpeed;
                horizontal = 1;
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * bulletSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.x);

            }
            else
            {
                horizontal = -1;
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal * bulletSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.x);
            }
            direction = !direction;
            // Flip();
        }
    }

    private void Flip()
    {
        if (direction && horizontal < 0f || !direction && horizontal > 0f)
        {
            direction = !direction;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
