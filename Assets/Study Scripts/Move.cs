using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    
    void Update()
    {
        //1. MoveTowards
        transform.position = 
            Vector3.MoveTowards(transform.position, target, 2f); //(현재위치, 목표위치, 속도)
            //마지막 매개변수에 비례해서 속도 증가

        //2. SmoothDamp 부드러운 감속 이동
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f); 
        //(현재위치, 목표위치, 참조속도, 속도)
        //마지막 매개변수에 반비례해서 속도 증가

        //3. Lerp (선형 보간) : 일자로 이동
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f); //속도는 1이 최대 얘는 속도가 비례
        
        //4. SLerp (구면 선형) : 위로 둥글게 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 0.1f);
    }
}
