namespace TasiErrorLabelTool
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TasiErrorLabelTool = this.Factory.CreateRibbonGroup();
            this.errorbox = this.Factory.CreateRibbonEditBox();
            this.addType = this.Factory.CreateRibbonComboBox();
            this.addGroupButton = this.Factory.CreateRibbonButton();
            this.adderrorbutton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.TasiErrorLabelTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TasiErrorLabelTool);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // TasiErrorLabelTool
            // 
            this.TasiErrorLabelTool.Items.Add(this.errorbox);
            this.TasiErrorLabelTool.Items.Add(this.addType);
            this.TasiErrorLabelTool.Items.Add(this.addGroupButton);
            this.TasiErrorLabelTool.Items.Add(this.adderrorbutton);
            this.TasiErrorLabelTool.Label = "TasiErrorLabelTool";
            this.TasiErrorLabelTool.Name = "TasiErrorLabelTool";
            // 
            // errorbox
            // 
            this.errorbox.Label = "Error";
            this.errorbox.Name = "errorbox";
            this.errorbox.Text = null;
            this.errorbox.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.editBox1_TextChanged);
            // 
            // addType
            // 
            ribbonDropDownItemImpl1.Label = "Formula errors";
            ribbonDropDownItemImpl2.Label = "Missing formula errors";
            ribbonDropDownItemImpl3.Label = "Other";
            this.addType.Items.Add(ribbonDropDownItemImpl1);
            this.addType.Items.Add(ribbonDropDownItemImpl2);
            this.addType.Items.Add(ribbonDropDownItemImpl3);
            this.addType.Label = "addType";
            this.addType.Name = "addType";
            this.addType.Text = null;
            this.addType.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.comboBox1_TextChanged);
            // 
            // addGroupButton
            // 
            this.addGroupButton.Label = "addGroup";
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddGroup_Click);
            // 
            // adderrorbutton
            // 
            this.adderrorbutton.Label = "addError";
            this.adderrorbutton.Name = "adderrorbutton";
            this.adderrorbutton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AddErrorCell_Clink);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TasiErrorLabelTool.ResumeLayout(false);
            this.TasiErrorLabelTool.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TasiErrorLabelTool;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox errorbox;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox addType;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton adderrorbutton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton addGroupButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
