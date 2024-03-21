using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;             //텍스트 UI
    public int Count = 0;                  //마우스 클릭 카운터
    public int Power = 100;            //물리 힘 수치
    public Rigidbody m_Rigidbody;        //오브젝트의 강체

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽 입력이 되었을 때 조건
        {
            Count += 1;
            TextUI.text = Count.ToString();
            Power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * Power);
        }

        if (gameObject.transform.position.y >= 2 || gameObject.transform.position.y <= -2)
        {
            TextUI.text = "실패";
            Count = 0;
        }
    }
}
