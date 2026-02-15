using UnityEngine;
using System.IO;

public class levelsProgress : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static levelsProgress Instance;

    public bool completeLevel1 = false;
    public bool completeLevel2 = false;
    public bool completeLevel3 = false;
    public bool completeLevel4 = false;
    public bool completeLevel5 = false;
    public bool completeLevel6 = false;
    public bool completeLevel7 = false;
    public bool completeLevel8 = false;
    public bool completeLevel9 = false;
    public bool completeLevel10 = false;
    public bool completeLevel11 = false;
    public bool completeLevel12 = false;
    public bool completeLevel13 = false;
    public bool completeLevel14 = false;
    public bool completeLevel15 = false;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
}
