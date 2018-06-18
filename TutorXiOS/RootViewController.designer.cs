// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TutorXiOS
{
    [Register ("RootViewController")]
    partial class RootViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Student { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Tutor { get; set; }

        [Action ("Student_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Student_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton1081_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton1081_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Student != null) {
                Student.Dispose ();
                Student = null;
            }

            if (Tutor != null) {
                Tutor.Dispose ();
                Tutor = null;
            }
        }
    }
}