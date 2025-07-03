using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM3D2_CustomEventEditor
{
    internal class Constant
    {
        internal const float DefaultFadeTime = 0.5f;
        internal const string BlushingWord = "頬";
        internal const string TearWord = "涙";
        internal static readonly Dictionary<int, string> NumberInFullTypeString = new Dictionary<int, string>()
        {
            { 0, "０"},
            { 1, "１"},
            { 2, "２"},
            { 3, "３"},
        };
        internal const string FaceBlendStringFormat = "^頬(０|１|２|３)涙(０|１|２|３)$";


        internal static class PersonalityType
        {
            internal const int Muku = 80;       //無垢
            internal const int Majime = 90;     //真面目
            internal const int Rindere = 100;   //凛デレ
            internal const int Pure = 10;       //純真
            internal const int Pride = 30;      //ツンデレ
            internal const int Cool = 20;       //クーデレ
            internal const int Yandere = 40;    //ヤンデレ
            internal const int Anesan = 50;     //お姉ちゃん
            internal const int Genki = 60;      //ボクっ娘
            internal const int Sadist = 70;     //ドＳ
            internal const int Silent = 110;    //文学少女
            internal const int Devilish = 120;  //小悪魔
            internal const int Ladylike = 130;  //おしとやか
            internal const int Secretary = 140; //メイド秘書
            internal const int Sister = 150;    //ふわふわ妹
            internal const int Curtness = 160;  //無愛想
            internal const int Missy = 170;     //お嬢様
            internal const int Childhood = 180; //幼馴染
            internal const int Masochist = 190; //ド変態ドＭ
            internal const int Cunning = 200;   //腹黒
            internal const int Friendly = 210;  //気さく
            internal const int Dame = 220;      //淑女
            internal const int Gyaru = 230;     //ギャル
        }

        internal static class DefinedColorString
        {
            internal const string White = "White";
        }

        internal static class TargetType
        {
            internal const string ClubOwner = "Owner";
            internal const string SingleMan = "M";
            internal const string SingleMaid = "F";
            internal const string AllMen = "M_ALL";
            internal const string AllMaids = "F_ALL";
            internal const string NPCFemale = "NPC_F";
            internal const string NPCMale = "NPC_M";
            internal const string AllNPCFemale = "NPC_F_ALL";
            internal const string AllNPCMale = "NPC_M_ALL";

        }

        internal static class ADVType
        {
            internal const string Chara = "Chara";
            internal const string Group = "Group";
            internal const string Talk = "Talk";
            internal const string ChangeBGM = "BGM";
            internal const string PlaySE = "SE";
            internal const string ChangeBackground = "BG";
            internal const string ChangeScene = "Scene";
            internal const string ChangeCamera = "Camera";
            internal const string ShowChoiceList = "List";

            internal const string FadeOut = "FadeOut";          //
            internal const string FadeIn = "FadeIn";                        //Add this type to separate fade in/out from each steps
            internal const string LoadScene = "LoadScene";

            internal const string CharaInit = "CharaInit";

            internal const string Pick = "Pick";
            internal const string MakeGroup = "MakeGroup";  //Assign characters into a group in order to set group motion etc
            internal const string DismissGroup = "DismissGroup";  //Assign characters into a group in order to set group motion etc

            internal const string AddTexture = "AddTexture";
            internal const string RemoveTexture = "RemoveTexture";

            internal const string Shuffle = "Shuffle";
            internal const string ListUpdate = "ListUpdate";
            internal const string TimeWait = "TimeWait";

            internal const string AddObject = "AddObject";
            internal const string RemoveObject = "RemoveObject";

            internal const string Evaluate = "Evaluate";
            internal const string Branch = "Branch";

            internal const string ADVEnd = "ADVEnd";    //End the scenario and return to normal flow
        }

        internal static class WaitingType
        {
            internal const string Auto = "Auto";    //player no need to do anything and the adv scene will proceed to next step
            internal const string Click = "Click";
            internal const string InputChoice = "InputChoice";
            internal const string FadeOut = "FadeOut";
            internal const string CameraPan = "CameraPan";

            internal const string Branching = "Branch";
            internal const string TimeWait = "TimeWait";
            internal const string ADVEnd = "End";


            //Not used below?
            internal const string SystemFadeOut = "SystemFadeOut";      //This one is for waiting for the fade out caused by the original system not by this mod


            internal const string Special = "Special";  //Need special handling to proceed to next step (eg. doing some branching). 
        }

        internal static class ADVTalkSpeakerType
        {
            internal const string Narrative = "Narrative";
            internal const string Owner = "Owner";
            internal const string SelectedMaid = "SelectedMaid";        //Maid 0
            internal const string Maid = "Maid";                        //Require Index position
            internal const string RandomMaid = "RandomMaid";
            internal const string NPCFemale = "NPC_F";
            internal const string NPCMale = "NPC_M";
            internal const string All = "All";

            internal const string Other = "Other";                      //only use in this editor
        }

        //Referencing the json file in Loader
        internal static class DefinedManTypeCode
        {
            internal const string YoungMan = "YoungMan";
            internal const string Yanki = "Yanki";
            internal const string MiddleAged = "MiddleAged";
            internal const string Otaku = "Otaku";
            internal const string Shota = "Shota";
        }

        internal static class GroupFormatType
        {
            internal const string All = "ALL";
        }

        public enum GroupMemberType
        {
            Maid1,
            Maid2,
            Man1,
            Man2,
            Man3,
        }

        internal static class GroupType
        {
            internal const string FF = "FF";
            internal const string MF = "MF";
            internal const string MMF = "MMF";
            internal const string FFM = "FFM";
            internal const string MMMF = "MMMF";
            internal const string Invalid = "";
        }

        internal static class TextureType
        {
            internal const string Semen = "Semen";
            internal const string Candle = "Candle";
            internal const string WhipMark = "WhipMark";
            internal const string SlapMark = "SlapMark";
            internal const string Lotion = "Lotion";
        }

        internal static class BodyPartType
        {
            internal const string Vagina = "Vagina";
            internal const string Belly = "Belly";
            internal const string Ass = "Ass";
            internal const string Back = "Back";
            internal const string Breast = "Breast";
            internal const string Mouth = "Mouth";
            internal const string Face = "Face";
            internal const string Leg = "Leg";
            internal const string FullBody = "FullBody";
        }

        internal static class OperatorType
        {
            internal const string Assignment = "=";
            internal const string Addition = "+";
            internal const string Subtraction = "-";
            internal const string Multiplication = "*";
            internal const string Division = "/";

            internal const string Equal = "==";
            internal const string GreaterThan = ">";
            internal const string GreaterThanEqualTo = ">=";
            internal const string LessThan = "<";
            internal const string LessThanEqualTo = "<=";

            internal const string NotEqual = "!=";
            internal const string LogicalAnd = "&&";
            internal const string LogicalOr = "||";
            internal const string Negation = "!";

            internal const string Concatenation = "&";
        }

        public enum VariableType
        {
            Integer,
            FloatingPoint,
            String,
            Boolean,
        }

        internal static class CharacterStatusField
        {
            internal const string Likability = "likability";
            internal const string Lovely = "lovely";
            internal const string Elegance = "elegance";
            internal const string Charm = "charm";
            internal const string Care = "care";
            internal const string Reception = "reception";
            internal const string Cooking = "cooking";
            internal const string Dance = "dance";
            internal const string Vocal = "vocal";
            internal const string NightWorkCount = "playCountNightWork";

            internal const string Inyoku = "inyoku";
            internal const string MValue = "mvalue";
            internal const string Hentai = "hentai";
            internal const string Houshi = "housi";
            internal const string YotogiCount = "playCountYotogi";

            internal const string HeroineType = "personal.id";
            internal const string SexExperienceVaginal = "seikeiken.vaginal";
            internal const string SexExperienceAnal = "seikeiken.anal";
            internal const string Height = "body.height";
            internal const string Weight = "body.weight";
            internal const string Bust = "body.bust";
            internal const string Waist = "body.waist";
            internal const string Hip = "body.hip";
            internal const string Cup = "body.cup";

            internal const string SexNumOfPeople = "sexPlayNumberOfPeople";
        }

        internal static class EffectType
        {
            internal static class Female
            {
                internal const string Breath = "Breath";
                internal const string SexualFluid1 = "SexualFluid1";
                internal const string SexualFluid2 = "SexualFluid2";
                internal const string SexualFluid3 = "SexualFluid3";
                internal const string Urine_Common = "Urine_Common";
                internal const string Urine_Doggy = "Urine_Doggy";
                internal const string Urine_Drop = "Urine_Drop";
                internal const string Squirting = "Squirting";
                internal const string EjaculateInside = "Female_EjaculateInside";
            }

            internal static class Male
            {
                internal const string EjaculateOutside = "Male_EjaculateOutside";
            }
        }
    }
}
