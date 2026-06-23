using UnityEngine;
using TMPro;

public class RaphaelDialogueVisualizer : MonoBehaviour
{
    public TextMeshProUGUI semanticAnchorText;
    public RaphaelPersonalityProfile personalityProfile;

    void Update()
    {
        if (personalityProfile.semanticAnchors.Count > 0)
        {
            semanticAnchorText.text = personalityProfile.semanticAnchors.Last().summary;
        }
    }
}
