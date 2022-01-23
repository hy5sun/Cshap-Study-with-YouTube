using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    //원래 int id; 앞에는 private이 생략되어 있음. 그건 외부 클래스에 비공개로 설정하는 접근자.
    //근데 공개하려면 public을 사용하면 됨! 함수도 마찬가지.
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk(){
        return "대화를 걸었습니다.";
    }

    public string HasWeapon(){
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }
}
