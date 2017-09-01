using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlaUIRecorder.Internal
{
    public class MRUManager
    {

        private string _programName;
        private string _subKeyName;
        private ToolStripMenuItem _parentMenuItem;

        private Action<object, EventArgs> _onRecentFileClick;
        private Action<object, EventArgs> _onClearRecentFilesClick;

        public MRUManager(ToolStripMenuItem parentMenuItem, string nameOfProgram, Action<object, EventArgs> onRecentFileClick, Action<object, EventArgs> onClearRecentFilesClick = null)
        {
            if (parentMenuItem == null || onRecentFileClick == null ||
                nameOfProgram == null || nameOfProgram.Length == 0 || nameOfProgram.Contains("\\"))
                throw new ArgumentException("Bad argument.");

            _parentMenuItem = parentMenuItem;
            _programName = nameOfProgram;
            _onRecentFileClick = onRecentFileClick;
            _onClearRecentFilesClick = onClearRecentFilesClick;
            _subKeyName = string.Format("Software\\{0}\\MRU", this._programName);

            _refreshRecentFilesMenu();
        }

        private void _onClearRecentFiles_Click(object obj, EventArgs evt)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_subKeyName, true);
                if (registryKey == null)
                    return;

                string[] values = registryKey.GetValueNames();
                foreach (string valueName in values)
                    registryKey.DeleteValue(valueName, true);

                registryKey.Close();

                _parentMenuItem.DropDownItems.Clear();
                _parentMenuItem.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (_onClearRecentFilesClick != null)
                _onClearRecentFilesClick(obj, evt);
        }

        private void _refreshRecentFilesMenu()
        {
            RegistryKey registryKey;
            string s;
            ToolStripItem menuItem;

            try
            {
                registryKey = Registry.CurrentUser.OpenSubKey(_subKeyName, false);
                if (registryKey == null)
                {
                    _parentMenuItem.Enabled = false;
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot open recent files registry key:\n" + ex.ToString());
                return;
            }

            _parentMenuItem.DropDownItems.Clear();
            string[] valueNames = registryKey.GetValueNames();
            foreach (string valueName in valueNames)
            {
                s = registryKey.GetValue(valueName, null) as string;
                if (s == null)
                    continue;

                menuItem = this._parentMenuItem.DropDownItems.Add(s);
                menuItem.Click += new EventHandler(_onRecentFileClick);
            }

            if (_parentMenuItem.DropDownItems.Count == 0)
            {
                _parentMenuItem.Enabled = false;
                return;
            }

            this._parentMenuItem.DropDownItems.Add("-");
            menuItem = this._parentMenuItem.DropDownItems.Add("Clear list");
            menuItem.Click += new EventHandler(this._onClearRecentFiles_Click);
            this._parentMenuItem.Enabled = true;
        }
       

        #region Public members
        public void AddRecentFile(string fileNameWithFullPath)
        {
            string s;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(_subKeyName, RegistryKeyPermissionCheck.ReadWriteSubTree);
                for (int i = 0; true; i++)
                {
                    s = registryKey.GetValue(i.ToString(), null) as string;
                    if (s == null)
                    {
                        registryKey.SetValue(i.ToString(), fileNameWithFullPath);
                        registryKey.Close();
                        break;
                    }
                    else if (s == fileNameWithFullPath)
                    {
                        registryKey.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            _refreshRecentFilesMenu();
        }

        public void RemoveRecentFile(string fileNameWithFullPath)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(_subKeyName, true);
                string[] valuesNames = registryKey.GetValueNames();
                foreach (string valueName in valuesNames)
                {
                    if ((registryKey.GetValue(valueName, null) as string) == fileNameWithFullPath)
                    {
                        registryKey.DeleteValue(valueName, true);
                        _refreshRecentFilesMenu();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            _refreshRecentFilesMenu();
        }
        #endregion
    
    }
}
