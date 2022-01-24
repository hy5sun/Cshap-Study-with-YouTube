using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Update()
    {
        if(Input.anyKeyDown) 
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..." 
                + Input.GetAxis("Horizontal"); // 수평, 수직 버튼을 입력 받으면 float로 반환
        }

        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..." 
                + Input.GetAxisRaw("Horizontal"); //왼오만 신경쓰는 것
            // 왼쪽으로 가면 -1, 가만히 있으면 0, 오른쪽으로 가면 1
        }

        if (Input.GetButton("Vertical")){
            Debug.Log("종 이동 중..." 
                + Input.GetAxisRaw("Vertical");
        }
}
