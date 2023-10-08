using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isPausing)
        {
            return;
        }
        transform.position += transform.up * moveSpeed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Lấy component EnemyController từ đối tượng Enemy
            Debug.Log(other.name);
            BaseBall enemy = other.gameObject.GetComponent<BaseBall>();

            if (enemy != null)
            {
                // Gọi hàm tiêu diệt Enemy
                enemy.CheckDie();
            }

            // Hủy đạn sau khi va chạm
            Destroy(gameObject);
        }
    }
}
