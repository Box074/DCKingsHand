
namespace DCKingsHandMod;

class DCKingsHand : ModBase
{
    public static AssetBundle ab;
    public static GameObject kingsHand;
    public override void Initialize()
    {
        ab = LoadAssetBundle("DCKingsHand.ab");
        kingsHand = ab.LoadAsset<GameObject>("KingHand");
        Modding.ModHooks.HeroUpdateHook +=() =>
        {
            if(Input.GetKeyDown(KeyCode.Alpha8))
            {
                var kh = UnityEngine.Object.Instantiate(kingsHand, HeroController.instance.transform.position, Quaternion.identity,
                    null);
                var ctrl = kh.GetComponent<KingHandController>();
                ctrl.target = HeroController.instance.gameObject;
            }
        };
    }
}
