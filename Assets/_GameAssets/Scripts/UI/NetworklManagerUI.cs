using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworklManagerUI : MonoBehaviour
{
    [SerializeField] private Button _startHostButton;
    [SerializeField] private Button _startClientButton;

    private void Awake()
    {
        _startClientButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartClient();
            Hide();
        });

        _startHostButton.onClick.AddListener(() =>
        {
            NetworkManager.Singleton.StartHost();
            Hide();
        });
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
