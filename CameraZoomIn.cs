using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomIn : MonoBehaviour
{
    public Camera camera; //카메라 객체
    public GameObject player;  //플레이어 객체

    public float speed = 0.5f; //바뀔 움직일 속도
    public float cameraSize = 5f;  //얼만큼 카메라를 줌인 할지

//얼마만큼 증가 감소할지 설정
    public float MaxSize = 10f;
    public float MinSize = -5f;

    void Start()
    {
        StartCoroutine("delayTime");
    }

    void Update()
    {
        
    }

    IEnumerator delayTime()
    {
        Debug.Log("기다렷!");
        yield return new WaitForSeconds(3);
        //줌인 줌아웃 최대 최소값 설정.
        if (cameraSize >= MaxSize)
            cameraSize = MaxSize;
        if (cameraSize <= MinSize)
            cameraSize = MinSize;

        //cameraSize = 5f + player.transform.position.y; //캐릭터가 점프할 때마다 카메라 줌인,줌아웃.
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, cameraSize, Time.deltaTime / speed);
        //Time.deltaTime*2 의 시간만큼 값의 변화를 준다. 
        Debug.Log("조금 갔닷!");
        yield return null;
        Debug.Log("코루틴 끝!!");
        //zoomIn();
        //Debug.Log("줌 다시 간닷!!!");
    }

    void zoomIn()
    {
        Debug.Log("간ㄷ아아ㅏ아아ㅏㅏㅏ");
        //줌인 줌아웃 최대 최소값 설정.
        if (cameraSize >= MaxSize)
            cameraSize = MaxSize;
        if (cameraSize <= MinSize)
            cameraSize = MinSize;

        //cameraSize = 5f + player.transform.position.y; //캐릭터가 점프할 때마다 카메라 줌인,줌아웃.
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, cameraSize, Time.deltaTime / speed);
        //Time.deltaTime*2 의 시간만큼 값의 변화를 준다. 
    }
}
