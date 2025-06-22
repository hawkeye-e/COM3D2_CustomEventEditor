using COM3D2_CustomEventEditor.CustomControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM3D2_CustomEventEditor
{
    internal static class Global
    {
        public static List<StepItem> AllSteps = new List<StepItem>();       //Hold all the steps data that drawed in the canvas
        public static ScenarioDefinition ScenarioDefinition = new ScenarioDefinition();
        public static Canvas Canvas;

        private const string DefaultStepIDFormat = "Step{0:000000}";
        private static int _StepIDRunningNumber = 0;

        public static string GenerateNewStepID()
        {
            return String.Format(DefaultStepIDFormat, _StepIDRunningNumber++);
        }

        public static void ResetStepIDRunningNumber()
        {
            _StepIDRunningNumber = 1;
        }

        public static int StepIDRunningNumber
        {
            get { return _StepIDRunningNumber; }
            set { _StepIDRunningNumber = value; }
        }
    }
}
