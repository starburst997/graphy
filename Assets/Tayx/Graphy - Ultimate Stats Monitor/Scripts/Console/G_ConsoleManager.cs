/* ---------------------------------------
 * Author: Martin Pane (martintayx@gmail.com) (@tayx94)
 * Project: Graphy - Ultimate Stats Monitor
 * Collaborators:  (mosthated@instance.id) (@MostHated)
 * Date: 08-Oct-18
 * Studio: Tayx
 * This project is released under the MIT license.
 * Attribution is not required, but it is always welcomed!
 * -------------------------------------*/

using UnityEngine;

using System.Collections;

using Tayx.Graphy.UI;

namespace Tayx.Graphy.Console
{
    public class G_ConsoleManager : MonoBehaviour
    {

        #region Private Variables

        private GraphyManager           m_graphyManager;

        private G_ConsoleView           m_consoleView;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            Init();
        }

        private void Start()
        {
            UpdateParameters();
        }

        

        #endregion

        #region Public Methods

        public void UpdateParameters()
        {

        }

        #endregion

        #region Private Methods

        private void Init()
        {
            m_graphyManager = transform.root.GetComponentInChildren<GraphyManager>();

            m_consoleView = GetComponent<G_ConsoleView>();
        }

        #endregion
    }
}