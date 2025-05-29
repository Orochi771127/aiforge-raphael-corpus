using UnityEngine;

public class TrainingMiniGame : MonoBehaviour
{
    public SemanticSoulEngine soulEngine;
    public float clickTimer = 30f;
    private float timeRemaining;
    private int clickCount;

    void Start()
    {
        timeRemaining = clickTimer;
        clickCount = 0;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (Input.GetMouseButtonDown(0))
            {
                clickCount++;
                soulEngine.UpdateEmotionVector("BondAffinity", soulEngine.emotionVector["BondAffinity"] + 0.05f);
                Debug.Log($"點擊次數：{clickCount}，BondAffinity：{soulEngine.emotionVector["BondAffinity"]}");
            }
        }
    }
}