using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SemanticSoulEngine soulEngine;
    public RaphaelEngineAdapter engineAdapter;
    public MonsterProfile monsterProfile;

    void Start()
    {
        // 初始化遊戲組件
        soulEngine = new SemanticSoulEngine("Raphael");
        engineAdapter = GetComponent<RaphaelEngineAdapter>();
        monsterProfile = GetComponent<MonsterProfile>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}