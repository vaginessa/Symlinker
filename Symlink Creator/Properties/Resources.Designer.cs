﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Symlink_Creator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Symlink_Creator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to © 2010-2015 Alejandro Mora
        ///Version: {0}
        ///e-mail: mail@alejandro.md
        ///
        ///Thanks to Microsoft for the use of their shortcut arrow :).
        /// </summary>
        internal static string AboutDescription {
            get {
                return ResourceManager.GetString("AboutDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the file needed to create links, the creation stopped.
        /// </summary>
        internal static string CmdNotFound {
            get {
                return ResourceManager.GetString("CmdNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The link name you are using already exists in the selected directory, would you like to DELETE the file and then create a new link?.
        /// </summary>
        internal static string DialogDeleteFile {
            get {
                return ResourceManager.GetString("DialogDeleteFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File already there....
        /// </summary>
        internal static string DialogDeleteFileWarning {
            get {
                return ResourceManager.GetString("DialogDeleteFileWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The link name you are using already exists in the selected directory, would you like to DELETE the folder and then create a new link?.
        /// </summary>
        internal static string DialogFolderExists {
            get {
                return ResourceManager.GetString("DialogFolderExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Folder already there....
        /// </summary>
        internal static string DialogFolderExistsDialog {
            get {
                return ResourceManager.GetString("DialogFolderExistsDialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One of the directories/files does not exists, please provide valid directories/files.
        /// </summary>
        internal static string FilesOrFolderNotExists {
            get {
                return ResourceManager.GetString("FilesOrFolderNotExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please fill all the blanks spaces with the indicated info.
        /// </summary>
        internal static string FillBlanks {
            get {
                return ResourceManager.GetString("FillBlanks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon icon {
            get {
                object obj = ResourceManager.GetObject("icon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap info {
            get {
                object obj = ResourceManager.GetObject("info", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link creation aborted.
        /// </summary>
        internal static string LinkCreationAborted {
            get {
                return ResourceManager.GetString("LinkCreationAborted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aborted Operation.
        /// </summary>
        internal static string LinkCreationAbortedWarning {
            get {
                return ResourceManager.GetString("LinkCreationAbortedWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link successfully created.
        /// </summary>
        internal static string LinkSuccessfullyCreated {
            get {
                return ResourceManager.GetString("LinkSuccessfullyCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination File.
        /// </summary>
        internal static string MainWindow_Switcher_Destination_File {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Destination_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Destination Folder.
        /// </summary>
        internal static string MainWindow_Switcher_Destination_Folder {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Destination_Folder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link File.
        /// </summary>
        internal static string MainWindow_Switcher_Link_File {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Link_File", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Link Folder.
        /// </summary>
        internal static string MainWindow_Switcher_Link_Folder {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Link_Folder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Now give a name to the link:.
        /// </summary>
        internal static string MainWindow_Switcher_Now_give_a_name_to_the_link_ {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Now_give_a_name_to_the_link_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Now give a name to your file:.
        /// </summary>
        internal static string MainWindow_Switcher_Now_give_a_name_to_your_file_ {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Now_give_a_name_to_your_file_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select the path to the real file you want to link:.
        /// </summary>
        internal static string MainWindow_Switcher_Please_select_the_path_to_the_real_file_you_want_to_link_ {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Please_select_the_path_to_the_real_file_you_want_to_link_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select the path to the real folder you want to link:.
        /// </summary>
        internal static string MainWindow_Switcher_Please_select_the_path_to_the_real_folder_you_want_to_link_ {
            get {
                return ResourceManager.GetString("MainWindow_Switcher_Please_select_the_path_to_the_real_folder_you_want_to_link_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About.
        /// </summary>
        internal static string MessageBoxAboutTitle {
            get {
                return ResourceManager.GetString("MessageBoxAboutTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        internal static string MessageBoxErrorTitle {
            get {
                return ResourceManager.GetString("MessageBoxErrorTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has ocurred:.
        /// </summary>
        internal static string MessageBoxExceptionOcurred {
            get {
                return ResourceManager.GetString("MessageBoxExceptionOcurred", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Success.
        /// </summary>
        internal static string MessageBoxSuccessTitle {
            get {
                return ResourceManager.GetString("MessageBoxSuccessTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to With this option you can choose between creating file symbolic links; \nthis is using a file to point to another file, or folder symbolic links; this \nis using folders that point to other folders.
        /// </summary>
        internal static string TooltipTypeSelectorDescription {
            get {
                return ResourceManager.GetString("TooltipTypeSelectorDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Symbolic Link type selector.
        /// </summary>
        internal static string TooltipTypeSelectorTitle {
            get {
                return ResourceManager.GetString("TooltipTypeSelectorTitle", resourceCulture);
            }
        }
    }
}
