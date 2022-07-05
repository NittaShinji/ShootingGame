using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject gameOverText;

    private Vector3 respawnPoint;
    //�v���C���[�p�̗̑͗p�ϐ�
    public int playerHp;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
        //�������ɑ̗͂��w�肵�Ă���
        playerHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
            Debug.Log("�Q�[���I�[�o�[!");
            gameOverText.SetActive(true);
        }
    }
    public void Damage()
    {
        //player�̗̑͂�1���炷
        playerHp = playerHp - 1;
        //���݂̗̑͂�console�r���[�ɕ\������
        Debug.Log(playerHp);
    }
}
