using System.IO;
using System.Xml.Serialization;

public class AppSettings
{
    public bool KeepRunning { get; set; }

    // 設定ファイルのパスを定数として定義します。
    public const string SettingsFilePath = "settings.xml";

    // デフォルトコンストラクタ（XMLシリアライゼーションに必要）
    public AppSettings() { }

    public AppSettings(bool keepRunning)
    {
        KeepRunning = keepRunning;
    }

    // 設定をXMLファイルに保存します。
    public void Save()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
        using (StreamWriter writer = new StreamWriter(SettingsFilePath))
        {
            serializer.Serialize(writer, this);
        }
    }

    // XMLファイルから設定を読み込みます。
    public static AppSettings Load()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));

        // Check if the settings file exists
        if (!File.Exists(SettingsFilePath))
        {
            // If not, create default settings and save to file
            var defaultSettings = new AppSettings(false);  // Or whatever your default settings are
            defaultSettings.Save();
            return defaultSettings;
        }

        using (StreamReader reader = new StreamReader(SettingsFilePath))
        {
            return (AppSettings)serializer.Deserialize(reader);
        }
    }
}
