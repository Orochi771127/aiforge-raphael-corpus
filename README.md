# AIForge Raphael Corpus / Raphael 語料庫

Canonical reviewed source repository for RaphaelCore semantic materials. RaphaelCore 語意材料的 canonical 經審閱來源儲存庫。

This repository is **not** the Nexus Link game runtime, RaphaelCore executable policy, HMAX hosted service, or a large language model. It stores source corpus, concept dictionaries, sentence materials, mapping tables and historical prototypes used to design RaphaelCore.

本儲存庫**不是** Nexus Link 遊戲 runtime、RaphaelCore 可執行政策、HMAX 託管服務或大型語言模型。它保存來源語料、概念字典、句子材料、映射表與歷史 prototype。

## Repository role

```text
reviewed source corpus + historical prototypes
→ reviewed/versioned runtime snapshots in raphael-ai-engine
→ client integration through Raphael contracts
```

## Current status

The early Raphael semantic corpus and Unity-era Semantic Soul prototypes are preserved for traceability. They are not live policy and must be reviewed, versioned and tested before any subset is promoted into `raphael-ai-engine/corpus/`.

早期 Raphael 語意語料與 Unity 時代 Semantic Soul prototype 只為可追溯性而保留；它們不是 live policy。任何內容進入 `raphael-ai-engine/corpus/` 前，都必須經審閱、版本化與測試。

## Directory map

```text
corpus/
  concepts/       Concept dictionary entries, such as A-series semantic anchors.
  sentences/      Sentence corpus entries, such as F-series lines.
  mappings/       Concept ↔ emotion ↔ sentence mappings, such as G-series mappings.

legacy-unity-prototype/
  Unity C# prototype files from the early Raphael / Semantic Soul engine phase.
  These are preserved as design reference, not current Nexus Link Web runtime code.

unity-scripts/
  Extended Unity-era experiments. Historical reference only; not a second live engine.

ai/prompts/
  Historical AI collaboration prompts. They are not runtime skills or autonomous policy.

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

The executable repository family is separate:

```text
Orochi771127/raphael-ai-engine   canonical kernel and contracts
Orochi771127/raphael-HMAX       private hosted Memory, Auth & eXecution control plane
Orochi771127/NexusLink          first-party client and mature live Core until parity
```

`raphael-ai-engine/corpus/` contains reviewed, versioned runtime/eval snapshots. It is a consumer artifact, not a competing source-of-truth corpus. Changes flow by explicit review and provenance, never by automatic bidirectional sync.

`raphael-ai-engine/corpus/` 保存經審閱、版本化的 runtime/eval 快照，是消費端 artifact，不是第二個語料單一真相來源。資料只透過明示審閱與 provenance 流動，不做自動雙向同步。

## Integration principle

RaphaelCore should use this corpus as structured data. It should not outsource core relationship decisions to an LLM.

Correct direction:

```text
NexusCore decides emotion, intent, memory, boundary, reaction, trace, animation.
LLM, if added later, may only act as an optional language rendering layer.
```

## Retention and deletion / 保留與刪除

- Keep the A/F/G JSON corpus as canonical source material.
- Keep both Unity-era trees and historical prompts as clearly labeled reference until a checksum manifest and provenance review prove a safe consolidation.
- Archive, do not delete, `Orochi771127/AiforgeNEXUS-raphael-corpus`; it already redirects to this canonical repository.
- Do not copy raw user conversations, Care content or crisis text into this repository.

- A/F/G JSON 語料保留為 canonical source material。
- 兩套 Unity-era 目錄與歷史 prompts 在完成 checksum manifest 與 provenance 審閱前，保留並明確標示 reference，不直接刪除。
- `Orochi771127/AiforgeNEXUS-raphael-corpus` 應封存而非刪除；它已導向本 canonical repo。
- 禁止把玩家原始對話、Care 或危機文字寫入本儲存庫。
