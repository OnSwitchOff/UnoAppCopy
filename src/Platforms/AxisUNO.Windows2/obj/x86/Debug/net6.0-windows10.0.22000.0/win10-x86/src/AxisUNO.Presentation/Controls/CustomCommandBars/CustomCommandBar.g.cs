﻿#pragma checksum "E:\Projects\AxisUNO - Copy\src\AxisUNO\src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AE035214246BF113352F1CD6688E28AB47C5B9E42C3ECA9845DADA08536C448A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AxisUNO.Presentation.Controls.CustomCommandBars
{
    partial class CustomCommandBar : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(global::Microsoft.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Windows.Input.ICommand value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Windows.Input.ICommand) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Windows.Input.ICommand), targetNullValue);
                }
                obj.Command = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CustomCommandBar_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ICustomCommandBar_Bindings
        {
            private global::AxisUNO.Presentation.Controls.CustomCommandBars.CustomCommandBar dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj6;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj7;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj8;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj9;
            private global::Microsoft.UI.Xaml.Controls.AppBarButton obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6CommandDisabled = false;
            private static bool isobj7CommandDisabled = false;
            private static bool isobj8CommandDisabled = false;
            private static bool isobj9CommandDisabled = false;
            private static bool isobj10CommandDisabled = false;

            public CustomCommandBar_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 60 && columnNumber == 81)
                {
                    isobj6CommandDisabled = true;
                }
                else if (lineNumber == 65 && columnNumber == 83)
                {
                    isobj7CommandDisabled = true;
                }
                else if (lineNumber == 70 && columnNumber == 87)
                {
                    isobj8CommandDisabled = true;
                }
                else if (lineNumber == 75 && columnNumber == 83)
                {
                    isobj9CommandDisabled = true;
                }
                else if (lineNumber == 80 && columnNumber == 87)
                {
                    isobj10CommandDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 60
                        this.obj6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                        break;
                    case 7: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 65
                        this.obj7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                        break;
                    case 8: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 70
                        this.obj8 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                        break;
                    case 9: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 75
                        this.obj9 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                        break;
                    case 10: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 80
                        this.obj10 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
                        }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ICustomCommandBar_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = global::WinRT.CastExtensions.As<global::AxisUNO.Presentation.Controls.CustomCommandBars.CustomCommandBar>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::AxisUNO.Presentation.Controls.CustomCommandBars.CustomCommandBar obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_AddCommand(obj.AddCommand, phase);
                        this.Update_EditCommand(obj.EditCommand, phase);
                        this.Update_CancelCommand(obj.CancelCommand, phase);
                        this.Update_DeleteCommand(obj.DeleteCommand, phase);
                    }
                }
            }
            private void Update_AddCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 60
                    if (!isobj6CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj6, obj, null);
                    }
                }
            }
            private void Update_EditCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 65
                    if (!isobj7CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj7, obj, null);
                    }
                }
            }
            private void Update_CancelCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 70
                    if (!isobj8CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj8, obj, null);
                    }
                    // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 75
                    if (!isobj9CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj9, obj, null);
                    }
                }
            }
            private void Update_DeleteCommand(global::System.Windows.Input.ICommand obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 80
                    if (!isobj10CommandDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_ButtonBase_Command(this.obj10, obj, null);
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 15
                {
                    this.CommandBarModeVisualState = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualStateGroup>(target);
                }
                break;
            case 3: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 16
                {
                    this.EditDeleteMode = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 4: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 30
                {
                    this.AddEditDeleteMode = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 5: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 43
                {
                    this.CancelSaveMode = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.VisualState>(target);
                }
                break;
            case 6: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 60
                {
                    this.addButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                }
                break;
            case 7: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 65
                {
                    this.editButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                }
                break;
            case 8: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 70
                {
                    this.cancelButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                }
                break;
            case 9: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 75
                {
                    this.saveButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                }
                break;
            case 10: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 80
                {
                    this.deleteButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // src\AxisUNO.Presentation\Controls\CustomCommandBars\CustomCommandBar.xaml line 1
                {                    
                    global::Microsoft.UI.Xaml.Controls.UserControl element1 = (global::Microsoft.UI.Xaml.Controls.UserControl)target;
                    CustomCommandBar_obj1_Bindings bindings = new CustomCommandBar_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
