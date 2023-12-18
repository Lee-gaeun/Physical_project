using UnityEngine;
using System.IO.Ports;
using System.Collections;

public class Danger_ui : MonoBehaviour
{
    //SerialPort serialPort = new SerialPort("COM5", 9600); // COM 포트와 보드레이트 설정
    float num1;
    private float currentA = 0;

    public GameObject dangerImage; // 경고 이미지에 대한 참조
    public GameObject SerialReceiver; // 경고 이미지에 대한 참조
    IEnumerator dangerUp()
    {
        //messageC = Receiver.GetComponent<SerialReceiver>().message;
        num1 = SerialReceiver.GetComponent<Reciever>().num;

        if (num1 < 30)
        {
            dangerImage.SetActive(true); // 이미지 활성화
            yield return new WaitForSeconds(5); // 5초 대기
            dangerImage.SetActive(false); // 이미지 비활성화
        }
    }
    void Start()
    {

    }

    void Update()
    {
        //();

    }
    /*
    IEnumerator ShowDangerImage()
    {
        dangerImage.SetActive(true); // 이미지 활성화
        yield return new WaitForSeconds(5); // 5초 대기
        dangerImage.SetActive(false); // 이미지 비활성화
    }*/

}

