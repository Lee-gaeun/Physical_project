using UnityEngine;

public class Blendshape_con : MonoBehaviour
{
    public SkinnedMeshRenderer skinnedMeshRenderer; // SkinnedMeshRenderer를 가진 GameObject에 연결합니다.
    public GameObject Receiver; // 함수가 담겨진 게임오브젝트 저장할 변수

    //string messageC;
    float numb;


    public float lerpSpeed = 1.0f; // 선형 보간 속도 유니티내에서 속도를 조절가능하도록 public으로 설정해준다
    private float currentB = 0;

    void ChangeMeshRederer()
    {
        //messageC = Receiver.GetComponent<SerialReceiver>().message;
        numb = Receiver.GetComponent<Reciever>().num;


        if (currentB < 100 && currentB < numb)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(0, currentB);
            currentB += lerpSpeed;
        }
        else if (currentB > 0 && currentB > numb)
        {
            skinnedMeshRenderer.SetBlendShapeWeight(0, currentB);
            currentB -= lerpSpeed;
        }
    }

    void Start()
    {

    }

    private void Update()
    {
        ChangeMeshRederer();
    }
}