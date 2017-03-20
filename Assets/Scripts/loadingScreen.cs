using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScreen : MonoBehaviour {

    public string levelLoad;
    string[] tips = { "Tips: Press E to spawn block!", "Tips: Pick up block with right mouse", "Tips: Throw balls with left mouse", "Tips: Fly with CTRL" };
    public GameObject background;
    public GameObject backgroundImage;
    public GameObject tipsText;
    public GameObject text;
    public GameObject progressBar;
    bool hasStartedNewGame;
    private int loadProgress = 0;


    // Use this for initialization
    void Start () {
        background.SetActive(false);
        text.SetActive(false);
        progressBar.SetActive(false);
        tipsText.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator DisplayLoadingScreen(string level) {
        background.SetActive(true);
        text.SetActive(true);
        progressBar.SetActive(true);
        tipsText.SetActive(true);
        backgroundImage.SetActive(false);


        tipsText.GetComponent<GUIText>().text = tips[Random.Range(0, 3)];
        Debug.Log(tips[0] + tips[1] + tips[2] + tips[3]);

        progressBar.transform.localScale = new Vector3(loadProgress, progressBar.transform.localScale.y, progressBar.transform.localScale.z);

        text.GetComponent<GUIText>().text = "Loading Progress " + loadProgress + "%";

        AsyncOperation async = Application.LoadLevelAsync(level);
        while (!async.isDone)
        {
            loadProgress = (int)(async.progress * 100);
            text.GetComponent<GUIText>().text = "Loading Progress " + loadProgress + "%";
            Debug.Log("Loadprogress: "+loadProgress);
            progressBar.transform.localScale = new Vector3(async.progress, progressBar.transform.localScale.y, progressBar.transform.localScale.z);

            yield return null;

        }


    }

    void OnGUI()
    {

        if (!hasStartedNewGame)
        {
            GUI.color = Color.blue;
            if (GUI.Button(new Rect(Screen.width / 2 - 70, Screen.height / 2 + 10, 130, 50), "Click"))
            {
               // Application.LoadLevel(levelLoad);
                StartCoroutine(DisplayLoadingScreen(levelLoad));
                hasStartedNewGame = true;
            }

        }

    }

}
