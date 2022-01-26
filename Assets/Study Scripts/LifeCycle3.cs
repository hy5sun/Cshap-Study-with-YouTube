using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    void Update()
    {
        Vector3 vec = new Vector3(5, 0, 0); //게임 오브젝트를 X축으로 5만큼 이동함!
        transform.Translate(vec); //벡터 값을 현재 위치에 더하는 함수
        //벡터: 방향과 그에 대한 크기 값
        //Vector2는 2차원, Vector3은 3차원

        Vector3 vect = new Vector3(
            Input.GetAxis("Horizontal") * Time.deltaTime,
            Input.GetAxis("Vertical") * Time.deltaTime, 0);
        //위아래옆으로 이동 가능 (방향키 누르면서)
        transform.Translate(vect);
    }
}

//Time.deltaTime 사용법
// Translate: 벡터에 곱하기 -> transform.Translate(Vec * Time.deltaTime);
// Vector 함수: 시간 매개변수에 곱하기 -> Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
// 서로 다른 사양의 컴퓨터라도 게임 속에서 같은 자동차를 타면 같은 속도로 달려야 함.
// 그러기 위해 필요한 게 바로  deltaTime이다.
// deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 적다.
