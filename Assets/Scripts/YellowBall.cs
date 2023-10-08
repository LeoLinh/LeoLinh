using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBall : BaseBall
{
    public override void preset()
    {
        base.preset();
        hp = 1;
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
    }

}
