using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDelta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime : 1프레임에 사용된 시간
        // Translate 함수에서는 벡터에 곱하기!
        // Vecotr 함수에서는 시간 매개변수에 곱하기!
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime * 5f,
            Input.GetAxisRaw("Vertical") * Time.deltaTime * 5f,
            0
        );

        transform.Translate(vec);
    }
}
