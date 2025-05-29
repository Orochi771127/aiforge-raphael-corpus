using UnityEngine;
using System.IO;

public static class RaphaelSaveSystem
{
    private static string fileName = "raphael_profile.json";

    public static void SaveProfile(RaphaelPersonalityProfile profile)
    {
        string json = JsonUtility.ToJson(profile, true);
        string path = GetSavePath();
        File.WriteAllText(path, json);
        Debug.Log("[RaphaelSaveSystem] 檔案已存於 " + path);
    }

    public static void LoadProfile(RaphaelPersonalityProfile profile)
    {
        string path = GetSavePath();
        if (!File.Exists(path))
        {
            Debug.LogWarning("[RaphaelSaveSystem] 檔案不存在, 無法載入。");
            return;
        }
        string json = File.ReadAllText(path);
        JsonUtility.FromJsonOverwrite(json, profile);
        Debug.Log("[RaphaelSaveSystem] 成功載入語義人格。");
    }

    private static string GetSavePath()
    {
        return Path.Combine(Application.persistentDataPath, fileName);
    }
}