using RedPrint.Script.Event;
using UnityEngine;
using UnityEngine.UI;

public class ItemBuyManager : MonoBehaviour
{
    public RedMessage_SO newRedMessage, oldRedMessageSo;
    private Button buyBtn => GetComponent<Button>();
    // Start is called before the first frame update
    void Start()
    {
        buyBtn.onClick.AddListener(OnBuyClick);
        EventHandler.CallCursorClick(newRedMessage);
    }

    private void OnBuyClick()
    {
        var index = Random.Range(0, 2);
        newRedMessage.emailDict.Add(oldRedMessageSo.emailDict[index]);
        EventHandler.CallCursorClick(newRedMessage);
    }
}
