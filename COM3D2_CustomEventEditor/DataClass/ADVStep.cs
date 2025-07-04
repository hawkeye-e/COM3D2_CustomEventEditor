using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static COM3D2_CustomEventEditor.Constant;

namespace COM3D2_CustomEventEditor
{
    internal class ADVStep
    {
#pragma warning disable CS8618
        public string ID;
        public string Name;                 //Only used in this editor for readibility, not in use in mod
        public string Type;
        public string NextStepID;
        public string WaitingType;
        public string Tag;                  //Used in:  ChangeBackground (Background Tag ID), 
                                            //          LoadScene (Scene Tag ID, refer to Constant.SceneType)
                                            //          ChangeBGM (BGM file name)
                                            //          Dismiss Group ("ALL" or group index)
        [DefaultValue("")]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TagForNight = "";     //Same as Tag, will use this instead of tag if the current time is night


        public Fade FadeData;
        public Talk TalkData;
        public Camera CameraData;
        public Choice ChoiceData;
        public CharaInit CharaInitData;
        public ShowChara[] CharaData;
        public ShowGroupMotion[] GroupData;       //Separate from ShowChara to not making things over complicated
        public YotogiSetupInfo YotogiSetup;
        public Texture[] TextureData;
        public SE SEData;
        public Shuffle ShuffleData;                 //This need to be placed after CharaInit
        public ListUpdate ListUpdateData;           //For adding or removing the NPC from the list to include or exclude them from yotogi scene
        public List<WorldObject> WorldObjectData;

        public RandomPick PickData;             //This is for ordering to randomly pick some characters for later adv processing
        public List<MakeGroupFormat> GroupFormat;     //Assign group to perform group motion in ADV scene etc

        public Evaluate EvalData;
        public Branch BranchData;

        //Editor Used Members below
        public List<GraphConnection> ConnectionList = new List<GraphConnection>();
        public Point Location;


        internal class Fade
        {
            public bool IsFadeIn;
            public bool IsFadeOut;
            public float Time = 0.5f;
            public string ColorString = "";         //in ARGB format (hexadecimal)
        }

        internal class Talk
        {
            public string SpecificSpeaker;
            public string SpeakerName;
            public string Text;                 //////For the case of narrative, man or all maids
            public int Index;
            public bool UseBranchIndex = false;

            public Dictionary<string, Voice> VoiceData;

            internal class Voice
            {
                public string VoiceFile;
                public bool IsChoppingAudio = false;    //Some audio files is chopped in mod to fit the situation. Set this field to true for those cases.
                public float StartTime = 0f;            //Require IsChoppingAudio = true
                public float EndTime = 0f;              //Require IsChoppingAudio = true
                public float Volume = 1f;
            }

        }
        
        internal class Camera
        {
            public CameraType Type = CameraType.FixedPoint;
            public CameraDataInJson FixedPointData;     //Normally use this one for ADV scene, as we should have full control on the character placement
            //public LookAtType LookAtData;               //Mainly used for situation where random character placement is involved and want to focus on certain character
            public CameraMoveType MoveType = CameraMoveType.Instant;
            public float AnimationTime = 2f;            //For Camera pan use only
            public LockCameraInfo LockCamera;
            public BlurCameraInfo BlurCamera;

            internal class LockCameraInfo
            {
                public bool IsLock = false;
            }

            internal class BlurCameraInfo
            {
                public bool IsBlur = false;
            }

            internal enum CameraType
            {
                FixedPoint,
                //LookAt
            }

            //internal enum TargetType
            //{
            //    Maid,
            //    Man,
            //    Owner,
            //    GroupMaid1,
            //    GroupMaid2
            //}

            internal enum CameraMoveType
            {
                Instant,
                Smooth
            }
            //internal class LookAtType
            //{
            //    public TargetType Target;
            //    public int ArrayPosition;
            //    //public bool UseRandomPick = false;
            //    public bool UseDefaultCameraWorkSetting = true;

