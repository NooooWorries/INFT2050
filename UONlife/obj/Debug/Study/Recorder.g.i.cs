﻿

#pragma checksum "\\Mac\Home\Documents\Visual Studio 2015\Projects\UONLife\UONlife\Study\Recorder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E67909EFFB55E326D52A97A5D162D7EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UONlife.Study
{
    partial class Recorder : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.MediaElement playbackElement1; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button CaptureButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button StopCaptureButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button PlayRecordButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox tbxCourseID; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox tbxWeek; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button btnSave; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ProgressBar progress; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Study/Recorder.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            playbackElement1 = (global::Windows.UI.Xaml.Controls.MediaElement)this.FindName("playbackElement1");
            CaptureButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("CaptureButton");
            StopCaptureButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("StopCaptureButton");
            PlayRecordButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("PlayRecordButton");
            tbxCourseID = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("tbxCourseID");
            tbxWeek = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("tbxWeek");
            btnSave = (global::Windows.UI.Xaml.Controls.Button)this.FindName("btnSave");
            progress = (global::Windows.UI.Xaml.Controls.ProgressBar)this.FindName("progress");
        }
    }
}


