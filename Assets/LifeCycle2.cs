using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    void Awake() //게임 오브젝트 생성할 때, 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다. ");
    }

    void OnEnable() //게임 오브젝트가 활성화 되었을 때(스크립트를 다시 적용) / 최초 1회 실행이 아니라 상시로 됨
    {
         Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() //업데이트 시작 직전, 최초 실행
    {
         Debug.Log("사냥 장비를 챙겼습니다. ");
    }

    void FixedUpdate() //물리 연산 업데이트 / CPU를 많이 사용 / 1초에 약 50회 호출이 됨
    {
        Debug.Log("이동!");
    }

    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() //모든 업데이트가 끝난 후 마지막으로 호출
    {
        // 캐릭터를 따라가는 카메라나 로직의 후처리.
        Debug.Log("경험치 획득.");
    }

    void OnDisable() //게임 오브젝트가 비활성화 됐을 때 (스크립트 적용 해제할 때)
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy() //게임 오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 해체하였습니다. ");
    }
}

