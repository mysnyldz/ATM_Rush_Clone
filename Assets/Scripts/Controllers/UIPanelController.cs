using System;
using System.Collections.Generic;
using Enums;
using Managers;
using UnityEngine;

namespace Controllers
{
    [Serializable]
    public class UIPanelController 
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private List<GameObject> panels;

        #endregion

        #endregion

        public void OpenPanel(UIPanels panelParam)
        {
            panels[(int) panelParam].SetActive(true);
        }

        public void ClosePanel(UIPanels panelParam)
        {
            panels[(int) panelParam].SetActive(false);
        }
    }
}