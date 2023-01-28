using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevelAfterTime : MonoBehaviour
{
    // add attribute so field shows up in editor
    [SerializeField]
    // can adjust delay before loading depending on timer used (25 or 50 min)
    private float delayBeforeLoading = 10f;

    [SerializeField]
    private string sceneNameToLoad;

    private void timeElapsed;
   

    // Update is called once per frame
    void Update()
    {
        timeElapsed+=Time.deltaTime

        if (timeElapsed > delayBeforeLoading)
        {
            //can decide which scene to load next by writing in name
            SceneManager.LoadScene(sceneNameToLoad);
            //scene we want to load must be in 'scenes to build' (build settings)
        }
    }
}
