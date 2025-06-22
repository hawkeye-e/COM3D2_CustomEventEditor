using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using static COM3D2_CustomEventEditor.StepItem;

namespace COM3D2_CustomEventEditor
{
    internal class Util
    {
        public static bool IsWithinControl(Control ctrl, Point point)
        {
            Debug.WriteLine("Control: (" + ctrl.Location + "), point: " + point);

            if ((ctrl.Location.X <= point.X && ctrl.Location.X + ctrl.Width >= point.X)
                && (ctrl.Location.Y <= point.Y && ctrl.Location.Y + ctrl.Height >= point.Y)
                )
                return true;
            else
                return false;

        }

        //Find the distance of point P from both the line end points A, B. If AB = AP + PB, then P lies on the line segment AB.
        //Ref: https://stackoverflow.com/questions/7050186/find-if-point-lies-on-line-segment
        public static bool IsWithinLine(Point pointA, Point pointB, Point pointP, double allowDifference)
        {
            double AB = GetDistance(pointA, pointB);
            double AP = GetDistance(pointA, pointP);
            double PB = GetDistance(pointB, pointP);


            if (Math.Abs(AB - AP - PB) <= allowDifference)
                return true;
            else
                return false;
        }

        public static double GetDistance(Point pt1, Point pt2)
        {
            return Math.Sqrt( (pt2.X - pt1.X) * (pt2.X - pt1.X) + (pt2.Y - pt1.Y) * (pt2.Y - pt1.Y));
        }

        //Result: Index 0 : item1 ConnectionPoint; Index 1: item2 ConnectionPoint
        public static ADVStep.ConnectionPoint[] GetShortestConnectionPoint(StepItem item1, StepItem item2)
        {
            ADVStep.ConnectionPoint[] result = new ADVStep.ConnectionPoint[2];
            double minValue = 9999999;
            foreach (ADVStep.ConnectionPoint item1Type in Enum.GetValues(typeof(ADVStep.ConnectionPoint)))
            {
                Point point1 = item1.GetBorderPoint(item1Type);

                foreach (ADVStep.ConnectionPoint item2Type in Enum.GetValues(typeof(ADVStep.ConnectionPoint)))
                {
                    Point point2 = item2.GetBorderPoint(item2Type);
                    double distance = GetDistance(point1, point2);

                    if (distance < minValue)
                    {
                        minValue = distance;
                        result[0] = item1Type;
                        result[1] = item2Type;
                    }
                }
            }

            return result;
        }

