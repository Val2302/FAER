using Faer.Src.Views;

using System;
using System.IO;
using System.Windows.Forms;

namespace Faer.Src.Controllers
{
    public class MainController
    {
        #region Fields

        private const int FIRST_FLAG = 0;

        private readonly MainForm View;
        private readonly Array AllFileAttributes;

        private FileAttributes _fileAttributes;
        private CheckBox _fileFlag;
        private string _flagName;
        private string _file;

        #endregion

        #region Constructors

        public MainController(Form view)
        {
            View = view as MainForm;
            AllFileAttributes = Enum.GetValues(typeof(FileAttributes));

            BindEventHandlers();
        }

        #endregion

        #region Methods

        private void BindEventHandlers()
        {
            View.LoadAttributesHandler += LoadAttributes;
            View.SaveAttributesHandler += SaveAttributes;
        }

        public void LoadAttributes()
        {
            if (View.OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                _file = View.OpenFileDialog.FileName;
            }

            _fileAttributes = File.GetAttributes(_file);

            View.FileName.Text = Path.GetFileName(_file);

            View.CreatedDate.Value = File.GetCreationTime(_file);
            View.LastEditedDate.Value = File.GetLastWriteTime(_file);
            View.LastOpenedDate.Value = File.GetLastAccessTime(_file);

            foreach (var attribute in AllFileAttributes)
            {
                _flagName = "cb" + attribute;
                _fileFlag = View.Controls.Find(_flagName, true)[FIRST_FLAG] as CheckBox;
                _fileFlag.Checked = _fileAttributes.HasFlag(attribute as Enum);
            }
        }

        public void SaveAttributes()
        {
            var newFile = Path.GetDirectoryName(_file) + Path.DirectorySeparatorChar + View.FileName.Text;

            _fileAttributes &= ~FileAttributes.ReadOnly;
            File.SetAttributes(newFile, _fileAttributes);

            File.Move(_file, newFile);

            File.SetCreationTime(newFile, View.CreatedDate.Value);
            File.SetLastWriteTime(newFile, View.LastEditedDate.Value);
            File.SetLastAccessTime(newFile, View.LastOpenedDate.Value);

            foreach (var attribute in AllFileAttributes)
            {
                _flagName = "cb" + attribute;
                _fileFlag = View.Controls.Find(_flagName, true)[FIRST_FLAG] as CheckBox;

                if (_fileFlag.Checked)
                {
                    _fileAttributes |= (FileAttributes)attribute;
                }
                else
                {
                    _fileAttributes &= ~(FileAttributes)attribute;
                }
            }

            File.SetAttributes(newFile, _fileAttributes);
        }

        #endregion
    }
}
