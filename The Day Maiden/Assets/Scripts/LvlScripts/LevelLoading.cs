using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoading : MonoBehaviour
{

    [SerializeField] private int index;

    public void SceneLoad()
    {
        SceneManager.LoadScene(index);
    }
}
