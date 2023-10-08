using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BallGenerater : MonoBehaviour
{
    public GameObject ballPrefab;
    private float countdown;
    public float timeDuration;

    private void Awake()
    {
        countdown = timeDuration;
    }
    void Update()
    {
        countdown -= Time.deltaTime; // moi frame countdown -= 1/fps
        if (countdown <= 0)
        {
            GameObject ball = Instantiate(ballPrefab, new Vector3(UnityEngine.Random.Range(2f, -2f), 5,  0), quaternion.identity);
            GameManager.Instance.balls.Add(ball);
            countdown = timeDuration;
            StartCoroutine(DestroyBallAfterDelay(ball, 8f)); // Huỷ bóng sau 5 giây
            countdown = timeDuration;
        }
    }
    IEnumerator DestroyBallAfterDelay(GameObject ball, float delay)
    {
        yield return new WaitForSeconds(delay);
        if (GameManager.Instance.balls.Contains(ball)) // Kiểm tra xem bóng có còn trong danh sách không trước khi huỷ
        {
            GameManager.Instance.balls.Remove(ball);
            Destroy(ball);
        }
    }   
}
