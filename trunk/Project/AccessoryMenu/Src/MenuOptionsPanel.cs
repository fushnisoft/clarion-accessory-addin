using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using ICSharpCode.Core;
using ICSharpCode.SharpDevelop;
using ICSharpCode.SharpDevelop.Gui;

namespace Clarion.AccessoryMenu
{
    public partial class MenuOptionsPanel : AbstractOptionPanel
    {
        public MenuOptionsPanel()
        {
            InitializeComponent();
        }

        public override void LoadPanelContents()
        {
            if (PropertyService.Get("Clarion.AccessoryMenu.MenuOptionsPanel.OptionSelected") == "")
            {
                LoggingService.Debug("tesT");
                PropertyService.Set("Clarion.AccessoryMenu.MenuOptionsPanel.OptionSelected", "1");
            }
            int optionSelected = PropertyService.Get("Clarion.AccessoryMenu.MenuOptionsPanel.OptionSelected", 1);
            switch (optionSelected)
            {
                case 1:
                    radioButton1.Checked = true;
                    break;
                case 2:
                    radioButton2.Checked = true;
                    break;
                case 3:
                    radioButton3.Checked = true;
                    break;
            }
        }

        public override bool StorePanelContents()
        {
            if (radioButton1.Checked == true)
                PropertyService.Set("Clarion.AccessoryMenu.MenuOptionsPanel.OptionSelected", "1");

            if (radioButton2.Checked == true)
                PropertyService.Set("Clarion.AccessoryMenu.MenuOptionsPanel.OptionSelected", "2");

            if (radioButton3.Checked == true)
                PropertyService.Set("Clarion.AccessoryMenu.MenuOptionsPanel.OptionSelected", "3");

            return true;
        }
    }
}