            //    public CameraDataInJson OffsetData;     
            //}

        }

        internal class Choice
        {
            public string Variable;
            public List<ChoiceOption> Options;

            public class ChoiceOption
            {
                public string Key;
                public string Value;
            }
        }

        internal class CharaInit
        {
            public int ManRequired = 0;        //Indicate how many man character needed to be initialized. Negative to skip (eg. it is decided from user input)
            public List<string> ValidManType;   //Referencing RandomizeManSetting. Required if ManRequired is non negative.
            public List<NPCFemaleData> NPCFemale;           //Female only
            public List<NPCMaleData> NPCMale;
            public List<CustomAnimation> CustomAnim;
            public List<ClothesSetData> ClothesSet;

            internal class NPCFemaleData
            {
                public int Index;               //Share the same array with ModNPC
                [JsonConverter(typeof(StringEnumConverter))]
                public NPCType Type;
                public string Key;              //Key of the official NPC
                public ModNPCFemale CustomData; //Data for custom NPC


                public enum NPCType
                {
                    Official,
                    Custom,
                }

            }

            internal class NPCMaleData
            {
                public int Index;               //Share the same array with NPC
                public ModNPCMale MaleData;

            }

            internal class CustomAnimation
            {
                public string Key;
                public string FileName;
            }

            internal class ClothesSetData
            {
                public string Key;
                public Dictionary<string, string> Slots;
            }
        }

        internal class ShowChara
        {
            public string Type;
            public int ArrayPosition;
            public bool UseBranchIndex = false;

            //In some scenario the master may be removed from the array, use this flag if want to do any setup with it in the adv. 
            //If this is set to true, the ArrayPosition has to be set to zero
            public bool IsMaster = false;       
            public bool Visible;
            public bool IsManNude = false;
            public bool OpenMouth = false;                              //True: open mouth for fella motion etc; False: default
            public SmoothMovementSetup SmoothMovement = null;

            public MotionInfo MotionInfo;
            public string FaceAnime;
            public string FaceBlend;
            public PosRot PosRot;

            public EyeSightSetting EyeSight;
            public ExtraItemObject ExtraObjectInfo;
            public string ClothesSetID;                                 //Special ID: "RESET", reset all applied ClothesSetID. 
            public EffectDetail Effect;

            public class SmoothMovementSetup
            {
                public float Time;
            }
        }

        internal class ShowGroupMotion
        {
            //public bool UseRandomPick = false;
            public int ArrayPosition;

            public string ScriptFile;
            public string ScriptLabel;

            public PosRot PosRot;
            public bool BlockInputUntilMotionChange = false;      

            public DetailSetup Maid1;
            public DetailSetup Maid2;
            public DetailSetup Man1;
            public DetailSetup Man2;
            public DetailSetup Man3;


            public class DetailSetup
            {
                public bool Visible;
                
                public bool IsManNude = false;

                public string FaceAnime;
                public string FaceBlend;
                public bool OpenMouth = false;
                public EyeSightSetting EyeSight;
                public PosRot PosRot;
            }
        }

        internal class YotogiSetupInfo
        {
            public string YotogiCode;
            public int Phase;
            public bool IsKeepCharacterVisibleAfterYotogi = true;              //The system will automatically hide all the characters when display the yotogi result. Set it to true to prevent from hiding them.
            public bool IsFinalYotogi = true;
            public bool IsClubOwnerMainCharacter = true;    //True: Man[0] will be the owner; False: Man[0] will be replaced with other man character and owner is accessible from StateManager.Instance.ClubOwner
            public MaidConvertToManSetting MaidConvertToMan = null;
            public bool UseModSemenPattern = false;

            public class MaidConvertToManSetting
            {
                public int RatioPercent;
            }
        }

        
        internal class RandomPick
        {
            public PickType Type;
            public int Num;

            internal enum PickType
            {
                Maid,
                Man,
                Group
            }
        }

