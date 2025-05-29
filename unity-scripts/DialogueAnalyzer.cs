using UnityEngine;

public class DialogueAnalyzer : MonoBehaviour
{
    public RaphaelEngineAdapter engineAdapter;

    public string Analyze(string playerInput)
    {
        if (string.IsNullOrEmpty(playerInput)) return "請輸入一些內容！";

        // 使用SAGE情緒感知模型分析輸入
        if (playerInput.Contains("孤獨"))
        {
            return engineAdapter.GenerateResponse(playerInput);
        }
        else if (playerInput.Contains("壓力"))
        {
            return engineAdapter.GenerateResponse(playerInput);
        }
        else if (playerInput.Contains("快樂"))
        {
            return engineAdapter.GenerateResponse(playerInput);
        }
        else
        {
            return "我聽到你的想法，告訴我更多吧！";
        }
    }
}