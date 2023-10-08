using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet; // lưu trữ prefab đạn
    public Transform firePos; // lưu trữ nơi xuất đạn
    //public GameObject muzzle;

    public float TimeBtwFire = 0.2f; // quản lý việc bắn nhanh hay chậm
    public float bulletForce;
    private float timeBtwFire;


    void Update()
    {
        if (GameManager.Instance.isPausing)
        {
            return;
        }
        timeBtwFire -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeBtwFire < 0)
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        timeBtwFire = TimeBtwFire;
        GameObject bulletTmp = Instantiate(bullet, firePos.position, Quaternion.identity);

        Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
    }

}
