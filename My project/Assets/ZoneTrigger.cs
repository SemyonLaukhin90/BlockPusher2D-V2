using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TriggerZone : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public Button Level1;
    public Button Level2;
    public Button Level3;
    public Button Level4;
    public Button Level5;
    public Button Level6;
    public Button Level7;
    public Button Level8;
    public Button Level9;
    public Button Level10;
    public Button Level11;
    public Button Level12;
    public Button Level13;
    public Button Level14;
    public Button Level15;

    public void getButtonColor(Button button, Color color)
    {
        ColorBlock colors = Level1.colors;
        colors.normalColor = color;
        button.colors = colors;
        button.interactable = true;
    }
void Update()
    {
        Scene activeScene = SceneManager.GetActiveScene();
        if (activeScene.name == "LevelsMenu")
        {
            if (levelsProgress.Instance.completeLevel1)
            {
                getButtonColor(Level1, Color.yellow);
            }
            if (levelsProgress.Instance.completeLevel2)
            {
                getButtonColor(Level1, Color.green);
                getButtonColor(Level2, Color.yellow);
                Level2.interactable = true;
            } 
            if (levelsProgress.Instance.completeLevel3)
            {
                getButtonColor(Level2, Color.green);
                getButtonColor(Level3, Color.yellow);
                Level3.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel4) {
                getButtonColor(Level3, Color.green);
                getButtonColor(Level4, Color.yellow);
                Level4.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel5) {
                getButtonColor(Level4, Color.green);
                getButtonColor(Level5, Color.yellow); 
                Level5.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel6)
            {
                getButtonColor(Level5, Color.green);
                getButtonColor(Level6, Color.yellow);
                Level6.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel7)
            {
                getButtonColor(Level6, Color.green);
                getButtonColor(Level7, Color.yellow);
                Level7.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel8)
            {
                getButtonColor(Level7, Color.green);
                getButtonColor(Level8, Color.yellow);
                Level8.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel9)
            {
                getButtonColor(Level8, Color.green);
                getButtonColor(Level9, Color.yellow);
                Level9.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel10)
            {
                getButtonColor(Level9, Color.green);
                getButtonColor(Level10, Color.yellow);
                Level10.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel11)
            {
                getButtonColor(Level10, Color.green);
                getButtonColor(Level11, Color.yellow);
                Level11.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel12)
            {
                getButtonColor(Level11, Color.green);
                getButtonColor(Level12, Color.yellow);
                Level12.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel13)
            {
                getButtonColor(Level12, Color.green);
                getButtonColor(Level13, Color.yellow);
                Level13.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel14)
            {
                getButtonColor(Level13, Color.green);
                getButtonColor(Level14, Color.yellow);
                Level14.interactable = true;
            }
            if (levelsProgress.Instance.completeLevel15)
            {
                getButtonColor(Level14, Color.green);
                getButtonColor(Level15, Color.yellow);
                Level15.interactable = true;
            }
        } 
        else if (activeScene.name == "Level 1")
        {
            levelsProgress.Instance.completeLevel1 = true;
        }
        else if (activeScene.name == "Level 2")
        {
            levelsProgress.Instance.completeLevel2 = true;
        }
        else if (activeScene.name == "Level 3")
        {
            levelsProgress.Instance.completeLevel3 = true;
        }
        else if (activeScene.name == "Level 4")
        {
            levelsProgress.Instance.completeLevel4 = true;
        }
        else if (activeScene.name == "Level 5")
        {
            levelsProgress.Instance.completeLevel5 = true;
        }
        else if (activeScene.name == "Level 6")
        {
            levelsProgress.Instance.completeLevel6 = true;
        }
        else if (activeScene.name == "Level 7")
        {
            levelsProgress.Instance.completeLevel7 = true;
        }
        else if (activeScene.name == "Level 8")
        {
            levelsProgress.Instance.completeLevel8 = true;
        }
        else if (activeScene.name == "Level 9")
        {
            levelsProgress.Instance.completeLevel9 = true;
        }
        else if (activeScene.name == "Level 10")
        {
            levelsProgress.Instance.completeLevel10 = true;
        }
        else if (activeScene.name == "Level 11")
        {
            levelsProgress.Instance.completeLevel11 = true;
        }
        else if (activeScene.name == "Level 12")
        {
            levelsProgress.Instance.completeLevel12 = true;
        }
        else if (activeScene.name == "Level 13")
        {
            levelsProgress.Instance.completeLevel13 = true;
        }
        else if (activeScene.name == "Level 14")
        {
            levelsProgress.Instance.completeLevel14 = true;
        }
        else if (activeScene.name == "Level 15")
        {
            levelsProgress.Instance.completeLevel15 = true;
        }

    }
    bool zone1 = false;
    bool zone2 = false;
    bool zone3 = false;
    bool zone4 = false;
    bool zone5 = false;
    float tolerance = 1.0f;
    private void OnTriggerStay2D(Collider2D collision)
    {
        Scene activeScene = SceneManager.GetActiveScene();
        if (activeScene.name == "Level 1")
        {
            GameObject findZone = GameObject.Find("зона для блока");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 collisionPosition = collision.transform.position;
            if (collisionPosition.y <= findZonePosition.y)
            {
                SceneManager.LoadScene("Level 2");
            }
        }
        else if (activeScene.name == "Level 2")
        {            GameObject findZone = GameObject.Find("зона для блока");
            GameObject findZone2 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(2, 2)");
            Vector2 collisionPosition2 = obj2.transform.position;
            if (Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            GameObject obj = GameObject.Find("объект(1, 2)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2)
            {
                SceneManager.LoadScene("Level 3");
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 3")
        {
            GameObject findZone = GameObject.Find("зона для блока");
            GameObject findZone2 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(2, 3)");
            Vector2 collisionPosition2 = obj2.transform.position;
            if (Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            GameObject obj = GameObject.Find("объект(1, 3)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2)
            {
                SceneManager.LoadScene("Level 4");
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 4")
        {
            GameObject findZone = GameObject.Find("зона для блока");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(2, 4)");
            Vector2 collisionPosition2 = obj2.transform.position;
            if (Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            GameObject obj3 = GameObject.Find("объект(3, 4)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance)
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj = GameObject.Find("объект(1, 4)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3)
            {
                SceneManager.LoadScene("Level 5");
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 5")
        {
            GameObject findZone = GameObject.Find("зона для блока");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(2, 5)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(3, 5)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                            || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj = GameObject.Find("объект(1, 5)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3)
            {

                SceneManager.LoadScene("Level 6");
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 6")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 6)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 6)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                            || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 6)");
            Vector2 collisionPosition4 = obj4.transform.position;
            if (Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
            {
                zone4 = true;
            }
            else zone4 = false;

            GameObject obj = GameObject.Find("объект(2, 6)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4)
            {
                SceneManager.LoadScene("Level 7");
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 7")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            GameObject findZone5 = GameObject.Find("зона для треугольника3");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone5Position = findZone5.transform.position;
            Vector2 findZone5Scale = findZone5.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 7)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 7)");
            Vector2 collisionPosition3 = obj3.transform.position;
            GameObject obj5 = GameObject.Find("объект(5, 7)");
            Vector2 collisionPosition5 = obj5.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone2Position.x) <= tolerance && collisionPosition5.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone3Position.x) <= tolerance && collisionPosition5.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone5Position.x) <= tolerance && collisionPosition2.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone5Position.x) <= tolerance && collisionPosition3.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone5Position.x) <= tolerance && collisionPosition5.x >= findZone5Position.x - findZone3Scale.x - tolerance))
            {
                zone5 = true;
            }
            else
            {
                zone5 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 7)");
            Vector2 collisionPosition4 = obj4.transform.position;
            GameObject obj = GameObject.Find("объект(2, 7)");
            Vector2 collisionPosition = obj.transform.position;
            if ((Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZone4Position.x) <= tolerance && collisionPosition.x >= findZone4Position.x - findZone4Scale.x - tolerance))
            {
                zone4 = true;
            }
            else zone4 = false;

            if ((Mathf.Abs(collisionPosition4.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZonePosition.x) <= tolerance && collisionPosition4.x >= findZonePosition.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZone4Scale.x - tolerance))
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4 && zone5)
            {
                SceneManager.LoadScene("Level 8");
                zone5 = false;
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 8")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            GameObject findZone5 = GameObject.Find("зона для треугольника3");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone5Position = findZone5.transform.position;
            Vector2 findZone5Scale = findZone5.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 8)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 8)");
            Vector2 collisionPosition3 = obj3.transform.position;
            GameObject obj5 = GameObject.Find("объект(5, 8)");
            Vector2 collisionPosition5 = obj5.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone2Position.x) <= tolerance && collisionPosition5.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone3Position.x) <= tolerance && collisionPosition5.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone5Position.x) <= tolerance && collisionPosition2.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone5Position.x) <= tolerance && collisionPosition3.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone5Position.x) <= tolerance && collisionPosition5.x >= findZone5Position.x - findZone3Scale.x - tolerance))
            {
                zone5 = true;
            }
            else
            {
                zone5 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 8)");
            Vector2 collisionPosition4 = obj4.transform.position;
            GameObject obj = GameObject.Find("объект(2, 8)");
            Vector2 collisionPosition = obj.transform.position;
            if ((Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZone4Position.x) <= tolerance && collisionPosition.x >= findZone4Position.x - findZone4Scale.x - tolerance))
            {
                zone4 = true;
            }
            else zone4 = false;

            if ((Mathf.Abs(collisionPosition4.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZonePosition.x) <= tolerance && collisionPosition4.x >= findZonePosition.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZone4Scale.x - tolerance))
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4 && zone5)
            {
                SceneManager.LoadScene("Level 9");
                zone5 = false;
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 9")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            GameObject findZone5 = GameObject.Find("зона для треугольника3");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone5Position = findZone5.transform.position;
            Vector2 findZone5Scale = findZone5.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 9)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 9)");
            Vector2 collisionPosition3 = obj3.transform.position;
            GameObject obj5 = GameObject.Find("объект(5, 9)");
            Vector2 collisionPosition5 = obj5.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone2Position.x) <= tolerance && collisionPosition5.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone3Position.x) <= tolerance && collisionPosition5.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone5Position.x) <= tolerance && collisionPosition2.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone5Position.x) <= tolerance && collisionPosition3.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone5Position.x) <= tolerance && collisionPosition5.x >= findZone5Position.x - findZone3Scale.x - tolerance))
            {
                zone5 = true;
            }
            else
            {
                zone5 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 9)");
            Vector2 collisionPosition4 = obj4.transform.position;
            GameObject obj = GameObject.Find("объект(2, 9)");
            Vector2 collisionPosition = obj.transform.position;
            if ((Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZone4Position.x) <= tolerance && collisionPosition.x >= findZone4Position.x - findZone4Scale.x - tolerance))
            {
                zone4 = true;
            }
            else zone4 = false;

            if ((Mathf.Abs(collisionPosition4.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZonePosition.x) <= tolerance && collisionPosition4.x >= findZonePosition.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZone4Scale.x - tolerance))
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4 && zone5)
            {
                SceneManager.LoadScene("Level 10");
                zone5 = false;
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 10")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            GameObject findZone5 = GameObject.Find("зона для треугольника3");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone5Position = findZone5.transform.position;
            Vector2 findZone5Scale = findZone5.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 10)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 10)");
            Vector2 collisionPosition3 = obj3.transform.position;
            GameObject obj5 = GameObject.Find("объект(5, 10)");
            Vector2 collisionPosition5 = obj5.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone2Position.x) <= tolerance && collisionPosition5.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone3Position.x) <= tolerance && collisionPosition5.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone5Position.x) <= tolerance && collisionPosition2.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone5Position.x) <= tolerance && collisionPosition3.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone5Position.x) <= tolerance && collisionPosition5.x >= findZone5Position.x - findZone3Scale.x - tolerance))
            {
                zone5 = true;
            }
            else
            {
                zone5 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 10)");
            Vector2 collisionPosition4 = obj4.transform.position;
            GameObject obj = GameObject.Find("объект(2, 10)");
            Vector2 collisionPosition = obj.transform.position;
            if ((Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZone4Position.x) <= tolerance && collisionPosition.x >= findZone4Position.x - findZone4Scale.x - tolerance))
            {
                zone4 = true;
            }
            else zone4 = false;

            if ((Mathf.Abs(collisionPosition4.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZonePosition.x) <= tolerance && collisionPosition4.x >= findZonePosition.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZone4Scale.x - tolerance))
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4 && zone5)
            {
                SceneManager.LoadScene("Level 11");
                zone5 = false;
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 11")
        {
            GameObject findZone = GameObject.Find("зона для блока");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(2, 11)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(3, 11)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                            || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj = GameObject.Find("объект(1, 11)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3)
            {
                SceneManager.LoadScene("Level 12");
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 12")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 12)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 12)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                            || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 12)");
            Vector2 collisionPosition4 = obj4.transform.position;
            if (Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
            {
                zone4 = true;
            }
            else zone4 = false;

            GameObject obj = GameObject.Find("объект(2, 12)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4)
            {
                SceneManager.LoadScene("Level 13");
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 13")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 13)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 13)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                            || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 13)");
            Vector2 collisionPosition4 = obj4.transform.position;
            if (Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
            {
                zone4 = true;
            }
            else zone4 = false;

            GameObject obj = GameObject.Find("объект(2, 13)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4)
            {
                SceneManager.LoadScene("Level 14");
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 14")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 14)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 14)");
            Vector2 collisionPosition3 = obj3.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                            || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 14)");
            Vector2 collisionPosition4 = obj4.transform.position;
            if (Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
            {
                zone4 = true;
            }
            else zone4 = false;

            GameObject obj = GameObject.Find("объект(2, 14)");
            Vector2 collisionPosition = obj.transform.position;
            if (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZoneScale.x - tolerance)
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4)
            {
                SceneManager.LoadScene("Level 15");
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
        else if (activeScene.name == "Level 15")
        {
            GameObject findZone4 = GameObject.Find("зона для блока");
            GameObject findZone = GameObject.Find("зона для блока2");
            GameObject findZone2 = GameObject.Find("зона для треугольника2");
            GameObject findZone3 = GameObject.Find("зона для треугольника");
            GameObject findZone5 = GameObject.Find("зона для треугольника3");
            Vector2 findZonePosition = findZone.transform.position;
            Vector2 findZoneScale = findZone.transform.localScale;
            Vector2 findZone4Position = findZone4.transform.position;
            Vector2 findZone4Scale = findZone4.transform.localScale;
            Vector2 findZone5Position = findZone5.transform.position;
            Vector2 findZone5Scale = findZone5.transform.localScale;
            Vector2 findZone2Position = findZone2.transform.position;
            Vector2 findZone2Scale = findZone2.transform.localScale;
            Vector2 findZone3Position = findZone3.transform.position;
            Vector2 findZone3Scale = findZone3.transform.localScale;

            GameObject obj2 = GameObject.Find("объект(3, 15)");
            Vector2 collisionPosition2 = obj2.transform.position;
            GameObject obj3 = GameObject.Find("объект(4, 15)");
            Vector2 collisionPosition3 = obj3.transform.position;
            GameObject obj5 = GameObject.Find("объект(5, 15)");
            Vector2 collisionPosition5 = obj5.transform.position;
            if ((Mathf.Abs(collisionPosition2.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone2Position.x) <= tolerance && collisionPosition2.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone2Position.x) <= tolerance && collisionPosition3.x >= findZone2Position.x - findZone2Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone2Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone2Position.x) <= tolerance && collisionPosition5.x >= findZone2Position.x - findZone2Scale.x - tolerance))
            {
                zone1 = true;
            }
            else
            {
                zone1 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone3Position.x) <= tolerance && collisionPosition2.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone3Position.x) <= tolerance && collisionPosition3.x >= findZone3Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone3Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone3Position.x) <= tolerance && collisionPosition5.x >= findZone3Position.x - findZone3Scale.x - tolerance))
            {
                zone3 = true;
            }
            else
            {
                zone3 = false;
            }
            if ((Mathf.Abs(collisionPosition2.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition2.x - findZone5Position.x) <= tolerance && collisionPosition2.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition3.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition3.x - findZone5Position.x) <= tolerance && collisionPosition3.x >= findZone5Position.x - findZone3Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition5.y - findZone5Position.y) <= tolerance * 2 && Mathf.Abs(collisionPosition5.x - findZone5Position.x) <= tolerance && collisionPosition5.x >= findZone5Position.x - findZone3Scale.x - tolerance))
            {
                zone5 = true;
            }
            else
            {
                zone5 = false;
            }
            GameObject obj4 = GameObject.Find("объект(1, 15)");
            Vector2 collisionPosition4 = obj4.transform.position;
            GameObject obj = GameObject.Find("объект(2, 15)");
            Vector2 collisionPosition = obj.transform.position;
            if ((Mathf.Abs(collisionPosition4.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZone4Position.x) <= tolerance && collisionPosition4.x >= findZone4Position.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZone4Position.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZone4Position.x) <= tolerance && collisionPosition.x >= findZone4Position.x - findZone4Scale.x - tolerance))
            {
                zone4 = true;
            }
            else zone4 = false;

            if ((Mathf.Abs(collisionPosition4.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition4.x - findZonePosition.x) <= tolerance && collisionPosition4.x >= findZonePosition.x - findZone4Scale.x - tolerance)
                || (Mathf.Abs(collisionPosition.y - findZonePosition.y) <= tolerance && Mathf.Abs(collisionPosition.x - findZonePosition.x) <= tolerance && collisionPosition.x >= findZonePosition.x - findZone4Scale.x - tolerance))
            {
                zone2 = true;
            }
            else zone2 = false;

            if (zone1 && zone2 && zone3 && zone4 && zone5)
            {
                SceneManager.LoadScene("LevelsMenu");
                zone5 = false;
                zone4 = false;
                zone3 = false;
                zone2 = false;
                zone1 = false;
            }
        }
    }
}
