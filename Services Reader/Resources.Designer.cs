﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicesReader {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ServicesReader.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to @echo off
        ///CLS
        ///
        ///@echo.
        ///@echo 	Script created: {0}
        ///@echo.
        ///@echo 	- - - - - - - - - - - - - - - - - -
        ///@echo.
        ///@echo 	All Services: {1}
        ///@echo.
        ///@echo 	Automatic (Delayed Start): {2}
        ///@echo 	Automatic: {3}
        ///@echo 	Manual: {4}
        ///@echo 	Disabled: {5}
        ///@echo 	Unknown: {6}
        ///@echo.
        ///@echo 	- - - - - - - - - - - - - - - - - -
        ///@echo.
        ///pause.
        /// </summary>
        internal static string FileHead {
            get {
                return ResourceManager.GetString("FileHead", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /select, &quot;{0}&quot;.
        /// </summary>
        internal static string FileSelect {
            get {
                return ResourceManager.GetString("FileSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon MainIcon {
            get {
                object obj = ResourceManager.GetObject("MainIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap RefreshImage {
            get {
                object obj = ResourceManager.GetObject("RefreshImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to choice /M &quot;Do you want restart copmuter&quot;
        ///
        ///if errorlevel 2 goto END
        ///if errorlevel 1 goto RESTART
        ///
        ///:RESTART
        ///shutdown -r -t 00
        ///goto END
        ///
        ///:END.
        /// </summary>
        internal static string RestartQuestion {
            get {
                return ResourceManager.GetString("RestartQuestion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap SaveImage {
            get {
                object obj = ResourceManager.GetObject("SaveImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} created successfully! :)
        ///
        ///Do you want open folder location?.
        /// </summary>
        internal static string SuccessMessage {
            get {
                return ResourceManager.GetString("SuccessMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatic.
        /// </summary>
        internal static string Type_Auto {
            get {
                return ResourceManager.GetString("Type_Auto", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Automatic (Delayed Start).
        /// </summary>
        internal static string Type_AutoDelayed {
            get {
                return ResourceManager.GetString("Type_AutoDelayed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Disabled.
        /// </summary>
        internal static string Type_Disabled {
            get {
                return ResourceManager.GetString("Type_Disabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manual.
        /// </summary>
        internal static string Type_Manual {
            get {
                return ResourceManager.GetString("Type_Manual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown.
        /// </summary>
        internal static string Type_Unknown {
            get {
                return ResourceManager.GetString("Type_Unknown", resourceCulture);
            }
        }
    }
}