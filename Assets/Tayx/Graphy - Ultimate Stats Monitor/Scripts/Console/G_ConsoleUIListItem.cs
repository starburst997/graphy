using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class G_ConsoleUIListItem : MonoBehaviour
{


    #region Private Variables

    [SerializeField]
    private Image m_logTypeImage = null;

    [SerializeField]
    private Text m_logText = null;

    #endregion


    #region Public Methods

    public void SetupUI(Color logTypeImageColor, string logMessage)
    {
        m_logTypeImage.color = logTypeImageColor;
        m_logText.text = logMessage;
    }

    #endregion

}
