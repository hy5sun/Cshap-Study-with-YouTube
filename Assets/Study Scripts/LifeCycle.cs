using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        // 키보드나 마우스 입력
        if(Input.anyKeyDown) 
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if(Input.anyKey) //아무 입력을 받으면 true / 마우스 클릭도 포함됨
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        if (Input.GetKeyDown(KeyCode.Return)) //Return은 Enter와 같음
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow)) //GetKey는 키보드 버튼 입력을 받으면 true
            Debug.Log("왼쪽으로 이동 중"); //Arrow는 방향키! LeftArrow는 왼쪽 화살표

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");

        if (Input.GetMouseButtonDown(0)) //0은 마우스 왼쪽 버튼, 1은 마우스 오른쪽 버튼
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0)) //stay (마우스 누르고 있는 상태)
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");
            



        //Input Manager에서 Button 설정하기
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");



        //축 이동
        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중...");
            Input.GetAxis("Horizontal"); // 수평, 수직 버튼을 입력 받으면 float로 반환
        }

        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중...");
            Input.GetAxisRaw("Horizontal"); //왼오만 신경쓰는 것
            // 왼쪽으로 가면 -1, 가만히 있으면 0, 오른쪽으로 가면 1
        }

        if (Input.GetButton("Vertical")){
            Debug.Log("종 이동 중...");
            Input.GetAxisRaw("Vertical");
        }
    }
}