        internal class MakeGroupFormat
        {
            public int GroupIndex;
            public GroupMemberInfo Maid1;
            public GroupMemberInfo Maid2;
            public GroupMemberInfo Man1;
            public GroupMemberInfo Man2;
            public GroupMemberInfo Man3;

            public class GroupMemberInfo
            {
                public string Type;
                public int ArrayPosition;
            }

            public class MemberType
            {
                public const string NotSelect = "";
                public const string Owner = "Owner";
                public const string NPC = "NPC";
                public const string Man = "M";
                public const string Maid = "Maid";
            }

        }



        public class Texture
        {
            public string Type;
            public string TargetType = Constant.TargetType.SingleMaid;      //Use Constant.TargetType; Valid Option: "F": maid list, "F_ALL": All maids, "NPC_F": NPC Female List
            public int IndexPosition;                                       
            public List<string> BodyTarget;                                 //Required for add only. Ignored when remove texture.
        }

        internal class SE
        {
            public string FileName;
            public bool IsLoop = false;
            public bool Stop = false;
        }

        internal class Shuffle
        {
            public string TargetList;
            public List<int> KeepPosition;
        }

        internal class ListUpdate
        {
            public List<ListUpdateDetail> Add;
            public List<ListUpdateDetail> Remove;

            internal class ListUpdateDetail
            {
                public string Type;
                public int SrcPosition;
                public int PositionToInsert;
            }
        }

        internal class WorldObject
        {
            public string Src;
            public string ObjectID;                 //Used for removing the object
            public PosRot PosRot;

            [DefaultValue(1f)]
            [JsonProperty(NullValueHandling = NullValueHandling.Ignore, DefaultValueHandling = DefaultValueHandling.Ignore)]
            public float Scale = 1;
        }

        internal class EffectDetail
        {
            public List<string> ActiveEffects;
        }

        internal class Evaluate
        {
            public string Operator;         //Constant.OperatorType
            public InputDetail Input1;
            public InputDetail Input2;
            public string ResultVariableName;

            public class InputDetail
            {
                [JsonConverter(typeof(StringEnumConverter))]
                public SourceType SourceType;
                public VariableInfo Variable;
                public CharaStatusInfo CharaStatus;
                public FixedValueInfo FixedValue;
                public RandomNumberInfo RandomNumber;
            }

            public class VariableInfo
            {
                public string VariableName;
            }

            public class CharaStatusInfo
            {
                public string ListType;             //Only Maid or NPC(Female) available
                public int ArrayPosition;

                public string FieldName;         //status field name
            }

            public class FixedValueInfo
            {
                [JsonConverter(typeof(StringEnumConverter))]
                public VariableType FixedValueType;
                public string FixedValue;
            }

            public class RandomNumberInfo
            {
                public int MaxValue;
            }

            public enum SourceType
            {
                Variable,
                CharcterStatus,
                FixedValue,
                RandomNumber,
            }
        }

        internal class Branch
        {
            public string VariableName;     //The variable that used to compared
            public string CompareMethod;    //Valid operator list: [==, >, >=, <, <=]
            [JsonConverter(typeof(StringEnumConverter))]
            public VariableType VariableType;
            public List<BranchItem> BranchList;

            public class BranchItem
            {
                public string Value;        //stored as string in json, convert it to appropiate type in loader
                public string NextStepID;
            }
        }

        internal class GraphConnection
        {
            public int ID;                  
            public string TargetStepID;
            public ConnectionPoint From;
            public ConnectionPoint To;
            public bool IsDraw = true;      //a flag to control whether this connection should be drawn in the canvas
        }

        public enum ConnectionPoint
        {
            //Rearrange to make border point in the middle gets the priority when auto set
            TopMiddle,
            BottomMiddle,
            MiddleLeft,
            MiddleRight,
            TopLeft,
            TopRight,
            BottomLeft,
            BottomRight,
        }

#pragma warning restore CS6818
    }
}
