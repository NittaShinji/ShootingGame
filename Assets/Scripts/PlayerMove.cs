using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //プレイヤーのワールド座標を取得

    float moveSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = 0.02f;
        }
        else
        {
            moveSpeed = 0.1f;
        }

        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //右方向に0.01動く
            pos.x += moveSpeed;
        }
        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //右方向に0.01動く
            pos.x -= moveSpeed;
        }
        //上矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //右方向に0.01動く
            pos.z += moveSpeed;
        }
        //左矢印キーが入力されたとき
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //右方向に0.01動く
            pos.z -= moveSpeed;
        }

        transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
