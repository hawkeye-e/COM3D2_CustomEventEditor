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
    public partial class EvaluateStep : StepEditBase
    {
        public static readonly List<ComboBoxData> OperationTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.OperatorType.Assignment, Util.GetResourcesString("OperationTypeAssignment")),

            new ComboBoxData(Constant.OperatorType.Addition, Util.GetResourcesString("OperationTypeAddition")),
            new ComboBoxData(Constant.OperatorType.Subtraction, Util.GetResourcesString("OperationTypeSubtraction")),
            new ComboBoxData(Constant.OperatorType.Multiplication, Util.GetResourcesString("OperationTypeMultiplication")),
            new ComboBoxData(Constant.OperatorType.Division, Util.GetResourcesString("OperationTypeDivision")),

            new ComboBoxData(Constant.OperatorType.Equal, Util.GetResourcesString("OperationTypeEqual")),
            new ComboBoxData(Constant.OperatorType.GreaterThan, Util.GetResourcesString("OperationTypeGreaterThan")),
            new ComboBoxData(Constant.OperatorType.GreaterThanEqualTo, Util.GetResourcesString("OperationTypeGreaterThanEqualTo")),
            new ComboBoxData(Constant.OperatorType.LessThan, Util.GetResourcesString("OperationTypeLessThan")),
            new ComboBoxData(Constant.OperatorType.LessThanEqualTo, Util.GetResourcesString("OperationTypeLessThanEqualTo")),


            new ComboBoxData(Constant.OperatorType.NotEqual, Util.GetResourcesString("OperationTypeNotEqual")),
            new ComboBoxData(Constant.OperatorType.LogicalAnd, Util.GetResourcesString("OperationTypeLogicalAnd")),
            new ComboBoxData(Constant.OperatorType.LogicalOr, Util.GetResourcesString("OperationTypeLogicalOr")),
            new ComboBoxData(Constant.OperatorType.Negation, Util.GetResourcesString("OperationTypeNegation")),

            new ComboBoxData(Constant.OperatorType.Concatenation, Util.GetResourcesString("OperationTypeConcatenation")),
        };




        private bool _isInit = true;

        public EvaluateStep()
        {
            InitializeComponent();
            ucInput1.SetInputType(true);
            ucInput2.SetInputType(false);
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.EvalData == null)
                return;

            cbOperation.SelectedValue = _StepData.EvalData.Operator;
            txtResultVariable.Texts = _StepData.EvalData.ResultVariableName;
            ucInput1.LoadData(_StepData.EvalData.Input1);
            ucInput2.LoadData(_StepData.EvalData.Input2);

        }


        private void InitDropDown()
        {
            cbOperation.DataSource = OperationTypeList;
            cbOperation.SelectedIndex = 0;
        }


        internal void LoadData(ADVStep stepData)
        {
            _isInit = true;

            txtResultVariable.Texts = "";
            ucInput1.ResetData();
            ucInput2.ResetData();

            InitDropDown();

            _StepData = stepData;
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();

            _isInit = false;
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.Evaluate newData = new ADVStep.Evaluate();
            newData.Operator = cbOperation.SelectedValue.ToString();
            newData.ResultVariableName = txtResultVariable.Texts;
            newData.Input1 = ucInput1.GetInputDetail();
            newData.Input2 = ucInput2.GetInputDetail();

            _StepData.EvalData = newData;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }


    }




}
