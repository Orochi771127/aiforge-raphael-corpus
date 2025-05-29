# ChatGPT 貢獻記錄

## 任務描述
- 核心語義模組撰寫與整合（RaphaelEngineAdapter, SemanticSoulEngine）
- 記憶結構、情緒向量計算與對話邏輯分析

## Prompt 範本
```plaintext
請根據 EmotionType=Joy, MonsterType=Power，生成對應語義回應並更新記憶向量。
使用 RaphaelEngineAdapter 的回呼結構更新語義層與情緒向量，同時確認對話符合 Power 類型語氣。
