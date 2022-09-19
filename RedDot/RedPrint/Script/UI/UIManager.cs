
using System;
using RedPrint.Script.Item;
using UnityEngine;
using EventHandler = RedPrint.Script.Event.EventHandler;

namespace RedPrint.Script.UI
{
    public class UIManager : MonoBehaviour
    {
        public GameObject redBase;
        public Transform parent;
        private int index = 0;
        private void OnEnable()
        {
            EventHandler.CursorClick += OnCursorClick;
            EventHandler.MouseClick += OnMouseClick;
        }

        private void OnMouseClick()
        {
            index -= 1;
            Debug.Log(index);
            EventHandler.CallAmount(index);
        }

        private void OnCursorClick(RedMessage_SO obj)
        {
            var count = obj.emailDict.Count;
            if (count != 0)
            {
                for (int i = 0; i < obj.emailDict.Count; i++)
                {
                    var item = Instantiate(redBase, parent);
                    item.GetComponent<ItemBase>().RedSetActive("",true);
                }
            }
            if (count != 0)
            {
                index++;
                EventHandler.CallAmount(index);
            }
            obj.emailDict.Clear();
        }

        private void OnDestroy()
        {
            EventHandler.CursorClick -= OnCursorClick;
            EventHandler.MouseClick -= OnMouseClick;
        }
    }
}
