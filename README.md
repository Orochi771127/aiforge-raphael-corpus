# AIForge Raphael Corpus

Canonical corpus repository for Raphael / Nexus Core semantic materials.

This repository is **not** the Nexus Link game runtime and it is **not** a large language model. It stores the semantic corpus, concept dictionaries, sentence materials, mapping tables, personality rules, and legacy engine prototypes used to design RaphaelCore / NexusCore.

## Repository role

```text
corpus data + legacy prototype notes
→ RaphaelCore / NexusCore engine design
→ Nexus Link runtime integration
```

## Current status

This branch imports the early Raphael semantic corpus and Unity-era Semantic Soul prototype for preservation and later JavaScript/Web refactoring.

## Directory map

```text
corpus/
  concepts/       Concept dictionary entries, such as A-series semantic anchors.
  sentences/      Sentence corpus entries, such as F-series lines.
  mappings/       Concept ↔ emotion ↔ sentence mappings, such as G-series mappings.

legacy-unity-prototype/
  Unity C# prototype files from the early Raphael / Semantic Soul engine phase.
  These are preserved as design reference, not current Nexus Link Web runtime code.

docs/migration/
  Notes about merged or legacy repositories.
```

## Canonical repository decision

`Orochi771127/aiforge-raphael-corpus` is the canonical Raphael corpus repository.

The older repository `Orochi771127/AiforgeNEXUS-raphael-corpus` is treated as a legacy / duplicate initialization repository and should no longer be used as the primary source of truth.

## Important distinction

This repository provides **materials**:

- concepts
- sentence examples
- emotion hints
- mapping tables
- persona rules
- memory templates
- legacy prototype references

The actual AI decision engine should live in the Nexus Link runtime or a dedicated RaphaelCore module, for example:

```text
NexusLink/src/ai/raphaelCore.js
NexusLink/src/ai/emotionInterpreter.js
NexusLink/src/ai/intentClassifier.js
NexusLink/src/ai/reactionPlanner.js
NexusLink/src/ai/responseComposer.js
```

## Integration principle

RaphaelCore should use this corpus as structured data. It should not outsource core relationship decisions to an LLM.

Correct direction:

```text
NexusCore decides emotion, intent, memory, boundary, reaction, trace, animation.
LLM, if added later, may only act as an optional language rendering layer.
```
