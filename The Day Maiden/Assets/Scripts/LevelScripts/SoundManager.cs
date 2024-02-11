using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SoundManager : MonoBehaviour
{
    private string filePath;
    private float volume = 0.5f;
    public Slider volumeSlider;

    private void Start()
    {
        filePath = Application.persistentDataPath + "/sound_settings.json";
        volumeSlider.value = volume;
        LoadSoundSettings();
    }

    private void Update()
    {
        SetVolume(volumeSlider.value);
    }

    public void SetVolume(float value)
    {
        volume = value;
        AudioListener.volume = volume;
        SaveSoundSettings();
    }

    public void SaveSoundSettings()
    {
        SoundSettingsData data = new SoundSettingsData(volume);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, json);
    }

    private void LoadSoundSettings()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SoundSettingsData data = JsonUtility.FromJson<SoundSettingsData>(json);
            volume = data.volume;
            AudioListener.volume = volume;
            volumeSlider.value = volume;
        }
    }
}

[System.Serializable]
public class SoundSettingsData
{
    public float volume;

    public SoundSettingsData(float volume)
    {
        this.volume = volume;
    }
}
