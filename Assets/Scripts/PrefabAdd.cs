using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class PrefabAdd : MonoBehaviour
{
    [SerializeField] private AssetReference _prefabAssetReference;

    private async void Start()
    {
        AsyncOperationHandle<GameObject> handle = _prefabAssetReference.LoadAssetAsync<GameObject>();

        await handle.Task;

        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            GameObject prefabAssetReference = handle.Result;

            Instantiate(prefabAssetReference);

            Addressables.Release(handle);
        }
    }

    /*private void Start()
    {
        _prefabAssetReference.InstantiateAsync();
    }*/
}
