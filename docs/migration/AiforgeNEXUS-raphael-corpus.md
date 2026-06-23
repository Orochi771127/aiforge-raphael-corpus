# Migration note: AiforgeNEXUS-raphael-corpus

## Decision

`Orochi771127/aiforge-raphael-corpus` is the canonical Raphael corpus repository.

`Orochi771127/AiforgeNEXUS-raphael-corpus` is treated as a legacy / duplicate initialization repository.

## Reason

The canonical repository name is shorter, all lowercase, and better suited for long-term references in tools, docs, and agent workflows.

The legacy repository currently only contains an initial README-level semantic corpus declaration and should not be used as the primary source of truth after this migration.

## Imported content

The following local materials were imported into `aiforge-raphael-corpus` on branch `merge/raphael-corpus-v1`:

```text
corpus/concepts/A_concepts.json
corpus/sentences/F_sentences.json
corpus/mappings/G_mappings.json
legacy-unity-prototype/SemanticSoulEngine.cs
legacy-unity-prototype/RaphaelEngineAdapter.cs
legacy-unity-prototype/RaphaelMemoryCompressor.cs
legacy-unity-prototype/RaphaelSaveSystem.cs
legacy-unity-prototype/AIEmotionVisualController.cs
legacy-unity-prototype/RaphaelDialogueVisualizer.cs
```

## Legacy repository action

The legacy repository should remain available for traceability, but its README should point readers to the canonical repository.

Do not delete the legacy repository until all project documentation and agent prompts have stopped referring to it.
