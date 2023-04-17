using Eplan.EplApi.DataModel;
using Eplan.EplApi.HEServices;
using Eplan.EplApi.DataModel.Planning;
using Eplan.EplApi.DataModel.MasterData;

using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using ComboBox = System.Windows.Forms.ComboBox;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;
using System.Windows;

namespace Eplan.EplAddin.First_v0003.API
{
    public partial class IgorshemForm : Form
    {
        private Label labelDefenceType;
        private Label labelDefenceSetting;
        private Label labelNumber;
        private Label labelStartType;
        private Label labelTerminal;
        private Label labelPower;
        private ComboBox ComboDefenceType;
        private TextBox TextDefenceSetting;
        private ComboBox ComboNumber;
        private ComboBox ComboStartType;
        private CheckBox CheckTerminal;
        private TextBox TextPower;
        private Button ButtonGenerate;
        private string TextDefenceSettingStr;
        private string TextPowerStr;

        public IgorshemForm()
        {
            InitializeComponent();
        }

        #region
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelDefenceType = new Label();
            this.labelDefenceSetting = new Label();
            this.labelNumber = new Label();
            this.labelStartType = new Label();
            this.labelTerminal = new Label();
            this.labelPower = new Label();
            this.ComboDefenceType = new ComboBox();
            this.TextDefenceSetting = new TextBox();
            this.ComboNumber = new ComboBox();
            this.ComboStartType = new ComboBox();
            this.CheckTerminal = new CheckBox();
            this.TextPower = new TextBox();
            this.ButtonGenerate = new Button();
            this.SuspendLayout();

            //
            //ButtonGenerate
            this.ButtonGenerate.Location = new System.Drawing.Point(31, 294);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(310, 35);
            this.ButtonGenerate.TabIndex = 7;
            this.ButtonGenerate.Text = "Генерировать";
            this.ButtonGenerate.UseVisualStyleBackColor = true;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);

            //
            //TextPower
            this.TextPower.Location = new System.Drawing.Point(160, 241);
            this.TextPower.Name = "TextPower";
            this.TextPower.Size = new System.Drawing.Size(180, 25);
            this.TextPower.TabIndex = 6;
            this.TextPower.TextChanged += new System.EventHandler(this.TextPower_TextChanged);

            //
            //CheckTerminal
            this.CheckTerminal.AutoSize = true;
            this.CheckTerminal.Checked = true;
            this.CheckTerminal.Location = new System.Drawing.Point(160, 204);
            this.CheckTerminal.Name = "CheckTerminal";
            this.CheckTerminal.Size = new System.Drawing.Size(62, 17);
            this.CheckTerminal.TabIndex = 5;
            this.CheckTerminal.Text = "";
            this.CheckTerminal.UseVisualStyleBackColor = true;

            //
            //ComboStartType
            this.ComboStartType.Name = "ComboStartType";
            this.ComboStartType.DropDownWidth = 180;
            this.ComboStartType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboStartType.Items.AddRange(new object[] {
                "DOL",
                "RDOL"});
            this.ComboStartType.Location = new System.Drawing.Point(160, 153);
            this.ComboStartType.Size = new System.Drawing.Size(180, 25);
            this.ComboStartType.TabIndex = 4;
            this.ComboStartType.SelectedIndex = 0;

            //
            //ComboNumber
            this.ComboNumber.Name = "ComboNumber";
            this.ComboNumber.DropDownWidth = 180;
            this.ComboNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboNumber.Items.AddRange(new object[] {
                "3RV1021-4AA15",
                "3RV1021-1JA15",
                "3RV1021-1GA15"});
            this.ComboNumber.Location = new System.Drawing.Point(160, 109);
            this.ComboNumber.Size = new System.Drawing.Size(180, 25);
            this.ComboNumber.TabIndex = 3;
            this.ComboNumber.SelectedIndex = 0;

            //
            //TextDefenceSetting
            this.TextDefenceSetting.Location = new System.Drawing.Point(160, 67);
            this.TextDefenceSetting.Name = "TextDefenceSetting";
            this.TextDefenceSetting.Size = new System.Drawing.Size(180, 25);
            this.TextDefenceSetting.TabIndex = 2;
            this.TextDefenceSetting.TextChanged += new System.EventHandler(this.TextDefenceSetting_TextChanged);

            //
            //ComboDefenceType
            this.ComboDefenceType.Name = "ComboDefenceType";
            this.ComboDefenceType.DropDownWidth = 180;
            this.ComboDefenceType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ComboDefenceType.Items.AddRange(new object[] {
                "Автоматический выключатель",
                "Предохранители"});
            this.ComboDefenceType.Location = new System.Drawing.Point(160, 24);
            this.ComboDefenceType.Size = new System.Drawing.Size(180, 25);
            this.ComboDefenceType.TabIndex = 1;
            this.ComboDefenceType.SelectedIndex = 0;

            //
            // labelPower
            this.labelPower.AutoSize = true;
            this.labelPower.Location = new System.Drawing.Point(31, 248);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(153, 29);
            this.labelPower.Text = "Мотор Ном.мощность ";

            //
            // labelTerminal
            this.labelTerminal.AutoSize = true;
            this.labelTerminal.Location = new System.Drawing.Point(31, 161);
            this.labelTerminal.Name = "labelTerminal";
            this.labelTerminal.Size = new System.Drawing.Size(73, 29);
            this.labelTerminal.Text = "Клеммы ";

            //
            // labelStartType
            this.labelStartType.AutoSize = true;
            this.labelStartType.Location = new System.Drawing.Point(31, 203);
            this.labelStartType.Name = "labelStartType";
            this.labelStartType.Size = new System.Drawing.Size(62, 29);
            this.labelStartType.Text = "Тип пуска";

