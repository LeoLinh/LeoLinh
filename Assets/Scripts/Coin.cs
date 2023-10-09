using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : BaseBall
{
    public override void preset()
    {
        base.preset();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Hủy đồng xu sau khi ăn
            Destroy(gameObject);
        }
    }
}