        public static string? GetResourcesString(string key)
        {
            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));
            return rm.GetString(key, System.Globalization.CultureInfo.CurrentCulture);
        }

        public static ToolTip ShowErrorMessage(Control ctrl, string errorTitle, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipTitle = errorTitle;
            toolTip.UseFading = true;
            toolTip.UseAnimation = true;
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Error;

            toolTip.ShowAlways = true;
            toolTip.AutoPopDelay = 0;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 500;



            toolTip.SetToolTip(ctrl, errorMessage);
            toolTip.Show(errorMessage, ctrl);

            return toolTip;
        }

        internal static StepType GetStepType(ADVStep step)
        {
            switch (step.Type)
            {
                case Constant.ADVType.Talk:
                    return StepType.Talk;
                case Constant.ADVType.Chara:
                    return StepType.Chara;
                case Constant.ADVType.CharaInit:
                    return StepType.CharaInit;
                case Constant.ADVType.ChangeBackground:
                    return StepType.Background;
                case Constant.ADVType.ChangeBGM:
                    return StepType.BGM;
                case Constant.ADVType.PlaySE:
                    return StepType.SE;
                case Constant.ADVType.ChangeCamera:
                    return StepType.Camera;
                case Constant.ADVType.FadeOut:
                    return StepType.FadeOut;
                case Constant.ADVType.FadeIn:
                    return StepType.FadeIn;
                case Constant.ADVType.MakeGroup:
                    return StepType.MakeGroup;
                case Constant.ADVType.DismissGroup:
                    return StepType.DismissGroup;
                case Constant.ADVType.Group:
                    return StepType.GroupMotion;
                case Constant.ADVType.AddObject:
                    return StepType.AddObject;
                case Constant.ADVType.RemoveObject:
                    return StepType.RemoveObject;
                case Constant.ADVType.AddTexture:
                    return StepType.AddTexture;
                case Constant.ADVType.RemoveTexture:
                    return StepType.RemoveTexture;
                case Constant.ADVType.TimeWait:
                    return StepType.TimeSleep;
                case Constant.ADVType.ShowChoiceList:
                    return StepType.ShowOption;
                case Constant.ADVType.Evaluate:
                    return StepType.Evaluate;
                case Constant.ADVType.Branch:
                    return StepType.Branch;
                default:
                    return StepType.ADVEnd;
            }
        }

        internal static string GetADVStepType(StepType step)
        {
            switch (step)
            {
                case StepType.Talk:
                    return Constant.ADVType.Talk;
                case StepType.Chara:
                    return Constant.ADVType.Chara;
                case StepType.CharaInit:
                    return Constant.ADVType.CharaInit;
                case StepType.Background:
                    return Constant.ADVType.ChangeBackground;
                case StepType.BGM:
                    return Constant.ADVType.ChangeBGM;
                case StepType.SE:
                    return Constant.ADVType.PlaySE;
                case StepType.Camera:
                    return Constant.ADVType.ChangeCamera;
                case StepType.FadeOut:
                    return Constant.ADVType.FadeOut;
                case StepType.FadeIn:
                    return Constant.ADVType.FadeIn;
                case StepType.MakeGroup:
                    return Constant.ADVType.MakeGroup;
                case StepType.DismissGroup:
                    return Constant.ADVType.DismissGroup;
                case StepType.GroupMotion:
                    return Constant.ADVType.Group;
                case StepType.AddObject:
                    return Constant.ADVType.AddObject;
                case StepType.RemoveObject:
                    return Constant.ADVType.RemoveObject;
                case StepType.AddTexture:
                    return Constant.ADVType.AddTexture;
                case StepType.RemoveTexture:
                    return Constant.ADVType.RemoveTexture;
                case StepType.TimeSleep:
                    return Constant.ADVType.TimeWait;
                case StepType.ShowOption:
                    return Constant.ADVType.ShowChoiceList;
                case StepType.Evaluate:
                    return Constant.ADVType.Evaluate;
                case StepType.Branch:
                    return Constant.ADVType.Branch;
                default:
                    return Constant.ADVType.ADVEnd;
            }
        }

        internal static string ConvertNumberToFullTypeString(int value)
        {
            if (value >= 0 && value <= 3)
                return Constant.NumberInFullTypeString[value];
            return "";
        }

        internal static int ConvertFullTypeStringToNumber(string value)
        {
            foreach(var kvp in Constant.NumberInFullTypeString)
                if (kvp.Value == value)
                    return kvp.Key;
            return -1;
        }

        internal static string GetDefaultStepWaitingType(StepType stepType)
        {
            //TODO: full list for type
            switch (stepType)
            {
                case StepType.Talk:
                    return Constant.WaitingType.Click;
                case StepType.Branch:
                    return Constant.WaitingType.Branching;
                case StepType.ADVEnd:
                    return Constant.WaitingType.ADVEnd;
                case StepType.TimeSleep:
                    return Constant.WaitingType.TimeWait;
                case StepType.ShowOption:
                    return Constant.WaitingType.InputChoice;
                default:
                    return Constant.WaitingType.Auto;
            }
        }


        internal static void SetupIndexPositionComboBox(ComboBox ctrl, int count)
        {
            Dictionary<int, string> indexList = new Dictionary<int, string>();
            for (int i = 0; i < count; i++)
            {
                indexList.Add(i, (i + 1).ToString());
            }

            if (indexList.Count > 0)
            {
                ctrl.DisplayMember = "Value";
                ctrl.ValueMember = "Key";
                ctrl.DataSource = new BindingSource(indexList, null);
                ctrl.SelectedIndex = 0;

                ctrl.Enabled = true;
            }
            else
            {
                ctrl.DataSource = null;
                ctrl.Enabled = false;
            }
        }
    }
}
