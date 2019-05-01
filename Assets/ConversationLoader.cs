using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ConversationLoader : MonoBehaviour
{
    private string conversationPath = "Conversation.json";
    private ConversationData parsed;

    void Start(){
        LoadConversationData();
    }

    private void LoadConversationData(){
        string filePath = Path.Combine(Application.streamingAssetsPath, conversationPath);

        if(File.Exists(filePath)){
            StreamReader reader = new StreamReader(filePath);
            parsed = JsonUtility.FromJson<ConversationData>(reader.ReadToEnd());
            reader.Close();
        }

        print(parsed.npc[2].text);
    }
}
