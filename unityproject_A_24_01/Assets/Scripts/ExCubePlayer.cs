using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExCubePlayer : MonoBehaviour
{
    public Text TextUI = null;             //텍스트 UI
    public int Count = 0;                  //마우스 클릭 카운터
    public int Power = 100;            //물리 힘 수치

    public int Point = 0;
    public float checkTime = 0.0f;

    public Rigidbody m_Rigidbody;        //오브젝트의 강체

    // Update is called once per frame
    void Update()
    {

        checkTime += Time.deltaTime;
        if (checkTime >= 1.0f)
        {
            Point += 1;
            checkTime = 0.0f;
        }


        if(Input.GetKeyDown(KeyCode.Space))
        {
            Power = Random.Range(100, 200);
            m_Rigidbody.AddForce(transform.up * Power);
        }

        TextUI.text = Point.ToString();

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


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        Point = 0;
        gameObject.transform.position = Vector3.zero;


    }
    

}   
