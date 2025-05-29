using UnityEngine;
using System.Collections.Generic;

public class RaphaelMemoryCompressor : MonoBehaviour
{
    public RaphaelPersonalityProfile personalityProfile;
    private const int MAX_CORPUS_SIZE = 500;

    public void CompressMemory()
    {
        if (personalityProfile.factualCorpus.Count > MAX_CORPUS_SIZE)
        {
            personalityProfile.factualCorpus.RemoveRange(0, personalityProfile.factualCorpus.Count - MAX_CORPUS_SIZE);
            Debug.Log("[RaphaelMemoryCompressor] 語料庫已壓縮至500條");
        }
    }
}