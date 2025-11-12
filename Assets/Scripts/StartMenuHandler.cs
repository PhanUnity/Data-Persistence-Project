using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // TextMeshPro

public class StartMenuHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        if (!string.IsNullOrEmpty(nameInput.text))
        {
            MainManager.Instance.PlayerName = nameInput.text;
            PlayerPrefs.SetString("PlayerName", nameInput.text);
            SceneManager.LoadScene("main"); // đổi thành tên Scene game chính
        }
        else
        {
            Debug.Log("Please enter a name!");
        }
    }
}