using COM3D2_CustomEventEditor.CustomControl.StepEdit;
using COM3D2_CustomEventEditor.Properties;
using CustomControls.RJControls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor
{


    public partial class CustomEventEditor : Form, ILocalizable
    {
        private List<StepEditBase> AllPanels = new List<StepEditBase>();

        private SelectState _SelectState = SelectState.None;
        private ADVStep _CurrentStepData;

        public class ConnectedPair
        {
            public Control Source;
            public Control Target;
        }


        public CustomEventEditor()
        {
            InitializeComponent();

            //TODO: put it in config?
            LoadLanguage("en-US");
            
            this.Load += CustomEventEditor_Load;

            Global.Canvas = MainWorkingCanvas;

            //Enable double buffered for the MainWorkingGrid just in case
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                null, MainWorkingCanvas, new object[] { true });

            InitEntryStep();
            InitPanelData();
            EditAreaStateUpdate();
        }

        private void CustomEventEditor_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            string? formatText = Util.GetResourcesString("AppName");
            if (!string.IsNullOrEmpty(formatText))
                this.Text = String.Format(formatText, Application.ProductVersion);

            Controls.LocalizeCollection();

        }

        private void MenuCharaStep_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.Chara);
        }

        private void MenuTalkStep_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.Talk);
        }

        private void MenuGroupMgmt_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.MakeGroup);
        }

        private void MenuGroupAction_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.GroupMotion);
        }

        private void MenuBackground_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.Background);
        }

        private void MenuCamera_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.Camera);
        }

        private void MenuFadeInOut_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.FadeOut);
        }

        private void MenuEnd_ButtonClicked(object sender, MouseEventArgs e)
        {
            var item = AddNewStep(StepItem.StepType.ADVEnd);
            item.StepData.Name = Util.GetResourcesString("EndPointText");
            item.StepText = item.StepData.Name;
        }

        private void MenuBGM_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.BGM);
        }

        private void MenuSE_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.SE);
        }

        private void MenuWorldObject_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.AddObject);
        }

        private void MenuTextureMgmt_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.AddTexture);
        }

        private void MenuTimeWait_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.TimeSleep);
        }

        private void MenuShowChoices_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.ShowOption);
        }

        private void MenuEvaluate_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.Evaluate);
        }

        private void MenuBranch_ButtonClicked(object sender, MouseEventArgs e)
        {
            AddNewStep(StepItem.StepType.Branch);
        }


        private StepItem AddNewStep(StepItem.StepType stepType)
        {
            StepItem newItem = new StepItem(stepType);
            newItem.StepData.ID = Global.GenerateNewStepID();
            newItem.StepText = newItem.StepData.ID;
            newItem.Location = GetNewStepPoint(newItem);
            newItem.Visible = true;
            newItem.StepSelected += StepItem_StepSelected;
            newItem.ConnectStepFinished += StepItem_ConnectStepFinished;
            MainWorkingCanvas.Controls.Add(newItem);
            newItem.BringToFront();

            Global.AllSteps.Add(newItem);

            return newItem;
        }

        private StepItem AddNewStep(ADVStep stepData)
        {
            StepItem newItem = new StepItem(Util.GetStepType(stepData));
            newItem.StepData = stepData;
            if (!string.IsNullOrEmpty(stepData.Name))
                newItem.StepText = stepData.Name;
            else
                newItem.StepText = stepData.ID;
            newItem.Visible = true;
            newItem.Location = stepData.Location;
            newItem.StepSelected += StepItem_StepSelected;
            newItem.ConnectStepFinished += StepItem_ConnectStepFinished;
            MainWorkingCanvas.Controls.Add(newItem);
            newItem.UpdateConnectionDotStatus();
            Global.AllSteps.Add(newItem);
            newItem.BringToFront();

            return newItem;
        }

        private Point GetNewStepPoint(StepItem item)
        {
            int x = (Global.Canvas.Width - item.Width) / 2;
            int y = (Global.Canvas.Height - item.Height) / 2;

            bool noSameLocation = false;
            Point point = new Point(x, y);
            while (!noSameLocation)
            {
                noSameLocation = Global.AllSteps.Count(x => x.Location == point) == 0;
                if (noSameLocation)
                    return point;
                else
                {
                    point.X += 10;
                    point.Y += 10;
                }
            }

            return point;
        }

        private void InitEntryStep()
        {
            var item = AddNewStep(StepItem.StepType.CharaInit);
            item.Location = new Point((Global.Canvas.Width - item.Width) / 2, Global.Canvas.Top + 5);
            item.StepData.Name = Util.GetResourcesString("StartPointText");
            item.StepText = item.StepData.Name;
        }

        private void InitPanelData()
        {
            AllPanels.Add(EditTalkStep);
            AllPanels.Add(EditCharaInitStep);
            AllPanels.Add(EditCharaStep);
            AllPanels.Add(EditBackgroundStep);
            AllPanels.Add(EditBGMStep);
            AllPanels.Add(EditSEStep);
            AllPanels.Add(EditCameraStep);
            AllPanels.Add(EditFadingStep);
            AllPanels.Add(EditGroupManagementStep);
            AllPanels.Add(EditGroupMotionStep);
            AllPanels.Add(EditWorldObjectStep);
            AllPanels.Add(EditTextureStep);
            AllPanels.Add(EditTimeSleepStep);
            AllPanels.Add(EditShowOptionStep);
            AllPanels.Add(EditEvaluateStep);
            AllPanels.Add(EditBranchingStep);

            AllPanels.Add(EditScenarioOverview);
            AllPanels.Add(EditAdvEndStep);
        }

        private void EditAreaStateUpdate()
        {
            foreach (var item in AllPanels)
                item.Visible = false;

            switch (_SelectState)
            {
                case SelectState.Talk:
                    EditTalkStep.LoadData(_CurrentStepData);
                    EditTalkStep.Visible = true;
                    break;
                case SelectState.CharaInit:
                    EditCharaInitStep.LoadData(_CurrentStepData);
                    EditCharaInitStep.Visible = true;
                    break;
                case SelectState.Chara:
                    EditCharaStep.LoadData(_CurrentStepData);
                    EditCharaStep.Visible = true;
                    break;
                case SelectState.Background:
                    EditBackgroundStep.LoadData(_CurrentStepData);
                    EditBackgroundStep.Visible = true;
                    break;
                case SelectState.BGM:
                    EditBGMStep.LoadData(_CurrentStepData);
                    EditBGMStep.Visible = true;
                    break;
                case SelectState.SE:
                    EditSEStep.LoadData(_CurrentStepData);
                    EditSEStep.Visible = true;
                    break;
                case SelectState.Camera:
                    EditCameraStep.LoadData(_CurrentStepData);
                    EditCameraStep.Visible = true;
                    break;
                case SelectState.FadeOut:
                case SelectState.FadeIn:
                    EditFadingStep.LoadData(_CurrentStepData);
                    EditFadingStep.Visible = true;
                    break;
                case SelectState.MakeGroup:
                case SelectState.DismissGroup:
                    EditGroupManagementStep.LoadData(_CurrentStepData);
                    EditGroupManagementStep.Visible = true;
                    break;
                case SelectState.AddObject:
                case SelectState.RemoveObject:
                    EditWorldObjectStep.LoadData(_CurrentStepData);
                    EditWorldObjectStep.Visible = true;
                    break;
                case SelectState.AddTexture:
                case SelectState.RemoveTexture:
                    EditTextureStep.LoadData(_CurrentStepData);
                    EditTextureStep.Visible = true;
                    break;
                case SelectState.GroupMotion:
                    EditGroupMotionStep.LoadData(_CurrentStepData);
                    EditGroupMotionStep.Visible = true;
                    break;
                case SelectState.TimeSleep:
                    EditTimeSleepStep.LoadData(_CurrentStepData);
                    EditTimeSleepStep.Visible = true;
                    break;
                case SelectState.ShowOption:
                    EditShowOptionStep.LoadData(_CurrentStepData);
                    EditShowOptionStep.Visible = true;
                    break;
                case SelectState.Evaluate:
                    EditEvaluateStep.LoadData(_CurrentStepData);
                    EditEvaluateStep.Visible = true;
                    break;
                case SelectState.Branch:
                    EditBranchingStep.LoadData(_CurrentStepData);
                    EditBranchingStep.Visible = true;
                    break;
                case SelectState.ADVEnd:
                    EditAdvEndStep.LoadData(_CurrentStepData);
                    EditAdvEndStep.Visible = true;
                    break;
                default:
                    EditScenarioOverview.LoadData();
                    EditScenarioOverview.Visible = true;
                    break;
            }
        }

        private void RefreshEditArea()
        {
            foreach (var item in AllPanels)
                if (item.Visible)
                    item.ReloadData();
        }



        private void StepItem_ConnectStepFinished(object? sender, EventArgs e)
        {
            Global.Canvas.IsConnectionDragging = false;

            StepItem currentStep = (StepItem)sender;

            //detect if the target point overlaps with a step
            var mouseLocation = MainWorkingCanvas.PointToClient(Cursor.Position);

            List<StepItem> overlapSteps = new List<StepItem>();
            foreach (var item in Global.AllSteps)
            {
                if (Util.IsWithinControl(item, mouseLocation))
                    overlapSteps.Add(item);
            }

            int minIndex = 999999;
            StepItem bottomItem = null;
            foreach (var step in overlapSteps)
            {
                int index = step.Parent.Controls.GetChildIndex(step);
                if (index < minIndex)
                {
                    minIndex = index;
                    bottomItem = step;
                }

            }



            if (bottomItem != null && currentStep != bottomItem)
            {
                if (bottomItem.Type == StepItem.StepType.CharaInit)
                {
                    //should never connect to start point, do nothing
                }
                else if (currentStep.Type != StepItem.StepType.Branch)
                {
                    //For non branch step, there is only one connection
                    currentStep.SetConnection(bottomItem);
                    RefreshEditArea();
                }
                else
                {
                    //Branch type, the number of connection depends on number of branch
                }
            }

            Global.Canvas.Redraw();
        }

        private void StepItem_StepSelected(object? sender, StepItem.StepType stepType)
        {
            ResetsStepState(sender);
            UpdateSelectState(sender, stepType);
            EditAreaStateUpdate();
            Global.Canvas.DeselectLine();
        }
        private void MainWorkingGrid_MouseDown(object sender, MouseEventArgs e)
        {
            //Call for validation before perform any changes
            if (!ValidateChildren())
                return;

            ResetsStepState(sender);
            Global.Canvas.DeselectLine();

            bool isLineSelected = false;
            foreach (var step in Global.AllSteps)
            {
                foreach (var c in step.StepData.ConnectionList)
                {
                    var targetStep = Global.AllSteps.Where(x => x.StepData.ID == c.TargetStepID).FirstOrDefault();

                    if (targetStep != null)
                    {
                        Point source = step.GetBorderPoint(c.From);
                        Point target = targetStep.GetBorderPoint(c.To);
                        bool isTouch = Util.IsWithinLine(source, target, e.Location, 0.1);

                        if (isTouch)
                        {
                            Global.Canvas.SetSelectedLine(step, targetStep, c.From, c.To);
                            isLineSelected = true;

                        }
                    }
                }
            }
            Global.Canvas.Redraw();

            if (isLineSelected)
            {
                //TODO: line selected behaviour
            }
            else
            {
                _SelectState = SelectState.None;
                EditAreaStateUpdate();
            }
        }

        private void ResetsStepState(object? sender)
        {
            foreach (var step in Global.AllSteps)
                if (step != sender)
                    step.SetState(StepItem.State.Normal);
        }


        private void LoadLanguage(string lang)
        {
            CultureInfo.CurrentCulture = new CultureInfo(lang);

            this.Localize();
            RecurLoadLanguage(this);
        }

        
        private void RecurLoadLanguage(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is ILocalizable)
                    ((ILocalizable)c).Localize();

                if (c.Controls.Count > 0)
                    RecurLoadLanguage(c);
            }
        }


        private void MainWorkingGrid_Paint(object sender, PaintEventArgs e)
        {
            Global.Canvas.DrawConnectedLines(e.Graphics);
        }

        private void CustomEventEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Global.Canvas.HandleDeleteKey();

            }
        }

        private void UpdateSelectState(object? sender, StepItem.StepType stepType)
        {
            StepItem step = sender as StepItem;
            _CurrentStepData = step.StepData;

            switch (stepType)
            {
                case StepItem.StepType.Chara:
                    _SelectState = SelectState.Chara; break;
                case StepItem.StepType.Talk:
                    _SelectState = SelectState.Talk; break;
                case StepItem.StepType.CharaInit:
                    _SelectState = SelectState.CharaInit; break;
                case StepItem.StepType.Background:
                    _SelectState = SelectState.Background; break;
                case StepItem.StepType.BGM:
                    _SelectState = SelectState.BGM; break;
                case StepItem.StepType.SE:
                    _SelectState = SelectState.SE; break;
                case StepItem.StepType.Camera:
                    _SelectState = SelectState.Camera; break;
                case StepItem.StepType.FadeOut:
                    _SelectState = SelectState.FadeOut; break;
                case StepItem.StepType.FadeIn:
                    _SelectState = SelectState.FadeIn; break;
                case StepItem.StepType.MakeGroup:
                    _SelectState = SelectState.MakeGroup; break;
                case StepItem.StepType.DismissGroup:
                    _SelectState = SelectState.DismissGroup; break;
                case StepItem.StepType.GroupMotion:
                    _SelectState = SelectState.GroupMotion; break;
                case StepItem.StepType.AddObject:
                    _SelectState = SelectState.AddObject; break;
                case StepItem.StepType.RemoveObject:
                    _SelectState = SelectState.RemoveObject; break;
                case StepItem.StepType.AddTexture:
                    _SelectState = SelectState.AddTexture; break;
                case StepItem.StepType.RemoveTexture:
                    _SelectState = SelectState.RemoveTexture; break;
                case StepItem.StepType.TimeSleep:
                    _SelectState = SelectState.TimeSleep; break;
                case StepItem.StepType.ShowOption:
                    _SelectState = SelectState.ShowOption; break;
                case StepItem.StepType.Evaluate:
                    _SelectState = SelectState.Evaluate; break;
                case StepItem.StepType.Branch:
                    _SelectState = SelectState.Branch; break;
                case StepItem.StepType.ADVEnd:
                    _SelectState = SelectState.ADVEnd; break;
                default:
                    _SelectState = SelectState.None; break;
            }
        }

        private void CustomEventEditor_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = MessageBox.Show(Util.GetResourcesString("CloseAppMessage"),
                                           Text,
                                           MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void TopMenuLanguage_ButtonClicked(object sender, MouseEventArgs e)
        {
            TopMenuLanguageDropDown.Show(TopMenuLanguage, new Point(0, 64));
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLanguage("en-US");
        }

        private void tchineseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLanguage("zh-TW");
        }


        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //scroll the canvas to top left
            Global.ScenarioDefinition.EditorScrollPosition = new Point(Global.Canvas.HorizontalScroll.Value, Global.Canvas.VerticalScroll.Value);

            Global.Canvas.HorizontalScroll.Value = 0;
            Global.Canvas.VerticalScroll.Value = 0;

            //Update info before save
            foreach (var step in Global.AllSteps)
            {
                step.StepData.Location = step.Location;
                step.StepData.Type = Util.GetADVStepType(step.Type);
            }
            var initStep = Global.AllSteps.Where(x => x.Type == StepItem.StepType.CharaInit).First();

            Global.ScenarioDefinition.RunningNumber = Global.StepIDRunningNumber;
            Global.ScenarioDefinition.EntryStep = initStep.StepData.ID;
            EditorFileManager.Save(((SaveFileDialog)sender).FileName);

            //restore the scroll position
            UpdateScrollingPosition();
            UpdateScrollingPosition();
        }

        private void TopMenuSave_ButtonClicked(object sender, MouseEventArgs e)
        {
            if (!ValidateChildren())
                return;
            var panel = AllPanels.Where(x => x.Visible).FirstOrDefault();
            if (panel != null)
                panel.SaveData();

            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            bool result = EditorFileManager.Load(((OpenFileDialog)sender).FileName, out Dictionary<string, ADVStep> loadedSteps);
            if (result)
            {
                //clear existing data
                foreach (var step in Global.AllSteps)
                    step.Dispose();
                Global.AllSteps.Clear();
                Global.AllSteps = new List<StepItem>();

                //convert the data into memory
                foreach (var kvp in loadedSteps)
                {
                    AddNewStep(kvp.Value);
                }
                Global.StepIDRunningNumber = Global.ScenarioDefinition.RunningNumber;
                EditScenarioOverview.ReloadData();

                //Reset the UI
                ResetsStepState(sender);
                Global.Canvas.DeselectLine();
                _SelectState = SelectState.None;
                EditAreaStateUpdate();

                Invalidate();

                UpdateScrollingPosition();
            }
        }

        private void UpdateScrollingPosition()
        {
            //if x or y equals to 0, the scroll to original position after saving will not work. Make it to be at least 1 for a temp fix.
            int x = Math.Max(Global.ScenarioDefinition.EditorScrollPosition.X, 1);
            int y = Math.Max(Global.ScenarioDefinition.EditorScrollPosition.Y, 1);

            //This hack of set the value twice is needed to make sure the scrollbar position is updated visually
            Global.Canvas.HorizontalScroll.Value = Global.Canvas.HorizontalScroll.Value = x;
            Global.Canvas.VerticalScroll.Value = Global.Canvas.VerticalScroll.Value = y;
        }

        private void TopMenuLoad_ButtonClicked(object sender, MouseEventArgs e)
        {
            //warn the user that the current work will be lost
            var result = MessageBox.Show(Util.GetResourcesString("OpenFileWarning"),
                                           Text,
                                           MessageBoxButtons.YesNo) == DialogResult.Yes;
            //if ok
            if (result)
                openFileDialog.ShowDialog();
        }

        private void TopMenuNew_ButtonClicked(object sender, MouseEventArgs e)
        {
            //warn the user that the current work will be lost
            var result = MessageBox.Show(Util.GetResourcesString("NewWarning"),
                                           Text,
                                           MessageBoxButtons.YesNo) == DialogResult.Yes;

            if (result)
            {
                //clear existing data
                foreach (var step in Global.AllSteps)
                    step.Dispose();
                Global.ScenarioDefinition = new ScenarioDefinition();
                Global.AllSteps.Clear();
                Global.AllSteps = new List<StepItem>();
                Global.StepIDRunningNumber = Global.ScenarioDefinition.RunningNumber;

                EditScenarioOverview.ReloadData();

                //Add Init Step
                InitEntryStep();

                //Reset the UI
                ResetsStepState(sender);
                Global.Canvas.DeselectLine();
                _SelectState = SelectState.None;
                EditAreaStateUpdate();
                UpdateScrollingPosition();

                Invalidate();
                Global.Canvas.Redraw();
            }
        }

        private void TopMenuDelete_ButtonClicked(object sender, MouseEventArgs e)
        {
            //Remove the selected step from memory
            if (_SelectState != SelectState.None && _SelectState != SelectState.CharaInit && _CurrentStepData != null)
            {
                var stepToRemove = Global.AllSteps.Where(x => x.StepData.ID == _CurrentStepData.ID).FirstOrDefault();
                if (stepToRemove != null)
                {
                    //disconnect any step that connect to this step
                    foreach (var step in Global.AllSteps)
                        step.RemoveConnectionByTarget(stepToRemove);


                    //remove from memory
                    Global.AllSteps.Remove(stepToRemove);
                    stepToRemove.Dispose();
                }

            }

            //refresh the canvas
            Global.Canvas.Redraw();
        }

        private void TopMenuClone_ButtonClicked(object sender, MouseEventArgs e)
        {
            if (_SelectState != SelectState.None && _SelectState != SelectState.CharaInit && _CurrentStepData != null)
            {
                //clone the ADVStep variable
                var serialized = JsonConvert.SerializeObject(_CurrentStepData);
                var cloned = JsonConvert.DeserializeObject<ADVStep>(serialized);

                //Update the data of the cloned step data
                cloned.ID = Global.GenerateNewStepID();
                cloned.NextStepID = "";
                cloned.ConnectionList = new List<ADVStep.GraphConnection>();


                //create a new SpteItem with the cloned var
                var clonedStepItem = AddNewStep(cloned);
                clonedStepItem.Location = GetNewStepPoint(clonedStepItem);

                //refresh the canvas
                Global.Canvas.Redraw();
            }
        }

        private enum SelectState
        {
            None,
            Talk,
            Chara,
            CharaInit,
            Background,
            BGM,
            SE,
            Camera,
            FadeIn,
            FadeOut,
            MakeGroup,
            DismissGroup,
            GroupMotion,
            AddObject,
            RemoveObject,
            AddTexture,
            RemoveTexture,
            TimeSleep,
            ShowOption,
            Evaluate,
            Branch,
            ADVEnd,
            Line
        }
    }
}
