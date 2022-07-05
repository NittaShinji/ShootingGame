using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    //敵の数を数える用の変数
    private GameObject[] enemy;

    public int playerHp;

    //パネルを登録する
    public GameObject panel;

    public Text textComponet;

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //シーンに存在しているplayerタグを持っているオブジェクト
        //player = GameObject.FindGameObjectWithTag("Player");

        //シーンに存在しているEnemyタグを持っているオブジェクト
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //シーンに1匹もEnemyがいなくなったら
        if (enemy.Length == 0)
        {
            //パネルを表示させる
            panel.SetActive(true);
        }
    }

    public void ShowPlayerHp()
    {
        playerHp -= 1;
        Debug.Log("PlayerHp : " + playerHp.ToString());
        textComponet.text = "PlayerHp : " + playerHp.ToString();
    }
}
