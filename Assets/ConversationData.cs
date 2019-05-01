using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ConversationData
{
    public List<Npc> npc;
    public List<Player> player;

    [Serializable]
    public class Npc {
        public string text;
        public List<Condition> conditions;
        public List<string> playerResponses;
    }

    [Serializable]
    public class Player {
        public string text;
        public List<Condition> conditions;
        public List<SetCondition> setConditions;
        public List<string> npcResponses;
    }

    [Serializable]
    public class Condition{
        public string condition;
        public string value;
    }

    [Serializable]
    public class SetCondition{
        public string conditionSet;
        public string valueSet;
    }
}
