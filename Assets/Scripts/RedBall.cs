using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : BaseBall
{
    public override void preset()
    {
        base.preset();
        hp = 4;
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
