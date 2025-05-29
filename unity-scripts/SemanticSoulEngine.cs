using System.Collections.Generic;
using UnityEngine;

public class SemanticSoulEngine
{
    public string soulName;
    public Dictionary<string, float> emotionVector;
    public List<MemoryThread> memoryThreads;

    public SemanticSoulEngine(string name)
    {
        soulName = name;
        emotionVector = new Dictionary<string, float>
        {
            {"JoySorrow", 0.5f},
            {"FearCourage", 0.5f},
            {"BondAffinity", 0.5f}
        };
        memoryThreads = new List<MemoryThread>();
    }

    public void AddMemoryThread(string summary, string detail, float impact)
    {
        memoryThreads.Add(new MemoryThread(summary, detail, impact));
    }

    public void UpdateEmotionVector(string key, float value)
    {
        if (emotionVector.ContainsKey(key))
        {
            emotionVector[key] = Mathf.Clamp(value, 0f, 1f);
        }
    }

    public class MemoryThread
    {
        public string summary;
        public string detail;
        public float emotionalWeight;

        public MemoryThread(string s, string d, float w)
        {
            summary = s;
            detail = d;
            emotionalWeight = w;
        }
    }
}