//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.HBase {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.HBase.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Both Filter and FilterFile cannot be set at the same time.
        /// </summary>
        internal static string AmbiguousFilter {
            get {
                return ResourceManager.GetString("AmbiguousFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HBase connection string is required.
        /// </summary>
        internal static string ConnectionStringMissing {
            get {
                return ResourceManager.GetString("ConnectionStringMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to create HBase scanner. Server response: ({0}) {1}.
        /// </summary>
        internal static string FailedToCreateScannerFormat {
            get {
                return ResourceManager.GetString("FailedToCreateScannerFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to extract HBase table name and scanner id from the location header.
        /// </summary>
        internal static string InvalidScannerLocation {
            get {
                return ResourceManager.GetString("InvalidScannerLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected server response: ({0}) {1}.
        /// </summary>
        internal static string InvalidServerResponseFormat {
            get {
                return ResourceManager.GetString("InvalidServerResponseFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location header is missing from HBase create scanner response.
        /// </summary>
        internal static string ScannerLocationMissing {
            get {
                return ResourceManager.GetString("ScannerLocationMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HBase Stargate service URL should be provided as part of the connection string.
        /// </summary>
        internal static string ServiceUrlMissing {
            get {
                return ResourceManager.GetString("ServiceUrlMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reads data from HBase table using Stargate REST API.
        /// </summary>
        internal static string SourceDescription {
            get {
                return ResourceManager.GetString("SourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HBase source adapter should be initialized before it can be used.
        /// </summary>
        internal static string SourceIsNotInitialized {
            get {
                return ResourceManager.GetString("SourceIsNotInitialized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HBase table name should be provided.
        /// </summary>
        internal static string TableNameMissing {
            get {
                return ResourceManager.GetString("TableNameMissing", resourceCulture);
            }
        }
    }
}
