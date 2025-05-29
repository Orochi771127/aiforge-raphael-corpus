using UnityEngine;

public class MonsterProfile : MonoBehaviour
{
    public SemanticSoulEngine soulEngine;
    public RaphaelPersonalityProfile raphaelProfile;
    public string monsterName = "NexusCore";

    void Start()
    {
        soulEngine = new SemanticSoulEngine(monsterName);
        RaphaelSaveSystem.LoadProfile(raphaelProfile);
    }

    void OnDestroy()
    {
        RaphaelSaveSystem.SaveProfile(raphaelProfile);
    }
}