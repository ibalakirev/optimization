using UnityEngine;
using UnityEngine.AddressableAssets;


public class SceneAdd : MonoBehaviour
{
    [SerializeField] private AssetReference _sceneAssetReference;

    private void Start()
    {
        LoadScene();
    }

    public void LoadScene()
    {
        _sceneAssetReference.LoadSceneAsync();
    }
}
