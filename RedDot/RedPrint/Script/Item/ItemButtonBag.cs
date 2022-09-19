using System;
using UnityEngine;
using UnityEngine.UI;
using EventHandler = RedPrint.Script.Event.EventHandler;

namespace RedPrint.Script.Item
{
    public class ItemButtonBag : MonoBehaviour
    {
        public Image redImage;
        public Text redText;
        private void OnEnable()
        {
            EventHandler.Amount += RedBtnActive;
            EventHandler.CursorSub += RedBtnActive;
        }
        
        private void OnDestroy()
        {
            EventHandler.Amount -= RedBtnActive;
            EventHandler.CursorSub -= RedBtnActive;
        }
        public void RedBtnActive(int num = 0)
        {
            if (num == 0)
            {
                redText.text = "";
                redImage.gameObject.SetActive(false);
            }
            else
            {
                redText.text = num.ToString();
                redImage.gameObject.SetActive(true);
            }
        }
    }
}