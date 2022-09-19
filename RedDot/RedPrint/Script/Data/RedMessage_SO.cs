using System;
using System.Collections.Generic;
using RedPrint.Script.Enum;
using UnityEngine;


    [CreateAssetMenu(fileName = "RedMessage_SO", menuName = "Email/RedMessage_SO", order = 0)]
    public class RedMessage_SO : ScriptableObject
    {
        public List<EmailMessage> emailDict;
    }

    [Serializable]
    public class EmailMessage
    {
        public EmailType type;
        public int num;
    }
