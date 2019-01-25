/* ---------------------------------------
 * Author: Martin Pane (martintayx@gmail.com) (@tayx94)
 * Project: Graphy - Ultimate Stats Monitor
 * Date: 24-Jan-19
 * Studio: Tayx
 * This project is released under the MIT license.
 * Attribution is not required, but it is always welcomed!
 * -------------------------------------*/

using UnityEngine;

using System.Collections;

using Tayx.Graphy.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tayx.Graphy.Console
{
    class G_ConsoleMonitor : MonoBehaviour
    {
        #region Helper Struct

        public struct ConsoleData
        {
            public string   logString;
            public string   stackTrace;
            public LogType  logType;
        }

        #endregion

        #region Private Variables

        private GraphyManager       m_graphyManager;

        [SerializeField]
        [Range(0, 1000)]
        private int                 m_entriesToLog = 200;

        private List<ConsoleData>   m_consoleDataList = new List<ConsoleData>();

        private int                 m_currentIndex = 0;

        #endregion

        #region Unity Methods

        private void Awake()
        {
            Init();
        }

        private void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        private void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
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

            m_consoleDataList = new List<ConsoleData>(m_entriesToLog);

            ConsoleData consoleData = new ConsoleData()
            {
                logString = string.Empty,
                stackTrace = string.Empty,
                logType = LogType.Log
            };

            for (int i = 0; i < m_entriesToLog; i++)
            {
                m_consoleDataList.Add(consoleData);
            }
        }



        private void HandleLog(string logString, string stackTrace, LogType logType)
        {
            ConsoleData data = m_consoleDataList[m_currentIndex];

            data.logString = logString;
            data.stackTrace = logString;
            data.logType = logType;

            m_currentIndex++;
        }

        #endregion
    }
}
