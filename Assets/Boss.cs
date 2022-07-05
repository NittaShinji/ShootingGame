using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject clearText;
    public GameObject titleButton;

   

    //bossの体力用変数
    private int bossHp;

    // Start is called before the first frame update
    void Start()
    {
        //生成時に体力を指定しておく
        bossHp = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //もし体力が0以下になったら
        if (bossHp <= 0)
        {
            //自分で消える
            Destroy(this.gameObject);
            Debug.Log("クリア!");

            clearText.SetActive(true);
            titleButton.SetActive(true);
            //audioSource.Play();
        }
    }

    public void Damage()
    {
        //bossの体力を1減らす
        bossHp = bossHp - 1;
        //現在の体力をconsoleビューに表示する
        Debug.Log(bossHp);
    }
}
