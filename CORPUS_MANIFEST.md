# Raphael Corpus Manifest v1

This manifest defines the initial merged corpus layout for `aiforge-raphael-corpus`.

## Status

- Canonical repository: `Orochi771127/aiforge-raphael-corpus`
- Legacy repository: `Orochi771127/AiforgeNEXUS-raphael-corpus`
- Imported materials: A/F/G semantic JSON files and Unity-era Raphael / Semantic Soul C# prototype files
- Runtime status: source/reference only; promotion requires reviewed, versioned snapshots in `raphael-ai-engine/corpus/`

## Corpus layers

### A — Concepts

Path:

```text
corpus/concepts/A_concepts.json
```

Purpose:

- Defines semantic concept nodes.
- Each concept has an ID, label, definition, related concepts, and tags.
- Example concepts include loss and apology.

### F — Sentences

Path:

```text
corpus/sentences/F_sentences.json
```

Purpose:

- Defines sentence-level corpus examples.
- Each sentence has an ID, text, language, emotion, tone, and linked concepts.

### G — Mappings

Path:

```text
corpus/mappings/G_mappings.json
```

Purpose:

- Maps concept IDs to emotion hints and sentence IDs.
- Provides a lightweight bridge between semantic concepts and response material.

## Legacy Unity prototype

Path:

```text
legacy-unity-prototype/
```

Purpose:

- Preserves early Raphael / Semantic Soul engine ideas.
- Includes emotion vector state, memory threads, semantic anchors, gravity map, save system, visual controller, and UI visualizer.
- These files are not current Web runtime code and should be refactored before use in Nexus Link.

## Executable consumer target

The canonical executable consumer is the game-neutral `Orochi771127/raphael-ai-engine`. Nexus Link remains the first-party client and mature live authority until parity passes; private hosted infrastructure belongs to `Orochi771127/raphael-HMAX`.

```text
aiforge-raphael-corpus (canonical reviewed source)
  → explicit provenance review and version pin
  → raphael-ai-engine/corpus (runtime/eval snapshot)
  → Raphael contract
  → Nexus Link or another approved client
```

No automatic bidirectional sync is allowed. Runtime-derived player text, memory, Care content and crisis text never flow back into this corpus.

## Non-goals

This corpus does not:

- replace Nexus Link runtime code;
- provide a trained LLM;
- directly perform safety handling;
- decide whether a companion accepts or rejects player action;
- directly render UI, animation, or habitat traces.

Those are engine responsibilities, not corpus responsibilities.
