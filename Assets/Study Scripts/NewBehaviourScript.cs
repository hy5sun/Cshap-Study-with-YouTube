using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int level = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");

        //1. 변수
    
        
        float strength = 15.5f;
        string playerName = "지수민";
        bool isFullLevel = false;

        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "이가은"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("생명물약 30");
        items.Add("마나물약 30");

        items.RemoveAt(0);

        //3.연산자
        int exp = 1500;
        exp -= 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        
        int mana = 25;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        //? A : B 는 true 일 때 A, false 일 때 B 출력
        
        //조건문
        if(isBadCondition && items[0] == "생명물약 30"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if(isBadCondition && items[0] == "마나물약 30"){
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        switch(monsters[1]){ //괄호 안에 변수
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default:
                Debug.Log("??? 몬스터가 출현!");
                break;
        }

        //반복문
        while(health > 0){
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다. "+ health);
            else
                Debug.Log("사망하였습니다.");

            if (health == 10){ //health가 10이 되면 자동적으로 해독제 사용
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for(int count = 0; count < 10; count++){
            Debug.Log("붕대로 치료중... " + health);
        }

        for(int index = 0; index < monsters.Length; index++){
            //배열은 .Length, 리스트는 .Count
            Debug.Log("이 지역에 있는 몬스터: " + monsters[index]);
        }

        foreach (string monster in monsters){
            Debug.Log("이 지역에 있는 몬스터: " + monster);
        }
        //foreach문은 for의 그룹형 변수 탐색 특화

        Heal();

        for (int index = 0; index < monsters.Length; index++){
            Debug.Log("용사는 "+ monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        //클래스
        Player player = new Player(); //클래스를 하나의 변수로 만들어줌 : 인스턴스화
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + " 입니다.");
    }

    //함수(메소드) int Heal(int Health) 같은 경우는 반환 값이 있음 return Health;이렇게
    void Heal(){ //void는 반환 데이터가 없는 함수 타입
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }
    //health가 Start함수 내에 있을 때는 지역변수라고 함. 함수 안에만 존재하는 변수
    //근데 이걸 Start함수 외에도 다른 곳에서 쓰고 싶다 그러면 Start함수 전에 써주면 됨.
    //그럼 그건 이제 함수 바깥에서 선언된 변수인 '전역변수'다.

    string Battle(int monsterLevel){
        string result;
        if(level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        
        return result;
    }
}
