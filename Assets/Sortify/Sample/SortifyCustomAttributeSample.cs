#if UNITY_EDITOR && SORTIFY_ATTRIBUTES
using UnityEngine;

namespace Sortify
{
    public class SortifyCustomAttributeSample : MonoBehaviour
    {
        [Button("Change Bool Button")]
        public bool Button = false;

        [ShowIf("Button", null, true)]
        public string buttonFalse = "This is shown when Button is false.";

        [ShowIf("Button")]
        public string buttonTrue = "This is shown when Button is true.";

        [Space(5)]
        [Message(MessageAttribute.MessageType.Info, "Example info message.")]
        public string InfoMessage = "Info Message";

        [Space(5)]
        [Message(MessageAttribute.MessageType.Warning, "Example warning message.")]
        public string WarningMessage = "Warning Message";

        [Space(5)]
        [Message(MessageAttribute.MessageType.Error, "Example error message.")]
        public string ErrorMessage = "Error Message";

        [Space(5)]
        [MinMaxSlider(0, 1)]
        public Vector2 MinMaxSlider;

        [Space(5)]
        [ReadOnly]
        public float ReadOnly = 5;

        [Space(5)]
        [BetterHeader("Better Header Default")]
        public float BetterHeader_Default;

        [Space(5)]
        [BetterHeader("Better Header Middle Center", 16, TextAnchor.MiddleCenter)]
        public float BetterHeader_MiddleCenter;

        [Space(5)]
        [BetterHeader("Better Header Middle Right", 22, TextAnchor.MiddleRight)]
        public float BetterHeader_MiddleRight;

        [Button("Invoke Methode")]
        public void ButtonMethode()
        {
            Debug.Log("Invoke!");
        }
    }
}
#endif