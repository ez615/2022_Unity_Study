using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{        
    Vector3 target = new Vector3(8, 1.5f, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 vec = new Vector3(
        //     Input.GetAxis("Horizontal"), 
        //     Input.GetAxis("Vertical"), 
        //     0);
        // transform.Translate(vec);

        //1.MoveTowards
        // transform.position = Vector3.MoveTowards(transform.position, target, 1f) //현재 위치, 목표 위치, 속도

        //2.SmoothDamp
        // Vector3 velo1 = Vector3.zero;
        // Vector3 velo2 =  Vector3.up * 50;

        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo1, 0.1f); //마지막 매개변수에 반비례하여 속도 증가

        //3.Lerp(선형 보간 이동)
        // transform.position = Vector3.Lerp(transform.position, target, 0.1f); // 마지막 매개변수는 [0, 1]

        //4.SLerp (구면 선형 보간 이동) : 포물선 이동
        // transform.position = Vector3.Slerp(transform.position, target, 0.05f); // 마지막 매개변수는 [0, 1]
    }
}
