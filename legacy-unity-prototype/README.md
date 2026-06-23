# Legacy Unity Prototype

This directory preserves early Unity C# prototype files for Raphael / Semantic Soul.

These files are **reference material only**. They are not the current Nexus Link Web MVP runtime.

## Contents

| File | Role |
|---|---|
| `SemanticSoulEngine.cs` | Early semantic soul state engine: emotion vectors and memory threads. |
| `RaphaelEngineAdapter.cs` | Early adapter for semantic anchors, abstract logic, gravity map, factual corpus, and simple keyword response generation. |
| `RaphaelMemoryCompressor.cs` | Simple corpus trimming helper. |
| `RaphaelSaveSystem.cs` | Unity persistentDataPath save/load helper for Raphael personality profile. |
| `AIEmotionVisualController.cs` | Sprite color feedback based on BondAffinity. |
| `RaphaelDialogueVisualizer.cs` | TextMeshPro display helper for the latest semantic anchor. |

## Refactor warning

Do not copy these files directly into Nexus Link Web runtime.

They should be translated into JavaScript modules only after design review:

```text
Unity C# prototype
→ conceptual extraction
→ Web RaphaelCore JS modules
→ Nexus Link runtime integration
```

## Known prototype limitations

- Keyword-based response generation.
- No full boundary decision engine.
- No safety shield.
- No habitat trace mapper.
- No animated companion mapper.
- No current Nexus Link state schema compatibility.
