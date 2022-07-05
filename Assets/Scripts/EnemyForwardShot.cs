using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForwardShot : MonoBehaviour
{
    //�e�𔭎˂��n�߂�z�l
    public float beginShotLine = 20;

    //�v���C���[
    private GameObject player;

    //�e�̃Q�[���I�u�W�F�N�g������
    public GameObject bullet;

    //�ł��o���Ԋu�����߂�
    public float time = 1;

    //�ŏ��ɑł��o���܂ł̎��Ԃ����߂�
    public float delayTime = 1;

    //���݂̃^�C�}�[����
    float nowTime = 0;


    // Start is called before the first frame update
    //�X�^�[�g�֐�
    void Start()
    {
        //�^�C�}�[��������
        nowTime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        //�����v���C���[�̏�񂪓����ĂȂ�������
        if(player == null)
        {
            //"Player"�Ƃ����^�O�������Ă���Q�[���I�u�W�F�N�g���擾����
            player = GameObject.FindGameObjectWithTag("Player");
        }

        //��ʓ��ɓ�������e������
        if (transform.position.z <= beginShotLine)
        {
            //�^�C�}�[�����炷(�^�C�}�[�J�E���g)
            nowTime -= Time.deltaTime;

            //�����^�C�}�[��0�ȉ��ɂȂ�����
            if (nowTime <= 0)
            {
                //�e�𐶐�
                CreateShotObject(-transform.localEulerAngles.y);

                //�^�C�}�[��������
                nowTime = time;
            }
        }

    }

    private void CreateShotObject(float axis)
    {
        //�x�N�g��
        var direction = player.transform.position - transform.position;

        //�x�N�g����y��������
        direction.y = 0;

        //�������擾����
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);

        //�e�𐶐�
        GameObject bulletClone =
        Instantiate(bullet, transform.position, Quaternion.identity);

        //EnemyBullet�̃Q�b�g�R���|�[�l���g��ϐ��Ƃ��ĕۑ�
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();

        //�e��ł��o�����I�u�W�F�N�g�̏���n��
        bulletObject.SetCharacterObject(gameObject);

        //�e��ł��o���p�x��ύX����
        bulletObject.SetForwardAxis(lookRotation * Quaternion.AngleAxis(axis,Vector3.up));

    }

    private void OnTriggerEnter(Collider other)
    {
        //�������������I�u�W�F�N�g�̃^�O��Enemy��������
        if (other.gameObject.tag == "player")
        {
            //���������I�u�W�F�N�g��Enemy�X�N���v�g��
            //�Ăяo����Damage�֐������s������
            other.GetComponent<Player>().Damage();
        }
    }

}
