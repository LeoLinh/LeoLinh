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
            Debug.Log("Sinh thêm đạn");
            Instantiate(ballPrefab, new Vector3(UnityEngine.Random.Range(2f, -2f), 5,  0), quaternion.identity);
            countdown = timeDuration;
        }
    }
}
