using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class SpriteAdd : MonoBehaviour
{
    [SerializeField] private AssetReference _sprite; //Загружаемый объект
    [SerializeField] private Image _image; //Место, куда надо его загрузить

    private async void Start()
    {
        AsyncOperationHandle<Sprite> handle = _sprite.LoadAssetAsync<Sprite>();

        await handle.Task;

        if(handle.Status == AsyncOperationStatus.Succeeded)
        {
            Sprite newSprite = handle.Result;

            _image.sprite = newSprite;

            Addressables.Release(handle);
        }
    }
}
