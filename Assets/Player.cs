using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameOverText;

    private Vector3 respawnPoint;
    //プレイヤー用の体力用変数
    public int playerHp;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
        //生成時に体力を指定しておく
        playerHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHp <= 0)
        {
            //自分で消える
            Destroy(this.gameObject);
            Debug.Log("ゲームオーバー!");
            gameOverText.SetActive(true);
        }
    }
    public void Damage()
    {
        //playerの体力を1減らす
        playerHp = playerHp - 1;
        //現在の体力をconsoleビューに表示する
        Debug.Log(playerHp);
    }
}
