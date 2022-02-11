﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.MongoDb {
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
    public class ConfigurationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConfigurationResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.MongoDb.ConfigurationResources", typeof(ConfigurationResources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. If source files should be decompressed with GZip.
        /// </summary>
        public static string MongoexportSource_Decompress {
            get {
                return ResourceManager.GetString("MongoexportSource_Decompress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more file search patterns to read MongoDB export (mongoexport) JSON from.
        /// </summary>
        public static string MongoexportSource_Files {
            get {
                return ResourceManager.GetString("MongoexportSource_Files", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name of the documents collection.
        /// </summary>
        public static string Online_Collection {
            get {
                return ResourceManager.GetString("Online_Collection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Connection string including database name (example: &quot;mongodb://localhost/database&quot;).
        /// </summary>
        public static string Online_ConnectionString {
            get {
                return ResourceManager.GetString("Online_ConnectionString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Document that defines fields to include or exclude (example: {&quot;state&quot;: true, &quot;city&quot;: true} or {&quot;state&quot;:1, &quot;city&quot;:1}).
        /// </summary>
        public static string OnlineSource_Projection {
            get {
                return ResourceManager.GetString("OnlineSource_Projection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Path to the file containing projection document.
        /// </summary>
        public static string OnlineSource_ProjectionFile {
            get {
                return ResourceManager.GetString("OnlineSource_ProjectionFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Mongo query document.
        /// </summary>
        public static string OnlineSource_Query {
            get {
                return ResourceManager.GetString("OnlineSource_Query", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Optional. Path to the file containing query document.
        /// </summary>
        public static string OnlineSource_QueryFile {
            get {
                return ResourceManager.GetString("OnlineSource_QueryFile", resourceCulture);
            }
        }
    }
}