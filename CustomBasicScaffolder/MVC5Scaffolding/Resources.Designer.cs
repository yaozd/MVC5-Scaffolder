﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Happy.Scaffolding.MVC {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Happy.Scaffolding.MVC.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon Application {
            get {
                object obj = ResourceManager.GetObject("Application", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generates ASP.NET MVC controller and views for C.R.U.D (inserting, editing, deleting, and listing) from an Entity Framework data context..
        /// </summary>
        internal static string MVCScaffolder_Description {
            get {
                return ResourceManager.GetString("MVCScaffolder_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generates ASP.NET MVC controller and list view from an Entity Framework data context ( method from Store Procedure ) ..
        /// </summary>
        internal static string MVCScaffolder_Description2 {
            get {
                return ResourceManager.GetString("MVCScaffolder_Description2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Happy Scaffolding for MVC.
        /// </summary>
        internal static string MVCScaffolder_Name {
            get {
                return ResourceManager.GetString("MVCScaffolder_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Happy Scaffolding for MVC (Store Procedure).
        /// </summary>
        internal static string MVCScaffolder_Name2 {
            get {
                return ResourceManager.GetString("MVCScaffolder_Name2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add new data context....
        /// </summary>
        internal static string WebFormsCodeGeneratorViewModel_AddNewDbContext {
            get {
                return ResourceManager.GetString("WebFormsCodeGeneratorViewModel_AddNewDbContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generates ASP.NET MVC controller and views for inserting, editing, deleting, and listing entities from an Entity Framework data context and model class..
        /// </summary>
        internal static string WebFormsScaffolder_Description {
            get {
                return ResourceManager.GetString("WebFormsScaffolder_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASP.NET MVC using Entity Framework.
        /// </summary>
        internal static string WebFormsScaffolder_Name {
            get {
                return ResourceManager.GetString("WebFormsScaffolder_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to load the model type. If the project is not built, try building the project..
        /// </summary>
        internal static string WebFormsScaffolder_ProjectNotBuilt {
            get {
                return ResourceManager.GetString("WebFormsScaffolder_ProjectNotBuilt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose a valid DbContext class..
        /// </summary>
        internal static string WebFormsScaffolder_SelectDbContextType {
            get {
                return ResourceManager.GetString("WebFormsScaffolder_SelectDbContextType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please choose a valid model class..
        /// </summary>
        internal static string WebFormsScaffolder_SelectModelType {
            get {
                return ResourceManager.GetString("WebFormsScaffolder_SelectModelType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ShowUIAndValidate needs to be called prior to this method..
        /// </summary>
        internal static string WebFormsScaffolder_ShowUIAndValidateNotCalled {
            get {
                return ResourceManager.GetString("WebFormsScaffolder_ShowUIAndValidateNotCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Action name cannot be null or empty..
        /// </summary>
        internal static string WebFormsViewScaffolder_EmptyActionName {
            get {
                return ResourceManager.GetString("WebFormsViewScaffolder_EmptyActionName", resourceCulture);
            }
        }
    }
}