using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject instructionPanel;
    public GameObject testListPanel;
    public GameObject rinnePanel;
    public GameObject weberPanel;
    public GameObject schwabachPanel;

    public void ShowTestList()
    {
        instructionPanel.SetActive(false);
        testListPanel.SetActive(true);
    }

    public void ShowRinnePanel()
    {
        testListPanel.SetActive(false);
        rinnePanel.SetActive(true);
    }

    public void ShowWeberPanel()
    {
        testListPanel.SetActive(false);
        weberPanel.SetActive(true);
    }

    public void ShowSchwabachPanel()
    {
        testListPanel.SetActive(false);
        schwabachPanel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
