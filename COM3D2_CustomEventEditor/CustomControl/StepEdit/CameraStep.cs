using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    public partial class CameraStep : StepEditBase
    {
        public CameraStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.CameraData == null)
                return;

            if (_StepData.CameraData.FixedPointData != null)
            {
                txtPosString.Texts = _StepData.CameraData.FixedPointData.PosString;
                txtTargetPosition.Texts = _StepData.CameraData.FixedPointData.TargetPosString;
                txtAroundAngles.Texts = _StepData.CameraData.FixedPointData.AroundAngleString;
                txtDistance.Texts = _StepData.CameraData.FixedPointData.Distance.ToString();

                chkCameraPan.Checked = _StepData.CameraData.MoveType == ADVStep.Camera.CameraMoveType.Smooth;
                txtCameraPanDuration.Texts = _StepData.CameraData.AnimationTime.ToString();

                if (_StepData.CameraData.LockCamera != null)
                {
                    rbLockCameraLocked.Checked = _StepData.CameraData.LockCamera.IsLock;
                    rbLockCameraUnlocked.Checked = !_StepData.CameraData.LockCamera.IsLock;
                }
                else
                    rbLockCameraNoChange.Checked = true;


                if (_StepData.CameraData.BlurCamera != null)
                {
                    rbBlurCameraBlur.Checked = _StepData.CameraData.BlurCamera.IsBlur;
                    rbBlurCameraUnblur.Checked = !_StepData.CameraData.BlurCamera.IsBlur;
                }
                else
                    rbBlurCameraNoChange.Checked = true;
            }
        }


        internal void LoadData(ADVStep stepData)
        {
            txtPosString.Texts = "";
            txtTargetPosition.Texts = "";
            txtAroundAngles.Texts = "";
            txtDistance.Texts = "";
            chkCameraPan.Checked = false;
            rbLockCameraNoChange.Checked = true;
            rbBlurCameraNoChange.Checked = true;
            txtCameraDataToParse.Texts = "";

            _StepData = stepData;
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.Camera newData = new ADVStep.Camera();
            //Only support fixed point
            newData.Type = ADVStep.Camera.CameraType.FixedPoint;
            newData.FixedPointData = new CameraDataInJson();
            newData.FixedPointData.PosString = txtPosString.Texts;
            newData.FixedPointData.TargetPosString = txtTargetPosition.Texts;
            newData.FixedPointData.AroundAngleString = txtAroundAngles.Texts;
            float.TryParse(txtDistance.Texts, System.Globalization.CultureInfo.InvariantCulture, out newData.FixedPointData.Distance);

            if (chkCameraPan.Checked)
            {
                newData.MoveType = ADVStep.Camera.CameraMoveType.Smooth;
                float.TryParse(txtCameraPanDuration.Texts, System.Globalization.CultureInfo.InvariantCulture, out newData.AnimationTime);
            }
            else
                newData.MoveType = ADVStep.Camera.CameraMoveType.Instant;

            if (!rbLockCameraNoChange.Checked)
            {
                newData.LockCamera = new ADVStep.Camera.LockCameraInfo();
                newData.LockCamera.IsLock = rbLockCameraLocked.Checked;
            }

            if (!rbBlurCameraNoChange.Checked)
            {
                newData.BlurCamera = new ADVStep.Camera.BlurCameraInfo();
                newData.BlurCamera.IsBlur = rbBlurCameraBlur.Checked;
            }


            _StepData.CameraData = newData;

        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        private void chkCameraPan_CheckedChanged(object sender, EventArgs e)
        {
            txtCameraPanDuration.Enabled = chkCameraPan.Checked;
            //Update the Waiting Type too
            if (chkCameraPan.Checked)
                ucBasicStepInfo.WaitingType = Constant.WaitingType.CameraPan;
            else
                ucBasicStepInfo.WaitingType = Constant.WaitingType.Auto;
        }

        private void btnParser_Click(object sender, EventArgs e)
        {
            try
            {
                string[] split = txtCameraDataToParse.Texts.Split('|');
                if (split.Length == 4)
                {
                    txtPosString.Texts = split[0];
                    txtTargetPosition.Texts = split[1];
                    txtAroundAngles.Texts = split[2];
                    txtDistance.Texts = split[3];
                }
                txtCameraDataToParse.Texts = "";
            }
            catch
            {
                Util.ShowErrorMessage(txtCameraDataToParse, Util.GetResourcesString("InvalidInput"), Util.GetResourcesString("InvalidFormat"));
            }

        }
    }




}
