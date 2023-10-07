using static Faer.Src.Utils.Utils;

using System;
using System.Windows.Forms;

namespace Faer.Src.Views
{
    public partial class MainForm : Form
    {
        #region Properties

        public OpenFileDialog OpenFileDialog => openFileDialog;

        public TextBox FileName => tbFileName;

        public DateTimePicker CreatedDate => dtpCreatedDate;
        public DateTimePicker LastEditedDate => dtpLastEditedDate;
        public DateTimePicker LastOpenedDate => dtpLastOpenedDate;

        #endregion

        #region Events

        public event Action LoadAttributesHandler;
        public event Action SaveAttributesHandler;

        #endregion

        #region

        delegate void Message();

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();

            openFileDialog.InitialDirectory = Application.ExecutablePath;

            dtpCreatedDate.Value = DateTime.Now.Date;
            dtpLastEditedDate.Value = DateTime.Now.Date;
            dtpLastOpenedDate.Value = DateTime.Now.Date;
        }

        #endregion

        #region Methods

        private bool IsValidateForm ()
        {
            return IsWrittenName(tbFileName)
                && IsWrittenDate(dtpCreatedDate)
                && IsWrittenDate(dtpLastEditedDate)
                && IsWrittenDate(dtpLastOpenedDate);
        }

        private void LoadAttributes ( )
        {
            LoadAttributesHandler();
            btnSave.Enabled = true;
        }

        private void SaveAttributes ( )
        {
            if (IsValidateForm())
            {
                SaveAttributesHandler();
            }
        }

        #endregion

        #region EventHandlers

        private void BtnOpen_Click( object sender, EventArgs e )
        {
            LoadAttributes();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveAttributes();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ( !e.Control ) return;

            if (e.KeyCode == Keys.O)
                LoadAttributes();

            if ( e.KeyCode == Keys.S || e.KeyCode == Keys.Enter) { }
                SaveAttributes();
        }

        #endregion
    }
}
