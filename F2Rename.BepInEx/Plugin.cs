using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Il2CppInterop.Runtime;
using Polytoria.Controllers;
using Polytoria.Datamodel;
using RLD;
using UnityEngine;
using GUI = UnityEngine.GUI;

namespace F2Rename.BepInEx
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static new ManualLogSource Log;
        private RenameUI comp;

        public override void Load()
        {
            // Plugin startup logic
            Log = base.Log;
            Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
            comp = AddComponent<RenameUI>();
        }
    }

    public class RenameUI : MonoBehaviour
    {
        internal string name = "";
        internal bool inputEnabled = false;
        internal bool justOpened = false;
        internal Instance instance;

        public UnityEngine.UI.InputField inputField;

        private void Start()
        {
            // find global canvas
            var canvas = GameObject.Find("Canvas");

            // create input field
            var inputFieldGO = new GameObject("InputField");
            inputFieldGO.transform.SetParent(canvas.transform);
            inputField = inputFieldGO.AddComponent<UnityEngine.UI.InputField>();
            inputField.textComponent = inputFieldGO.AddComponent<UnityEngine.UI.Text>();
            inputField.textComponent.font = Font.CreateDynamicFontFromOSFont("Arial", 14);
            inputField.textComponent.fontSize = 14;
            inputField.textComponent.color = Color.black;
            inputField.textComponent.alignment = TextAnchor.MiddleCenter;
            inputField.textComponent.text = "Enter new name";
            inputField.text = "Enter new name";

            // set input field size
            var rectTransform = inputFieldGO.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(200, 30);
            rectTransform.anchoredPosition = new Vector2(0, 0);
            rectTransform.localScale = new Vector2(
                1f / canvas.transform.localScale.x,
                1f / canvas.transform.localScale.y
            );
            rectTransform.localPosition = new Vector2(
                rectTransform.localPosition.x / canvas.transform.localScale.x,
                rectTransform.localPosition.y / canvas.transform.localScale.y
            );
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F2))
            {
                Plugin.Log.LogInfo("F2 pressed");
                var instances = MonoSingleton<RTObjectSelection>.Get.SelectedObjects;
                if (instances.Count != 1) return;

                Plugin.Log.LogInfo("1 instance selected, showing change name ui");
                instance = instances[0].GetComponent<Instance>();
                name = instance.Name;


            }
        }
    }
}
