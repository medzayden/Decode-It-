using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject); // Détruire l'objet en double
            return;
        }

        instance = this as T;
        DontDestroyOnLoad(gameObject); // Rendre l'objet persistan
    }


}
