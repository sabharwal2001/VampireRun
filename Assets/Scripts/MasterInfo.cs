using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int coinCollected = 0;
    [SerializeField] GameObject txtField;

    // Update is called once per frame
    void Update()
    {
        txtField.GetComponent<TMPro.TMP_Text>().text = "Coins: " + coinCollected;
    }
}
