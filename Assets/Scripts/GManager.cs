using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GManager : MonoBehaviour
{
    //�G�̐��𐔂���p�̕ϐ�
    private GameObject[] enemy;

    public int playerHp;

    //�p�l����o�^����
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
        //�V�[���ɑ��݂��Ă���player�^�O�������Ă���I�u�W�F�N�g
        //player = GameObject.FindGameObjectWithTag("Player");

        //�V�[���ɑ��݂��Ă���Enemy�^�O�������Ă���I�u�W�F�N�g
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        //�V�[����1�C��Enemy�����Ȃ��Ȃ�����
        if (enemy.Length == 0)
        {
            //�p�l����\��������
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
