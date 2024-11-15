using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCreditManager : MonoBehaviour
{
    float moveSpeed = 1.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime * 2);//文字の移動
            return;
        }

        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);//文字の移動
    }
}
