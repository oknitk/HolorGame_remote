using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[RequireComponent(typeof(Camera))]
public class MoveCamera : MonoBehaviour
{
    GameObject playerObj;
    PlayerCon player;
    Transform playerTransform;
    void Start()
    {

        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<PlayerCon>();
        playerTransform = playerObj.transform;
    }

    

    void LateUpdate()
    {
        Movecamera();
    }

    void Movecamera()
    {
        //�����������Ǐ]
        transform.position = new Vector3(playerTransform.position.x, transform.position.y, transform.position.z);
    }
}

