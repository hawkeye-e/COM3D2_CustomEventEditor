using COM3D2_CustomEventEditor.CustomControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor
{
    partial class CustomEventEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(CustomEventEditor));
            MenuBackground = new AddStepButton();
            MenuGroupMgmt = new AddStepButton();
            MenuGroupAction = new AddStepButton();
            MenuTalkStep = new AddStepButton();
            MenuCharaStep = new AddStepButton();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            MenuBranch = new AddStepButton();
            MenuEnd = new AddStepButton();
            MenuEvaluate = new AddStepButton();
            MenuFadeInOut = new AddStepButton();
            MenuTimeWait = new AddStepButton();
            MenuTextureMgmt = new AddStepButton();
            MenuWorldObject = new AddStepButton();
            MenuSE = new AddStepButton();
            MenuBGM = new AddStepButton();
            MenuCamera = new AddStepButton();
            MenuShowChoices = new AddStepButton();
            DataEditingPanel = new Panel();
            EditBranchingStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.BranchingStep();
            EditEvaluateStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.EvaluateStep();
            EditShowOptionStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.ShowOptionStep();
            EditTimeSleepStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.TimeSleepStep();
            EditTextureStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.TextureStep();
            EditWorldObjectStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.WorldObjectStep();
            EditGroupMotionStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.GroupMotionStep();
            EditGroupManagementStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.GroupManagementStep();
            EditSEStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.SEStep();
            EditBGMStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.BGMStep();
            EditAdvEndStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.ADVEndStep();
            EditFadingStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.FadingStep();
            EditCameraStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.CameraStep();
            EditBackgroundStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.BackgroundStep();
            EditCharaStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.CharaStep();
            EditCharaInitStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.CharaInitStep();
            EditTalkStep = new COM3D2_CustomEventEditor.CustomControl.StepEdit.TalkStep();
            EditScenarioOverview = new COM3D2_CustomEventEditor.CustomControl.StepEdit.ScenarioInfo();
            MainWorkingCanvas = new Canvas(components);
            panel5 = new Panel();
            TopMenuLanguage = new MenuButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            TopMenuLoad = new MenuButton();
            TopMenuSave = new MenuButton();
            TopMenuNew = new MenuButton();
            TopMenuClone = new MenuButton();
            TopMenuDelete = new MenuButton();
            TopMenuLanguageDropDown = new CustomControls.RJControls.RJDropdownMenu(components);
            englishToolStripMenuItem = new ToolStripMenuItem();
            tchineseToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            DataEditingPanel.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            TopMenuLanguageDropDown.SuspendLayout();
            SuspendLayout();
            // 
            // MenuBackground
            // 
            MenuBackground.AccessibleDescription = "";
            MenuBackground.BackColor = Color.FromArgb(51, 51, 77);
            MenuBackground.ButtonText = "Background";
            MenuBackground.Icon = Properties.Resources.background;
            MenuBackground.Location = new Point(3, 255);
            MenuBackground.Name = "MenuBackground";
            MenuBackground.Size = new Size(206, 36);
            MenuBackground.TabIndex = 4;
            MenuBackground.TextResourceKey = "MenuBackgroundText";
            MenuBackground.ButtonClicked += MenuBackground_ButtonClicked;
            // 
            // MenuGroupMgmt
            // 
            MenuGroupMgmt.BackColor = Color.FromArgb(51, 51, 77);
            MenuGroupMgmt.ButtonText = "Group Management";
            MenuGroupMgmt.Icon = Properties.Resources.group_mgmt;
            MenuGroupMgmt.Location = new Point(3, 87);
            MenuGroupMgmt.Name = "MenuGroupMgmt";
            MenuGroupMgmt.Size = new Size(206, 36);
            MenuGroupMgmt.TabIndex = 3;
            MenuGroupMgmt.TextResourceKey = "MenuGroupManagementText";
            MenuGroupMgmt.ButtonClicked += MenuGroupMgmt_ButtonClicked;
            // 
            // MenuGroupAction
            // 
            MenuGroupAction.BackColor = Color.FromArgb(51, 51, 77);
            MenuGroupAction.ButtonText = "Group Action";
            MenuGroupAction.Icon = Properties.Resources.group_action;
            MenuGroupAction.Location = new Point(3, 129);
            MenuGroupAction.Name = "MenuGroupAction";
            MenuGroupAction.Size = new Size(206, 36);
            MenuGroupAction.TabIndex = 2;
            MenuGroupAction.TextResourceKey = "MenuGroupActionText";
            MenuGroupAction.ButtonClicked += MenuGroupAction_ButtonClicked;
            // 
            // MenuTalkStep
            // 
            MenuTalkStep.BackColor = Color.FromArgb(51, 51, 77);
            MenuTalkStep.ButtonText = "Talk";
            MenuTalkStep.Icon = Properties.Resources.talk;
            MenuTalkStep.Location = new Point(3, 45);
            MenuTalkStep.Name = "MenuTalkStep";
            MenuTalkStep.Size = new Size(206, 36);
            MenuTalkStep.TabIndex = 1;
            MenuTalkStep.TextResourceKey = "MenuTalkStepText";
            MenuTalkStep.ButtonClicked += MenuTalkStep_ButtonClicked;
            // 
            // MenuCharaStep
            // 
            MenuCharaStep.BackColor = Color.FromArgb(51, 51, 77);
            MenuCharaStep.ButtonText = "Character";
            MenuCharaStep.Icon = Properties.Resources.person;
            MenuCharaStep.Location = new Point(3, 3);
            MenuCharaStep.Name = "MenuCharaStep";
            MenuCharaStep.Size = new Size(206, 36);
            MenuCharaStep.TabIndex = 0;
            MenuCharaStep.TextResourceKey = "MenuCharaStepText";
            MenuCharaStep.ButtonClicked += MenuCharaStep_ButtonClicked;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 77);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 64);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(51, 51, 77);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(MenuCharaStep, 0, 0);
            tableLayoutPanel1.Controls.Add(MenuGroupAction, 0, 3);
            tableLayoutPanel1.Controls.Add(MenuGroupMgmt, 0, 2);
            tableLayoutPanel1.Controls.Add(MenuTalkStep, 0, 1);
            tableLayoutPanel1.Controls.Add(MenuBranch, 0, 4);
            tableLayoutPanel1.Controls.Add(MenuEnd, 0, 15);
            tableLayoutPanel1.Controls.Add(MenuEvaluate, 0, 14);
            tableLayoutPanel1.Controls.Add(MenuFadeInOut, 0, 13);
            tableLayoutPanel1.Controls.Add(MenuTimeWait, 0, 12);
            tableLayoutPanel1.Controls.Add(MenuTextureMgmt, 0, 11);
            tableLayoutPanel1.Controls.Add(MenuWorldObject, 0, 10);
            tableLayoutPanel1.Controls.Add(MenuSE, 0, 9);
            tableLayoutPanel1.Controls.Add(MenuBGM, 0, 8);
            tableLayoutPanel1.Controls.Add(MenuCamera, 0, 7);
            tableLayoutPanel1.Controls.Add(MenuShowChoices, 0, 5);
            tableLayoutPanel1.Controls.Add(MenuBackground, 0, 6);
            tableLayoutPanel1.Location = new Point(0, 63);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(212, 799);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MenuBranch
            // 
            MenuBranch.AccessibleDescription = "";
            MenuBranch.BackColor = Color.FromArgb(51, 51, 77);
            MenuBranch.ButtonText = "Branching";
            MenuBranch.Icon = Properties.Resources.branching;
            MenuBranch.Location = new Point(3, 171);
            MenuBranch.Name = "MenuBranch";
            MenuBranch.Size = new Size(206, 36);
            MenuBranch.TabIndex = 10;
            MenuBranch.TextResourceKey = "MenuBranchText";
            MenuBranch.ButtonClicked += MenuBranch_ButtonClicked;
            // 
            // MenuEnd
            // 
            MenuEnd.BackColor = Color.FromArgb(51, 51, 77);
            MenuEnd.ButtonText = "ADV End";
            MenuEnd.Icon = Properties.Resources.stop;
            MenuEnd.Location = new Point(3, 633);
            MenuEnd.Name = "MenuEnd";
            MenuEnd.Size = new Size(206, 36);
            MenuEnd.TabIndex = 14;
            MenuEnd.TextResourceKey = "MenuEndText";
            MenuEnd.ButtonClicked += MenuEnd_ButtonClicked;
            // 
            // MenuEvaluate
            // 
            MenuEvaluate.BackColor = Color.FromArgb(51, 51, 77);
            MenuEvaluate.ButtonText = "Evaluate";
            MenuEvaluate.Icon = Properties.Resources.eval;
            MenuEvaluate.Location = new Point(3, 591);
            MenuEvaluate.Name = "MenuEvaluate";
            MenuEvaluate.Size = new Size(206, 36);
            MenuEvaluate.TabIndex = 13;
            MenuEvaluate.TextResourceKey = "MenuEvaluateText";
            MenuEvaluate.ButtonClicked += MenuEvaluate_ButtonClicked;
            // 
            // MenuFadeInOut
            // 
            MenuFadeInOut.BackColor = Color.FromArgb(51, 51, 77);
            MenuFadeInOut.ButtonText = "Fade In / Fade Out";
            MenuFadeInOut.Icon = Properties.Resources.curtain_open;
            MenuFadeInOut.Location = new Point(3, 549);
            MenuFadeInOut.Name = "MenuFadeInOut";
            MenuFadeInOut.Size = new Size(206, 36);
            MenuFadeInOut.TabIndex = 12;
            MenuFadeInOut.TextResourceKey = "MenuFadeInFadeOutText";
            MenuFadeInOut.ButtonClicked += MenuFadeInOut_ButtonClicked;
            // 
            // MenuTimeWait
            // 
            MenuTimeWait.BackColor = Color.FromArgb(51, 51, 77);
            MenuTimeWait.ButtonText = "Time Sleep";
            MenuTimeWait.Icon = Properties.Resources.time_wait;
            MenuTimeWait.Location = new Point(3, 507);
            MenuTimeWait.Name = "MenuTimeWait";
            MenuTimeWait.Size = new Size(206, 36);
            MenuTimeWait.TabIndex = 11;
            MenuTimeWait.TextResourceKey = "MenuTimeWaitText";
            MenuTimeWait.ButtonClicked += MenuTimeWait_ButtonClicked;
            // 
            // MenuTextureMgmt
            // 
            MenuTextureMgmt.BackColor = Color.FromArgb(51, 51, 77);
            MenuTextureMgmt.ButtonText = "Texture";
            MenuTextureMgmt.Icon = Properties.Resources.texture_mgmt;
            MenuTextureMgmt.Location = new Point(3, 465);
            MenuTextureMgmt.Name = "MenuTextureMgmt";
            MenuTextureMgmt.Size = new Size(206, 36);
            MenuTextureMgmt.TabIndex = 9;
            MenuTextureMgmt.TextResourceKey = "MenuTextureManagementText";
            MenuTextureMgmt.ButtonClicked += MenuTextureMgmt_ButtonClicked;
            // 
            // MenuWorldObject
            // 
            MenuWorldObject.BackColor = Color.FromArgb(51, 51, 77);
            MenuWorldObject.ButtonText = "World Object";
            MenuWorldObject.Icon = Properties.Resources.object_mgmt;
            MenuWorldObject.Location = new Point(3, 423);
            MenuWorldObject.Name = "MenuWorldObject";
            MenuWorldObject.Size = new Size(206, 36);
            MenuWorldObject.TabIndex = 8;
            MenuWorldObject.TextResourceKey = "MenuWorldObjectText";
            MenuWorldObject.ButtonClicked += MenuWorldObject_ButtonClicked;
            // 
            // MenuSE
            // 
            MenuSE.BackColor = Color.FromArgb(51, 51, 77);
            MenuSE.ButtonText = "Sound Effect";
            MenuSE.Icon = Properties.Resources.se;
            MenuSE.Location = new Point(3, 381);
            MenuSE.Name = "MenuSE";
            MenuSE.Size = new Size(206, 36);
            MenuSE.TabIndex = 6;
            MenuSE.TextResourceKey = "MenuSEText";
            MenuSE.ButtonClicked += MenuSE_ButtonClicked;
            // 
            // MenuBGM
            // 
            MenuBGM.BackColor = Color.FromArgb(51, 51, 77);
            MenuBGM.ButtonText = "BGM";
            MenuBGM.Icon = Properties.Resources.bgm;
            MenuBGM.Location = new Point(3, 339);
            MenuBGM.Name = "MenuBGM";
            MenuBGM.Size = new Size(206, 36);
            MenuBGM.TabIndex = 5;
            MenuBGM.TextResourceKey = "MenuBGMText";
            MenuBGM.ButtonClicked += MenuBGM_ButtonClicked;
            // 
            // MenuCamera
            // 
            MenuCamera.BackColor = Color.FromArgb(51, 51, 77);
            MenuCamera.ButtonText = "Camera";
            MenuCamera.Icon = Properties.Resources.camera;
            MenuCamera.Location = new Point(3, 297);
            MenuCamera.Name = "MenuCamera";
            MenuCamera.Size = new Size(206, 36);
            MenuCamera.TabIndex = 7;
            MenuCamera.TextResourceKey = "MenuCameraText";
            MenuCamera.ButtonClicked += MenuCamera_ButtonClicked;
            // 
            // MenuShowChoices
            // 
            MenuShowChoices.AccessibleDescription = "";
            MenuShowChoices.BackColor = Color.FromArgb(51, 51, 77);
            MenuShowChoices.ButtonText = "Show Choices";
            MenuShowChoices.Icon = Properties.Resources.question;
            MenuShowChoices.Location = new Point(3, 213);
            MenuShowChoices.Name = "MenuShowChoices";
            MenuShowChoices.Size = new Size(206, 36);
            MenuShowChoices.TabIndex = 15;
            MenuShowChoices.TextResourceKey = "MenuShowChoices";
            MenuShowChoices.ButtonClicked += MenuShowChoices_ButtonClicked;
            // 
            // DataEditingPanel
            // 
            DataEditingPanel.AutoScroll = true;
            DataEditingPanel.AutoScrollMinSize = new Size(293, 0);
            DataEditingPanel.BackColor = Color.FromArgb(207, 221, 238);
            DataEditingPanel.Controls.Add(EditBranchingStep);
            DataEditingPanel.Controls.Add(EditEvaluateStep);
            DataEditingPanel.Controls.Add(EditShowOptionStep);
            DataEditingPanel.Controls.Add(EditTimeSleepStep);
            DataEditingPanel.Controls.Add(EditTextureStep);
            DataEditingPanel.Controls.Add(EditWorldObjectStep);
            DataEditingPanel.Controls.Add(EditGroupMotionStep);
            DataEditingPanel.Controls.Add(EditGroupManagementStep);
            DataEditingPanel.Controls.Add(EditSEStep);
            DataEditingPanel.Controls.Add(EditBGMStep);
            DataEditingPanel.Controls.Add(EditAdvEndStep);
            DataEditingPanel.Controls.Add(EditFadingStep);
            DataEditingPanel.Controls.Add(EditCameraStep);
            DataEditingPanel.Controls.Add(EditBackgroundStep);
            DataEditingPanel.Controls.Add(EditCharaStep);
            DataEditingPanel.Controls.Add(EditCharaInitStep);
            DataEditingPanel.Controls.Add(EditTalkStep);
            DataEditingPanel.Controls.Add(EditScenarioOverview);
            DataEditingPanel.Location = new Point(1248, 63);
            DataEditingPanel.Name = "DataEditingPanel";
            DataEditingPanel.Size = new Size(336, 799);
            DataEditingPanel.TabIndex = 2;
            // 
            // EditBranchingStep
            // 
            EditBranchingStep.AutoScroll = true;
            EditBranchingStep.AutoSize = true;
            EditBranchingStep.Location = new Point(3, 3);
            EditBranchingStep.Name = "EditBranchingStep";
            EditBranchingStep.Size = new Size(290, 629);
            EditBranchingStep.TabIndex = 26;
            // 
            // EditEvaluateStep
            // 
            EditEvaluateStep.AutoScroll = true;
            EditEvaluateStep.AutoSize = true;
            EditEvaluateStep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditEvaluateStep.Location = new Point(3, 3);
            EditEvaluateStep.Name = "EditEvaluateStep";
            EditEvaluateStep.Size = new Size(290, 1301);
            EditEvaluateStep.TabIndex = 25;
            // 
            // EditShowOptionStep
            // 
            EditShowOptionStep.AutoScroll = true;
            EditShowOptionStep.AutoSize = true;
            EditShowOptionStep.Location = new Point(3, 3);
            EditShowOptionStep.Name = "EditShowOptionStep";
            EditShowOptionStep.Size = new Size(290, 629);
            EditShowOptionStep.TabIndex = 24;
            // 
            // EditTimeSleepStep
            // 
            EditTimeSleepStep.AutoScroll = true;
            EditTimeSleepStep.AutoSize = true;
            EditTimeSleepStep.Location = new Point(3, 3);
            EditTimeSleepStep.Name = "EditTimeSleepStep";
            EditTimeSleepStep.Size = new Size(290, 629);
            EditTimeSleepStep.TabIndex = 23;
            // 
            // EditTextureStep
            // 
            EditTextureStep.AutoScroll = true;
            EditTextureStep.AutoSize = true;
            EditTextureStep.Location = new Point(3, 3);
            EditTextureStep.Name = "EditTextureStep";
            EditTextureStep.Size = new Size(290, 784);
            EditTextureStep.TabIndex = 22;
            // 
            // EditWorldObjectStep
            // 
            EditWorldObjectStep.AutoScroll = true;
            EditWorldObjectStep.AutoSize = true;
            EditWorldObjectStep.Location = new Point(3, 3);
            EditWorldObjectStep.Name = "EditWorldObjectStep";
            EditWorldObjectStep.Size = new Size(290, 707);
            EditWorldObjectStep.TabIndex = 21;
            // 
            // EditGroupMotionStep
            // 
            EditGroupMotionStep.AutoSize = true;
            EditGroupMotionStep.Location = new Point(3, 3);
            EditGroupMotionStep.Name = "EditGroupMotionStep";
            EditGroupMotionStep.Size = new Size(290, 743);
            EditGroupMotionStep.TabIndex = 20;
            // 
            // EditGroupManagementStep
            // 
            EditGroupManagementStep.AutoScroll = true;
            EditGroupManagementStep.AutoSize = true;
            EditGroupManagementStep.Location = new Point(3, 3);
            EditGroupManagementStep.Name = "EditGroupManagementStep";
            EditGroupManagementStep.Size = new Size(290, 707);
            EditGroupManagementStep.TabIndex = 19;
            // 
            // EditSEStep
            // 
            EditSEStep.AutoScroll = true;
            EditSEStep.AutoSize = true;
            EditSEStep.Location = new Point(3, 3);
            EditSEStep.Name = "EditSEStep";
            EditSEStep.Size = new Size(290, 629);
            EditSEStep.TabIndex = 18;
            // 
            // EditBGMStep
            // 
            EditBGMStep.AutoScroll = true;
            EditBGMStep.AutoSize = true;
            EditBGMStep.Location = new Point(3, 3);
            EditBGMStep.Name = "EditBGMStep";
            EditBGMStep.Size = new Size(290, 629);
            EditBGMStep.TabIndex = 17;
            // 
            // EditAdvEndStep
            // 
            EditAdvEndStep.AutoScroll = true;
            EditAdvEndStep.AutoSize = true;
            EditAdvEndStep.Location = new Point(3, 3);
            EditAdvEndStep.Name = "EditAdvEndStep";
            EditAdvEndStep.Size = new Size(290, 629);
            EditAdvEndStep.TabIndex = 16;
            // 
            // EditFadingStep
            // 
            EditFadingStep.AutoScroll = true;
            EditFadingStep.AutoSize = true;
            EditFadingStep.Location = new Point(3, 3);
            EditFadingStep.Name = "EditFadingStep";
            EditFadingStep.Size = new Size(290, 629);
            EditFadingStep.TabIndex = 15;
            // 
            // EditCameraStep
            // 
            EditCameraStep.AutoScroll = true;
            EditCameraStep.AutoSize = true;
            EditCameraStep.Location = new Point(3, 3);
            EditCameraStep.Name = "EditCameraStep";
            EditCameraStep.Size = new Size(290, 789);
            EditCameraStep.TabIndex = 14;
            // 
            // EditBackgroundStep
            // 
            EditBackgroundStep.AutoScroll = true;
            EditBackgroundStep.AutoSize = true;
            EditBackgroundStep.Location = new Point(3, 3);
            EditBackgroundStep.Name = "EditBackgroundStep";
            EditBackgroundStep.Size = new Size(290, 629);
            EditBackgroundStep.TabIndex = 13;
            // 
            // EditCharaStep
            // 
            EditCharaStep.AutoSize = true;
            EditCharaStep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditCharaStep.Location = new Point(3, 3);
            EditCharaStep.Name = "EditCharaStep";
            EditCharaStep.Size = new Size(290, 867);
            EditCharaStep.TabIndex = 12;
            // 
            // EditCharaInitStep
            // 
            EditCharaInitStep.AutoScroll = true;
            EditCharaInitStep.AutoSize = true;
            EditCharaInitStep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditCharaInitStep.Location = new Point(3, 3);
            EditCharaInitStep.Name = "EditCharaInitStep";
            EditCharaInitStep.Size = new Size(290, 629);
            EditCharaInitStep.TabIndex = 11;
            // 
            // EditTalkStep
            // 
            EditTalkStep.AutoScroll = true;
            EditTalkStep.AutoSize = true;
            EditTalkStep.Location = new Point(3, 3);
            EditTalkStep.Name = "EditTalkStep";
            EditTalkStep.Size = new Size(290, 1043);
            EditTalkStep.TabIndex = 10;
            EditTalkStep.Visible = false;
            // 
            // EditScenarioOverview
            // 
            EditScenarioOverview.AutoScroll = true;
            EditScenarioOverview.AutoScrollMinSize = new Size(0, 300);
            EditScenarioOverview.AutoSize = true;
            EditScenarioOverview.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditScenarioOverview.Location = new Point(6, 9);
            EditScenarioOverview.Name = "EditScenarioOverview";
            EditScenarioOverview.Size = new Size(307, 656);
            EditScenarioOverview.TabIndex = 0;
            EditScenarioOverview.Visible = false;
            // 
            // MainWorkingCanvas
            // 
            MainWorkingCanvas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainWorkingCanvas.AutoScroll = true;
            MainWorkingCanvas.AutoScrollMargin = new Size(200, 200);
            MainWorkingCanvas.BackgroundImage = Properties.Resources.grid;
            MainWorkingCanvas.IsConnectionDragging = false;
            MainWorkingCanvas.Location = new Point(216, 70);
            MainWorkingCanvas.Name = "MainWorkingCanvas";
            MainWorkingCanvas.Size = new Size(1026, 779);
            MainWorkingCanvas.TabIndex = 3;
            MainWorkingCanvas.Paint += MainWorkingGrid_Paint;
            MainWorkingCanvas.MouseDown += MainWorkingGrid_MouseDown;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(24, 104, 170);
            panel5.Controls.Add(TopMenuLanguage);
            panel5.Controls.Add(tableLayoutPanel2);
            panel5.Location = new Point(212, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1374, 64);
            panel5.TabIndex = 4;
            // 
            // TopMenuLanguage
            // 
            TopMenuLanguage.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuLanguage.ButtonText = "Language";
            TopMenuLanguage.Icon = Properties.Resources.menu_language;
            TopMenuLanguage.Location = new Point(1208, 0);
            TopMenuLanguage.Margin = new Padding(0);
            TopMenuLanguage.Name = "TopMenuLanguage";
            TopMenuLanguage.Size = new Size(100, 64);
            TopMenuLanguage.TabIndex = 3;
            TopMenuLanguage.TextResourceKey = "TopMenuLanguage";
            TopMenuLanguage.ButtonClicked += TopMenuLanguage_ButtonClicked;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(TopMenuLoad, 2, 0);
            tableLayoutPanel2.Controls.Add(TopMenuSave, 1, 0);
            tableLayoutPanel2.Controls.Add(TopMenuNew, 0, 0);
            tableLayoutPanel2.Controls.Add(TopMenuClone, 4, 0);
            tableLayoutPanel2.Controls.Add(TopMenuDelete, 5, 0);
            tableLayoutPanel2.Location = new Point(64, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(669, 64);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // TopMenuLoad
            // 
            TopMenuLoad.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuLoad.ButtonText = "Load";
            TopMenuLoad.Icon = Properties.Resources.menu_load;
            TopMenuLoad.Location = new Point(200, 0);
            TopMenuLoad.Margin = new Padding(0);
            TopMenuLoad.Name = "TopMenuLoad";
            TopMenuLoad.Size = new Size(100, 64);
            TopMenuLoad.TabIndex = 2;
            TopMenuLoad.TextResourceKey = "TopMenuLoad";
            TopMenuLoad.ButtonClicked += TopMenuLoad_ButtonClicked;
            // 
            // TopMenuSave
            // 
            TopMenuSave.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuSave.ButtonText = "Save";
            TopMenuSave.Icon = Properties.Resources.menu_save;
            TopMenuSave.Location = new Point(100, 0);
            TopMenuSave.Margin = new Padding(0);
            TopMenuSave.Name = "TopMenuSave";
            TopMenuSave.Size = new Size(100, 64);
            TopMenuSave.TabIndex = 1;
            TopMenuSave.TextResourceKey = "TopMenuSave";
            TopMenuSave.ButtonClicked += TopMenuSave_ButtonClicked;
            // 
            // TopMenuNew
            // 
            TopMenuNew.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuNew.ButtonText = "New";
            TopMenuNew.Icon = Properties.Resources.menu_new;
            TopMenuNew.Location = new Point(0, 0);
            TopMenuNew.Margin = new Padding(0);
            TopMenuNew.Name = "TopMenuNew";
            TopMenuNew.Size = new Size(100, 64);
            TopMenuNew.TabIndex = 0;
            TopMenuNew.TextResourceKey = "TopMenuNew";
            TopMenuNew.ButtonClicked += TopMenuNew_ButtonClicked;
            // 
            // TopMenuClone
            // 
            TopMenuClone.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuClone.ButtonText = "Clone Step";
            TopMenuClone.Icon = Properties.Resources.clone;
            TopMenuClone.Location = new Point(350, 0);
            TopMenuClone.Margin = new Padding(0);
            TopMenuClone.Name = "TopMenuClone";
            TopMenuClone.Size = new Size(100, 64);
            TopMenuClone.TabIndex = 3;
            TopMenuClone.TextResourceKey = "TopMenuClone";
            TopMenuClone.ButtonClicked += TopMenuClone_ButtonClicked;
            // 
            // TopMenuDelete
            // 
            TopMenuDelete.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuDelete.ButtonText = "Delete Step";
            TopMenuDelete.Icon = Properties.Resources.bin;
            TopMenuDelete.Location = new Point(450, 0);
            TopMenuDelete.Margin = new Padding(0);
            TopMenuDelete.Name = "TopMenuDelete";
            TopMenuDelete.Size = new Size(100, 64);
            TopMenuDelete.TabIndex = 4;
            TopMenuDelete.TextResourceKey = "TopMenuDelete";
            TopMenuDelete.ButtonClicked += TopMenuDelete_ButtonClicked;
            // 
            // TopMenuLanguageDropDown
            // 
            TopMenuLanguageDropDown.BackColor = Color.FromArgb(24, 104, 170);
            TopMenuLanguageDropDown.Font = new Font("Microsoft Sans Serif", 9F);
            TopMenuLanguageDropDown.IsMainMenu = false;
            TopMenuLanguageDropDown.Items.AddRange(new ToolStripItem[] { englishToolStripMenuItem, tchineseToolStripMenuItem });
            TopMenuLanguageDropDown.MenuItemHeight = 25;
            TopMenuLanguageDropDown.MenuItemTextColor = Color.Empty;
            TopMenuLanguageDropDown.Name = "TopMenuLanguageDropDown";
            TopMenuLanguageDropDown.PrimaryColor = Color.Empty;
            TopMenuLanguageDropDown.Size = new Size(123, 48);
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.BackColor = SystemColors.Control;
            englishToolStripMenuItem.ForeColor = Color.White;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(122, 22);
            englishToolStripMenuItem.Text = "English";
            englishToolStripMenuItem.Click += englishToolStripMenuItem_Click;
            // 
            // tchineseToolStripMenuItem
            // 
            tchineseToolStripMenuItem.BackColor = SystemColors.Control;
            tchineseToolStripMenuItem.ForeColor = Color.White;
            tchineseToolStripMenuItem.Name = "tchineseToolStripMenuItem";
            tchineseToolStripMenuItem.Size = new Size(122, 22);
            tchineseToolStripMenuItem.Text = "繁體中文";
            tchineseToolStripMenuItem.Click += tchineseToolStripMenuItem_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.DefaultExt = "zip";
            saveFileDialog.Filter = "Zip Files|*.zip";
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "zip";
            openFileDialog.Filter = "Zip Files|*.zip";
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // CustomEventEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1584, 861);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel5);
            Controls.Add(MainWorkingCanvas);
            Controls.Add(DataEditingPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "CustomEventEditor";
            Text = "Custom Event Editor";
            FormClosing += CustomEventEditor_FormClosing;
            KeyDown += CustomEventEditor_KeyDown;
            tableLayoutPanel1.ResumeLayout(false);
            DataEditingPanel.ResumeLayout(false);
            DataEditingPanel.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            TopMenuLanguageDropDown.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel DataEditingPanel;
        private Panel panel5;
        private AddStepButton MenuCharaStep;
        private AddStepButton MenuTalkStep;
        private AddStepButton MenuGroupAction;
        private AddStepButton MenuGroupMgmt;
        private AddStepButton MenuBackground;
        private TableLayoutPanel tableLayoutPanel1;
        private AddStepButton MenuSE;
        private AddStepButton MenuBGM;
        private AddStepButton MenuBranch;
        private AddStepButton MenuCamera;
        private AddStepButton MenuTextureMgmt;
        private AddStepButton MenuWorldObject;
        private AddStepButton MenuTimeWait;
        private AddStepButton MenuEnd;
        private AddStepButton MenuEvaluate;
        private AddStepButton MenuFadeInOut;
        private Canvas MainWorkingCanvas;
        private CustomControl.StepEdit.ScenarioInfo EditScenarioOverview;
        private CustomControl.StepEdit.TalkStep EditTalkStep;
        private TableLayoutPanel tableLayoutPanel2;
        private MenuButton TopMenuNew;
        private MenuButton TopMenuSave;
        private MenuButton TopMenuLoad;
        private MenuButton TopMenuLanguage;
        private CustomControls.RJControls.RJDropdownMenu TopMenuLanguageDropDown;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem tchineseToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private CustomControl.StepEdit.CharaInitStep EditCharaInitStep;
        private CustomControl.StepEdit.CharaStep EditCharaStep;
        private CustomControl.StepEdit.BackgroundStep EditBackgroundStep;
        private CustomControl.StepEdit.CameraStep EditCameraStep;
        private CustomControl.StepEdit.FadingStep EditFadingStep;
        private CustomControl.StepEdit.ADVEndStep EditAdvEndStep;
        private CustomControl.StepEdit.BGMStep EditBGMStep;
        private CustomControl.StepEdit.SEStep EditSEStep;
        private CustomControl.StepEdit.GroupManagementStep EditGroupManagementStep;
        private AddStepButton MenuShowChoices;
        private CustomControl.StepEdit.GroupMotionStep EditGroupMotionStep;
        private CustomControl.StepEdit.WorldObjectStep EditWorldObjectStep;
        private CustomControl.StepEdit.TextureStep EditTextureStep;
        private CustomControl.StepEdit.TimeSleepStep EditTimeSleepStep;
        private CustomControl.StepEdit.ShowOptionStep EditShowOptionStep;
        private CustomControl.StepEdit.EvaluateStep EditEvaluateStep;
        private CustomControl.StepEdit.BranchingStep EditBranchingStep;
        private MenuButton TopMenuClone;
        private MenuButton TopMenuDelete;
    }
}
