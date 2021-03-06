﻿' Developer Express Code Central Example:
' How to create Checkable Grouping in GridControl
' 
' The example demonstrates how to add the CheckBox functionality to each GroupRow
' in TableView. The basic idea is to allow a user to easily check or uncheck the
' necessary group of items in GridControl.
' 
' The functionality is realized as
' behavior in the CheckableGroupBehavior class, which can be attached to
' GridControl. It automatically sets GroupValueTemplate using the GroupCheckBox
' class, which is inherited from the CheckBox class. The CheckableGroupBehavior's
' CheckableProperty must be set and has to contain the name of the property in a
' row data object, which will be used to check items. The property has to be of
' the Boolean type.
' 
' You can easily add the same functionality to your project by
' using the CheckableGroupBehavior class and attaching it as behavior to your
' GridControl.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T127563

Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("DevExpress.Example03")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("DevExpress.Example03")>
<Assembly: AssemblyCopyright("Copyright ©  2014")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)> 'where the generic resource dictionary is located - where theme specific resource dictionaries are located
    '(used if a resource is not found in the page, 
    ' or application resource dictionaries)
    '(used if a resource is not found in the page, 
    ' app, or any theme specific resource dictionaries)


' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
