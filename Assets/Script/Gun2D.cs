using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2D : MonoBehaviour
{
    public GameObject CanvasParent;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1000;
    float timeInterval = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeInterval += Time.deltaTime;
        if (timeInterval >= 1)
        {
            timeInterval = 0;
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.SetActive(true);
            bullet.transform.SetParent(CanvasParent.transform, false);
            // bullet.transform.position = gameObject.transform.position;
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawnPoint.up * bulletSpeed;
        }
    }
}
