using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    
    private Vector3 screenPoint;//マウス入力のポジション
    private Vector3 offset;//物とマウスポジションとの距離
    
   public bool PuzzleClear = false;//パズルをクリアしているかどうか
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PuzzleIn();
    }
    //パズルのはまる挙動
    void PuzzleIn()
    {
        float objPosX = transform.position.x;
        float objPosY = transform.position.y;

        //パーツの位置が正解の0.3mmの範囲ならはまるように動かす
        if (objPosX <= 5.3f && objPosX >= -5.3f)
        {          
            if (objPosY <= 0.3f && objPosY >= -0.3f)
            {
                transform.position = new Vector3(5, 0, 0);
                PuzzleClear = true;
            }
        }
    }
    //マウスボタンをクリックしたときの処理

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    // マウスをドラッグしているときの処理
    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;
        transform.position = currentPosition;
      
    }
}