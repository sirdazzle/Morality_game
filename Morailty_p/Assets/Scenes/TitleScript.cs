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
            { // 마우스 왼쪽 버튼을 누르면
                Application.LoadLevel("mainScene"); // mainScene으로 이동.
            }
        }
        void OnGUI()
        {
            //화면의 title이라고 표시
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 128, 32), "title");
        }
    }
}
