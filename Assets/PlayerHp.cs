using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player = GameObject.FindGameObjectWithTag("Player");

        var playerHpObject = player.GetComponent<Player>();

        //タグが同じオブジェクトをすべて取得する
        GameObject playerHpCount =
        GameObject.FindGameObjectWithTag("PlayerHp");

         GameObject playerHpCount2 =
        GameObject.FindGameObjectWithTag("PlayerHp2");

         GameObject playerHpCount3 =
        GameObject.FindGameObjectWithTag("PlayerHp3");

        if (playerHpObject.playerHp == 3){}
        else if (playerHpObject.playerHp == 2)
        {
            Destroy(playerHpCount);

            //for (int i = 0; i < playerHpCounts.Length; i++)
            //{
            //    //Destroy(playerHpCounts[0]);

            //}
        }
        else if(playerHpObject.playerHp == 1)
        {
            Destroy(playerHpCount);
            Destroy(playerHpCount2);
            //for (int i = 0; i < playerHpCounts.Length; i++)
            //{
            //    Destroy(playerHpCounts[1]);
            //}
        }
        else if(playerHpObject.playerHp == 0)
        {
            Destroy(playerHpCount);
            Destroy(playerHpCount2);
            Destroy(playerHpCount3);
            //Destroy(playerHpCounts[2]);
        }

    }
}
