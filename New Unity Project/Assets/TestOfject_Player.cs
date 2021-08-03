using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestOfject_Player : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;

    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {

        //�R���|�[�l���g�̏K��
        controller = GetComponent<CharacterController>();

        
    }

    // Update is called once per frame
    void Update()
    {

        //��]
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        //�L�����N�^�[�̉�]�̃��[�J����Ԃł̕���
        Vector3 forward = transform.transform.forward;

        float curSpeed = speed * Input.GetAxis("Vertical");

        //SinmpleMove�֐��ňړ�������
        controller.SimpleMove(forward * curSpeed);
    }
}
