using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
namespace COM3D2_CustomEventEditor
{
    public static class ControlExtension
    {
        // TKey is control to drag, TValue is a flag used while dragging
        private static Dictionary<Control, bool> draggables =
                   new Dictionary<Control, bool>();
        private static Dictionary<Control, Control> dragTargets = new Dictionary<Control, Control>();
        private static Dictionary<Control, Action> onDragDoneDelegates = new Dictionary<Control, Action>();
        private static Point startLocation;

        private static System.Drawing.Size mouseOffset;

        /// <summary>
        /// Enabling/disabling dragging for control
        /// </summary>
        public static void Draggable(this Control control, bool Enable, Action onDragDone)
        {
            if (Enable)
            {
                // enable drag feature
                if (draggables.ContainsKey(control))
                {   // return if control is already draggable
                    return;
                }
                // 'false' - initial state is 'not dragging'
                draggables.Add(control, false);
                dragTargets.Add(control, control);
                onDragDoneDelegates.Add(control, onDragDone);

                // assign required event handlersnnn
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                control.MouseUp += new MouseEventHandler(control_MouseUp);
                control.MouseMove += new MouseEventHandler(control_MouseMove);
            }
            else
            {
                // disable drag feature
                if (!draggables.ContainsKey(control))
                {  // return if control is not draggable
                    return;
                }

                // remove event handlers
                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                draggables.Remove(control);
                dragTargets.Remove(control);
                onDragDoneDelegates.Remove(control);
            }
        }

        public static void Draggable(this Control control, Control targetControl, bool Enable, Action onDragDone)
        {
            if (Enable)
            {
                // enable drag feature
                if (draggables.ContainsKey(control))
                {   // return if control is already draggable
                    return;
                }

                // 'false' - initial state is 'not dragging'
                draggables.Add(control, false);
                dragTargets.Add(control, targetControl);
                onDragDoneDelegates.Add(control, onDragDone);

                // assign required event handlersnnn
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                control.MouseUp += new MouseEventHandler(control_MouseUp);
                control.MouseMove += new MouseEventHandler(control_MouseMove);
            }
            else
            {
                // disable drag feature
                if (!draggables.ContainsKey(control))
                {  // return if control is not draggable
                    return;
                }

                // remove event handlers
                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                draggables.Remove(control);
                dragTargets.Remove(control);
                onDragDoneDelegates.Remove(control);
            }
        }

        static void control_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new System.Drawing.Size(e.Location);
            // turning on dragging
            draggables[(Control)sender] = true;
        }
        static void control_MouseUp(object sender, MouseEventArgs e)
        {
            // turning off dragging
            draggables[(Control)sender] = false;
            onDragDoneDelegates[(Control)sender].Invoke();
        }


        static void control_MouseMove(object sender, MouseEventArgs e)
        {
            // only if dragging is turned on
            if (draggables[(Control)sender] == true)
            {
                // calculations of control's new position
                System.Drawing.Point newLocationOffset = e.Location - mouseOffset;
                (dragTargets[(Control)sender]).Left += newLocationOffset.X;
                (dragTargets[(Control)sender]).Top += newLocationOffset.Y;

                if (dragTargets[(Control)sender] is StepItem)
                {
                    StepItem step = (StepItem)dragTargets[(Control)sender];
                    step.SetDragStatus(true);
                }

                Global.Canvas.Redraw();

            }
        }

        public static void LocalizeCollection(this IEnumerable collection)
        {
            foreach (var item in collection)
            {
                RecurLocalize(item);
            }
        }

        public static void RecurLocalize(object item)
        {
            if (item is ILocalizable localizable)
            {
                localizable.Localize();
            }
            if (item is Control)
            {
                Control control = (Control)item;
                foreach(var child in control.Controls)
                    RecurLocalize(child);
            }
                
                
        }





        public static void DragAndDraw(this Control control, bool Enable, Action onDragDone)
        {
            if (Enable)
            {
                // enable drag feature
                if (draggables.ContainsKey(control))
                {   // return if control is already draggable
                    return;
                }
                // 'false' - initial state is 'not dragging'
                draggables.Add(control, false);
                dragTargets.Add(control, control);
                onDragDoneDelegates.Add(control, onDragDone);
                

                // assign required event handlersnnn
                control.MouseDown += new MouseEventHandler(DragAndDraw_MouseDown);
                control.MouseUp += new MouseEventHandler(DragAndDraw_MouseUp);
                control.MouseMove += new MouseEventHandler(DragAndDraw_MouseMove);
            }
            else
            {
                // disable drag feature
                if (!draggables.ContainsKey(control))
                {  // return if control is not draggable
                    return;
                }

                // remove event handlers
                control.MouseDown -= DragAndDraw_MouseDown;
                control.MouseUp -= DragAndDraw_MouseUp;
                control.MouseMove -= DragAndDraw_MouseMove;
                draggables.Remove(control);
                dragTargets.Remove(control);
                onDragDoneDelegates.Remove(control);
                
            }
        }

        static void DragAndDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new System.Drawing.Size(e.Location);
            startLocation = e.Location;
            // turning on dragging
            draggables[(Control)sender] = true;
        }
        static void DragAndDraw_MouseUp(object sender, MouseEventArgs e)
        {
            // turning off dragging
            draggables[(Control)sender] = false;
            onDragDoneDelegates[(Control)sender].Invoke();
        }


        static void DragAndDraw_MouseMove(object sender, MouseEventArgs e)
        {
            // only if dragging is turned on
            if (draggables[(Control)sender] == true)
            {
                Control ctrl = (Control)sender;
                Point sourcePoint = new Point();
                Point targetPoint = new Point();
                //Point newLocationOffset = e.Location - mouseOffset;
                
                sourcePoint.X = ctrl.Location.X + ctrl.Parent.Location.X + startLocation.X;
                sourcePoint.Y = ctrl.Location.Y + ctrl.Parent.Location.Y + startLocation.Y;

                targetPoint.X = ctrl.Location.X + ctrl.Parent.Location.X + e.Location.X;
                targetPoint.Y = ctrl.Location.Y + ctrl.Parent.Location.Y + e.Location.Y;
                



                Global.Canvas.SetConnectingLine(sourcePoint, targetPoint);
                //CustomEventEditor.SetConnectingLine(startLocation, e.Location);

                Global.Canvas.Redraw();

                //foreach (var item in CustomEventEditor.AllSteps)
                //{
                //    item.Invalidate(false);
                //    item.Update();
                //    //item.Refresh();
                //}

            }
        }
    }
}