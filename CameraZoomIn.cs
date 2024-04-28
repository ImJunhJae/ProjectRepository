using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomIn : MonoBehaviour
{
    public Camera camera; //ī�޶� ��ü
    public GameObject player;  //�÷��̾� ��ü

    public float speed = 0.5f; //�ٲ� ������ �ӵ�
    public float cameraSize = 5f;  //��ŭ ī�޶� ���� ����

//�󸶸�ŭ ���� �������� ����
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
        Debug.Log("��ٷ�!");
        yield return new WaitForSeconds(3);
        //���� �ܾƿ� �ִ� �ּҰ� ����.
        if (cameraSize >= MaxSize)
            cameraSize = MaxSize;
        if (cameraSize <= MinSize)
            cameraSize = MinSize;

        //cameraSize = 5f + player.transform.position.y; //ĳ���Ͱ� ������ ������ ī�޶� ����,�ܾƿ�.
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, cameraSize, Time.deltaTime / speed);
        //Time.deltaTime*2 �� �ð���ŭ ���� ��ȭ�� �ش�. 
        Debug.Log("���� ����!");
        yield return null;
        Debug.Log("�ڷ�ƾ ��!!");
        //zoomIn();
        //Debug.Log("�� �ٽ� ����!!!");
    }

    void zoomIn()
    {
        Debug.Log("�����ƾƤ��ƾƤ�����");
        //���� �ܾƿ� �ִ� �ּҰ� ����.
        if (cameraSize >= MaxSize)
            cameraSize = MaxSize;
        if (cameraSize <= MinSize)
            cameraSize = MinSize;

        //cameraSize = 5f + player.transform.position.y; //ĳ���Ͱ� ������ ������ ī�޶� ����,�ܾƿ�.
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize, cameraSize, Time.deltaTime / speed);
        //Time.deltaTime*2 �� �ð���ŭ ���� ��ȭ�� �ش�. 
    }
}
