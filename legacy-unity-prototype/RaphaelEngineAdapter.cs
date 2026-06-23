using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class RaphaelEngineAdapter : MonoBehaviour
{
    public RaphaelPersonalityProfile personalityProfile;
    private List<DialogueEntry> dialogueData;

    public void AnalyzeAndUpdate(string input)
    {
        if (string.IsNullOrEmpty(input)) return;

        UpdateSemanticAnchor(input);
        UpdateAbstractLogic(input);
        UpdateGravityMap(input);
        UpdateFactualCorpus(input);
    }

    private void UpdateSemanticAnchor(string input)
    {
        var anchor = new SemanticAnchor
        {
            id = "SA_" + DateTime.Now.Ticks,
            summary = input,
            timestamp = DateTime.Now
        };
        personalityProfile.semanticAnchors.Add(anchor);
    }

    private void UpdateAbstractLogic(string input)
    {
        if (input.Contains("情緒") && input.Contains("脈絡"))
        {
            personalityProfile.abstractRules.Add(new SemanticAbstractLogic
            {
                concept = "情緒 = 感覺 + 脈絡",
                reasoning = "情緒是感覺經脈絡化後的結果，需考慮語氣"
            });
        }
    }

    private void UpdateGravityMap(string input)
    {
        string[] keywords = { "孤獨", "壓力", "快樂", "勇敢" };
        foreach (var keyword in keywords)
        {
            if (input.Contains(keyword))
            {
                var match = personalityProfile.gravityMap.FirstOrDefault(g => g.vectorLabel == keyword);
                if (match == null)
                {
                    personalityProfile.gravityMap.Add(new SemanticGravityPoint
                    {
                        vectorLabel = keyword,
                        density = UnityEngine.Random.Range(0.3f, 1f),
                        emotionalBias = keyword switch
                        {
                            "孤獨" => -0.7f,
                            "壓力" => -0.5f,
                            "快樂" => 0.7f,
                            "勇敢" => 0.7f,
                            _ => 0f
                        },
                        exampleTrigger = input
                    });
                }
            }
        }
    }

    private void UpdateFactualCorpus(string input)
    {
        personalityProfile.factualCorpus.Add(input);
    }

    public string GenerateResponse(string playerInput)
    {
        if (string.IsNullOrEmpty(playerInput)) return "我需要一些資訊才能回答。";

        if (dialogueData != null)
        {
            var match = dialogueData.FirstOrDefault(d => playerInput.Contains(d.playerInput));
            if (match != null) return match.raphaelReply;
        }

        if (playerInput.Contains("孤獨"))
            return "我感受到你的孤獨，來摸摸我的頭吧，或許能讓你感到溫暖！";
        if (playerInput.Contains("壓力"))
            return "壓力讓你感到不安，試試深呼吸吧？";
        if (playerInput.Contains("快樂"))
            return "你的快樂讓我充滿能量！想分享更多嗎？";

        return "我聽見你說了：\"" + playerInput + "\"。你願意跟我分享更多嗎？";
    }

    public void LoadDialogueData()
    {
        string path = Path.Combine(Application.dataPath, "Dialogues/JSON/dialogue.json");
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            dialogueData = JsonConvert.DeserializeObject<List<DialogueEntry>>(json);
            Debug.Log("[RaphaelEngineAdapter] 對話數據載入成功");
        }
    }
}

public class DialogueEntry
{
    public string playerInput;
    public string raphaelReply;
    public string emotionTag;
    public string personalityStyle;
}

public class RaphaelPersonalityProfile
{
    public List<SemanticAnchor> semanticAnchors = new List<SemanticAnchor>();
    public List<SemanticAbstractLogic> abstractRules = new List<SemanticAbstractLogic>();
    public List<SemanticGravityPoint> gravityMap = new List<SemanticGravityPoint>();
    public List<string> factualCorpus = new List<string>();
}

public class SemanticAnchor
{
    public string id;
    public string summary;
    public DateTime timestamp;
}

public class SemanticAbstractLogic
{
    public string concept;
    public string reasoning;
}

public class SemanticGravityPoint
{
    public string vectorLabel;
    public float density;
    public float emotionalBias;
    public string exampleTrigger;
}
