using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject clearText;
    public GameObject titleButton;

   

    //boss�̗̑͗p�ϐ�
    private int bossHp;

    // Start is called before the first frame update
    void Start()
    {
        //�������ɑ̗͂��w�肵�Ă���
        bossHp = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //�����̗͂�0�ȉ��ɂȂ�����
        if (bossHp <= 0)
        {
            //�����ŏ�����
            Destroy(this.gameObject);
            Debug.Log("�N���A!");

            clearText.SetActive(true);
            titleButton.SetActive(true);
            //audioSource.Play();
        }
    }

    public void Damage()
    {
        //boss�̗̑͂�1���炷
        bossHp = bossHp - 1;
        //���݂̗̑͂�console�r���[�ɕ\������
        Debug.Log(bossHp);
    }
}
