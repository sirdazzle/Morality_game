using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            { // ���콺 ���� ��ư�� ������
                Application.LoadLevel("mainScene"); // mainScene���� �̵�.
            }
        }
        void OnGUI()
        {
            //ȭ���� title�̶�� ǥ��
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 128, 32), "title");
        }
    }
}
