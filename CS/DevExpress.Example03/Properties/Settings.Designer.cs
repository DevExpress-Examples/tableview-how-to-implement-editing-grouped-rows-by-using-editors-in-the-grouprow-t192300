﻿// Developer Express Code Central Example:
// How to create Checkable Grouping in GridControl
// 
// The example demonstrates how to add the CheckBox functionality to each GroupRow
// in TableView. The basic idea is to allow a user to easily check or uncheck the
// necessary group of items in GridControl.
// 
// The functionality is realized as
// behavior in the CheckableGroupBehavior class, which can be attached to
// GridControl. It automatically sets GroupValueTemplate using the GroupCheckBox
// class, which is inherited from the CheckBox class. The CheckableGroupBehavior's
// CheckableProperty must be set and has to contain the name of the property in a
// row data object, which will be used to check items. The property has to be of
// the Boolean type.
// 
// You can easily add the same functionality to your project by
// using the CheckableGroupBehavior class and attaching it as behavior to your
// GridControl.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=T127563

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevExpress.Example03.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}