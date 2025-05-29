using UnityEngine;

public class EvolutionManager : MonoBehaviour
{
    public SemanticSoulEngine soulEngine;
    public MonsterProfile monsterProfile;
    public SpriteRenderer spriteRenderer;
    public Sprite starFoalSprite;
    public Sprite crystalEarthSteedSprite;
    public Sprite unicornStarSprite;
    public Sprite titanStarEmperorSprite;

    void Update()
    {
        if (soulEngine.emotionVector["BondAffinity"] > 0.3f && monsterProfile.monsterName == "NexusCore")
        {
            monsterProfile.monsterName = "StarFoal";
            spriteRenderer.sprite = starFoalSprite;
            Debug.Log("進化為StarFoal");
        }
        else if (soulEngine.emotionVector["BondAffinity"] > 0.5f && soulEngine.emotionVector["FearCourage"] > 0.3f && monsterProfile.monsterName == "StarFoal")
        {
            monsterProfile.monsterName = "CrystalEarthSteed";
            spriteRenderer.sprite = crystalEarthSteedSprite;
            Debug.Log("進化為CrystalEarthSteed");
        }
        else if (soulEngine.emotionVector["BondAffinity"] > 0.7f && soulEngine.emotionVector["JoySorrow"] < 0.5f && monsterProfile.monsterName == "CrystalEarthSteed")
        {
            monsterProfile.monsterName = "UnicornStar";
            spriteRenderer.sprite = unicornStarSprite;
            Debug.Log("進化為UnicornStar");
        }
        else if (soulEngine.emotionVector["BondAffinity"] > 0.9f && soulEngine.emotionVector["JoySorrow"] > 0.8f && monsterProfile.monsterName == "UnicornStar")
        {
            monsterProfile.monsterName = "TitanStarEmperor";
            spriteRenderer.sprite = titanStarEmperorSprite;
            Debug.Log("進化為TitanStarEmperor");
        }
    }
}