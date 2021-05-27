using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    
    private Vector3 screenPoint;//�}�E�X���͂̃|�W�V����
    private Vector3 offset;//���ƃ}�E�X�|�W�V�����Ƃ̋���
    
   public bool PuzzleClear = false;//�p�Y�����N���A���Ă��邩�ǂ���
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PuzzleIn();
    }
    //�p�Y���̂͂܂鋓��
    void PuzzleIn()
    {
        float objPosX = transform.position.x;
        float objPosY = transform.position.y;

        //�p�[�c�̈ʒu��������0.3mm�͈̔͂Ȃ�͂܂�悤�ɓ�����
        if (objPosX <= 5.3f && objPosX >= -5.3f)
        {          
            if (objPosY <= 0.3f && objPosY >= -0.3f)
            {
                transform.position = new Vector3(5, 0, 0);
                PuzzleClear = true;
            }
        }
    }
    //�}�E�X�{�^�����N���b�N�����Ƃ��̏���

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    // �}�E�X���h���b�O���Ă���Ƃ��̏���
    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;
        transform.position = currentPosition;
      
    }
}