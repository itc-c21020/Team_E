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

        //コンポーネントの習得
        controller = GetComponent<CharacterController>();

        
    }

    // Update is called once per frame
    void Update()
    {

        //回転
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        //キャラクターの回転のローカル空間での方向
        Vector3 forward = transform.transform.forward;

        float curSpeed = speed * Input.GetAxis("Vertical");

        //SinmpleMove関数で移動させる
        controller.SimpleMove(forward * curSpeed);
    }
}
