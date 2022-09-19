using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;
using EventHandler = RedPrint.Script.Event.EventHandler;

namespace RedPrint.Script.Item
{
    public class ItemBase : MonoBehaviour , IPointerClickHandler
    {
        public Image redImage;
        public Text redText;

        /// <summary>
        /// 显示和隐藏的
        /// </summary>
        /// <param name="num">消息数量</param>
        /// <param name="redFlag">是否显示或者隐藏</param>
        public void RedSetActive(string num = "", bool redFlag = false)
        {
            redText.text = num;
            redImage.gameObject.SetActive(redFlag);
        }
       
        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.pointerCurrentRaycast.gameObject.name == gameObject.name)
            {
                redImage.gameObject.SetActive(false);
                EventHandler.CallMouseClick();
            }
        }
    }
}
