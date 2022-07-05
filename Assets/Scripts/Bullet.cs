using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //弾の生存時間
    int bulletTime = 600;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //弾のワールド座標取得
        Vector3 pos = transform.position;

        //弾の生存時間を減らす
        bulletTime--;

        //上にまっすぐ飛ぶ
        pos.z += 0.25f;

        //弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        //一定距離飛んだら消滅する
        if (pos.z >= 20)
        {
            Destroy(this.gameObject);
        }

        //弾の生存時間がなくなったら消滅させる
        if (bulletTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //もし当たったオブジェクトのタグがEnemyだったら
        if (other.gameObject.tag == "Enemy")
        {
            //当たったオブジェクトのEnemyスクリプトを
            //呼び出してDamage関数を実行させる
            other.GetComponent<Enemy>().Damage();
        }
        else if (other.gameObject.tag == "Boss")
        {
            //当たったオブジェクトのEnemyスクリプトを
            //呼び出してDamage関数を実行させる
            other.GetComponent<Boss>().Damage();
        }
    }
}
