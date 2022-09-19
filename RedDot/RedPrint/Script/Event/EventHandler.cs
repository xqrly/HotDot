using System;
using UnityEngine;

namespace RedPrint.Script.Event
{
    public static class EventHandler
    {
        /// <summary>
        /// 鼠标点击的时候发生改变呼叫
        /// </summary>
        public static event Action<RedMessage_SO> CursorClick;

        public static void CallCursorClick(RedMessage_SO newSo)
        {
            CursorClick?.Invoke(newSo);
        }
        public static event Action MouseClick;

        public static void CallMouseClick( )
        {
            MouseClick?.Invoke();
        }
        public static event Action<int> Amount;

        public static void CallAmount(int num)
        {
            Amount?.Invoke(num);
        }
        
        public static event Action<int> CursorSub;

        public static void CallCursorSub(int num)
        {
            CursorSub?.Invoke(num);
        }

       
    }
}