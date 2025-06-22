using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
//using UnityEngine;

namespace COM3D2_CustomEventEditor
{
    public class EyeSightSetting
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public EyeSightType Type = EyeSightType.NoChange;
        public EyeToCameraSettingDetail EyeToCameraSetting;
        public EyeToCharaSettingDetail EyeToCharaSetting;
        //TODO: need review this
        //public EyeToObjectSettingDetail EyeToObjectSetting;


        public class EyeToCameraSettingDetail
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public EyeToCameraMoveType MoveType;
        }

        public class EyeToCharaSettingDetail
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public TargetType Type;
            public int ArrayPosition;
            [JsonConverter(typeof(StringEnumConverter))]
            public GroupMemberType TargetGroupMember;
            

            public enum TargetType
            {
                Man,
                Maid,
                ClubOwner,
                GroupMember,
                NPCMale,
                NPCFemale
            }

            
        }

        //public class EyeToObjectSettingDetail
        //{
        //    public GameObject Target;
        //}

        public enum EyeSightType
        {
            ToChara,
            ToCamera,
            ToObject,
            Reset,
            NoChange
        }



        public enum EyeToCameraMoveType
        {
            None = 0,
            Ignore = 1,
            LookAt = 2,
            MoveFaceOnly = 3,
            AvoidFace = 4,
            FaceAndEye = 5,
            EyeOnly = 6,
            AvoidEye = 7
        }

        public enum GroupMemberType
        {
            Maid1,
            Maid2,
            Man1,
            Man2,
            Man3
        }
    }
}
