using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM3D2_CustomEventEditor
{
    public class ScenarioDefinition
    {

        public string Title;
        public string EventContents;
        public string Icon;
        public int EditorVersion;

        public string Author;
        public string Language;
        //Key: Personality, Value: Number of Maid required; Personality value 0 means All
        public List<MaidRequirementInfo> MaidRequirement = new List<MaidRequirementInfo>();

        //System Use
        public string EntryStep;
        public int RunningNumber;

        public Point EditorScrollPosition;

        public class MaidRequirementInfo
        {
            public List<int> PersonalityID = new List<int>();
            public int IndexPosition;
        }
    }
}
