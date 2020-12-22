using UnityEngine;

public class SingletonController : MonoBehaviour
{
    #region Fields

    SingletonController instance = null;

    #endregion


    #region Properties

    public SingletonController Instance 
    {
        get 
        {
            if (instance == null)
            {
                instance = this;
            }
            else if (instance != this)
            {
                Destroy(gameObject);
            }
            Instantiate(gameObject);
            return instance;
        }
    }

    #endregion
}