            //
            // labelNumber
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(31, 114);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(86, 29);
            this.labelNumber.Text = "Заказной номер";

            //
            // labelDefenceSetting
            this.labelDefenceSetting.AutoSize = true;
            this.labelDefenceSetting.Location = new System.Drawing.Point(31, 74);
            this.labelDefenceSetting.Name = "labelDefenceSetting";
            this.labelDefenceSetting.Size = new System.Drawing.Size(11, 29);
            this.labelDefenceSetting.Text = "Уставка защиты";

            //
            // labelDefenceType
            this.labelDefenceType.AutoSize = true;
            this.labelDefenceType.Location = new System.Drawing.Point(31, 29);
            this.labelDefenceType.Name = "labelDefenceType";
            this.labelDefenceType.Size = new System.Drawing.Size(86, 29);
            this.labelDefenceType.Text = "Тип защиты";

            // 
            // IgorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 360);
            Controls.Add(this.labelDefenceType);
            Controls.Add(this.labelDefenceSetting);
            Controls.Add(this.labelNumber);
            Controls.Add(this.labelStartType);
            Controls.Add(this.labelTerminal);
            Controls.Add(this.labelPower);
            Controls.Add(this.ComboDefenceType);
            Controls.Add(this.TextDefenceSetting);
            Controls.Add(this.ComboNumber);
            Controls.Add(this.ComboStartType);
            Controls.Add(this.CheckTerminal);
            Controls.Add(this.TextPower);
            Controls.Add(this.ButtonGenerate);
            this.Name = "UserControl1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        protected void TextPower_TextChanged(object sender, System.EventArgs e)
        {
            if (IsDigitsOnly(TextPower.Text))
            {
                TextPowerStr = TextPower.Text;
            }
            else
            {
                TextPower.Text = TextPowerStr;
            }
        }

        protected void TextDefenceSetting_TextChanged(object sender, System.EventArgs e)
        {
            if (IsDigitsOnly(TextDefenceSetting.Text))
            {
                TextDefenceSettingStr = TextDefenceSetting.Text;
            }
            else
            {
                TextDefenceSetting.Text = TextDefenceSettingStr;
            }
        }

        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        Project pProject;
        private Page CreateNewPage(string newPageName, bool bWithWindow=true)
        {
            PagePropertyList oPPL = new PagePropertyList();
            pProject = new SelectionSet().GetCurrentProject(bWithWindow);
            if (pProject == null)
            {
                System.Windows.Forms.MessageBox.Show("Нет выбранного / открытого проекта");
                return null;
            }
            string input = Interaction.InputBox("В проект [" + pProject.ProjectName + "] добавить лист: ",
                       "Добавляем лист:",
                       newPageName);
            oPPL.PAGE_COUNTER = input;
            try
            {
                return new Page(pProject, DocumentTypeManager.DocumentType.Circuit, oPPL);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Лист с именем <" + input + "> уже существует в текущем проекте.");
                return null;
            }
        }

        Page oPage;

        private void ButtonGenerate_Click(object sender, System.EventArgs e)
        {
            oPage = CreateNewPage("TestPageName", true);
            if (oPage == null)
            {
                return;
            }
            CreateDefenceType();
            this.Close();
        }
        private void CreateDefenceType()
        {
            if (this.ComboDefenceType.Text == "Автоматический выключатель") {
                try {
                    string[] ConnDesignation = new string[6];
                    ConnDesignation[0] = "1/L1";
                    ConnDesignation[1] = "2/T1";
                    ConnDesignation[2] = "3/L2";
                    ConnDesignation[3] = "4/T2";
                    ConnDesignation[4] = "5/L3";
                    ConnDesignation[5] = "6/T3";
                    Point Coords = new Point(60, 250);
                    PageAssignFunction(pProject, oPage, "IEC_symbol", "QL3", 1, "-Q1", ConnDesignation, Coords);
                } catch {
                    return;
                }
            } else {//"Предохранители"
                try
                {
                    string[] ConnDesignation = new string[6];
                    ConnDesignation[0] = "1";
                    ConnDesignation[1] = "2";
                    ConnDesignation[2] = "3";
                    ConnDesignation[3] = "4";
                    ConnDesignation[4] = "5";
                    ConnDesignation[5] = "6";
                    Point Coords = new Point(60, 250);
                    PageAssignFunction(pProject, oPage, "IEC_symbol", "FLTR3", 1, "-F1", ConnDesignation, Coords);
                }
                catch
                {
                    return;
                }
            }
        }

        private void PageAssignFunction(Project pProject, Page oPage, string LibName, string SymbName, int nVar, 
            string FuncName, string[] ConnDesignation, System.Windows.Point Coords)
        {
            try
            {
                SymbolLibrary oSymbolLibrary = new SymbolLibrary(pProject, LibName);
                Symbol oSymbol = new Symbol(oSymbolLibrary, SymbName);
                SymbolVariant oSymbolVariant = new SymbolVariant();
                oSymbolVariant.Initialize(oSymbol, nVar);
                Function oNewFunction = new Function();
                oNewFunction.Create(oPage, oSymbolVariant);
                oNewFunction.Name = FuncName;
                oNewFunction.VisibleName = FuncName;
                for (int i = 0; i < ConnDesignation.Length; i++)
                    oNewFunction.Properties.FUNC_CONNECTIONDESIGNATION[i + 1] = ConnDesignation[i];
                oNewFunction.Location = new EplApi.Base.PointD(Coords.X, Coords.Y);
            }
            catch
            {
                return;
            }
        }
    }
}
