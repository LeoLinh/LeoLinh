using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GreenBall : BaseBall
{

    public GameObject smallBall;
    // Start is called before the first frame update
    public override void preset()
    {
        base.preset();
        hp = 3;
    }

    public override void Die()
    {
        Instantiate(smallBall,gameObject.transform.position,Quaternion.identity);

        base.Die();// green ball destroy
    }

    public override void OnTriggerEnter2D(Collider2D collision)
    {
    }
}
