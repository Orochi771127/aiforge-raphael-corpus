using UnityEngine;

public class AIEmotionVisualController : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public SemanticSoulEngine soulEngine;

    public Color happyColor = Color.green;
    public Color sadColor = Color.red;
    public Color neutralColor = Color.white;

    void Update()
    {
        if (soulEngine.emotionVector["BondAffinity"] > 0.7f)
        {
            spriteRenderer.color = happyColor;
        }
        else if (soulEngine.emotionVector["BondAffinity"] < 0.3f)
        {
            spriteRenderer.color = sadColor;
        }
        else
        {
            spriteRenderer.color = neutralColor;
        }
    }
}
