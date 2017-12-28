using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_object : MonoBehaviour
{
    //public Collision destroyed_obj;
    //public GameObject destroyed_object;
    
    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "destroyed")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            //弾丸と目標オブジェクトのタグを同一にすると動作がおかしくなる
        }
        else
        {
            //それ以外の処理
        }
    }

}

//たぶん、Destroyする順番がある。必ずサイト以上のルールがある
//collisionのgameObjectはthisとは別のObject