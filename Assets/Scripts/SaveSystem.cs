using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{

    //fomatter

    public static void SavePlayerData (Player player)
    {
        PlayerData playerData = new PlayerData(player);
        //persistenDataPath se adapta a cualquier sistema
        string dataPath = Application.persistentDataPath + "/player.save";
        FileStream fileStream = new FileStream(dataPath, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fileStream, playerData);
        fileStream.Close();
    }

    public static PlayerData LoadPlayerData()
    {
        string dataPath = Application.persistentDataPath+"/player.save";
        if(File.Exists(dataPath))
        {
            FileStream fileStream = new FileStream(dataPath, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            PlayerData playerData = (PlayerData) formatter.Deserialize(fileStream);
            fileStream.Close();
            return playerData;
        }
        else
        {
            return null;
        }
    }
}
