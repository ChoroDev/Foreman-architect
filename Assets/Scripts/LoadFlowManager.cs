using UnityEngine;

public class LoadFlowManager : MonoBehaviour
{
    #region Fields

    [SerializeField] GUIManagement gUIManagement;
    [SerializeField] 

    #endregion


    #region Unity lifecycle

    void Start()
    {
        GUIManagement gUIManagementInstance = (GUIManagement)gUIManagement.Instance;
        gUIManagementInstance.InitGUI();
    }

    #endregion
}
