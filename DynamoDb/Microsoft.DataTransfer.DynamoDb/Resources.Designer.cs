//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.DynamoDb {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.DynamoDb.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Amazon DynamoDB access key is required.
        /// </summary>
        internal static string AccessKeyMissing {
            get {
                return ResourceManager.GetString("AccessKeyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Both Request and RequestFile cannot be set at the same time.
        /// </summary>
        internal static string AmbiguousRequest {
            get {
                return ResourceManager.GetString("AmbiguousRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Amazon DynamoDB connection string is required.
        /// </summary>
        internal static string ConnectionStringMissing {
            get {
                return ResourceManager.GetString("ConnectionStringMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Item {0}.
        /// </summary>
        internal static string DataItemIdFormat {
            get {
                return ResourceManager.GetString("DataItemIdFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to list tables. Server response: {0}.
        /// </summary>
        internal static string FailedToListTablesFormat {
            get {
                return ResourceManager.GetString("FailedToListTablesFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-empty DynamoDB request should be provided.
        /// </summary>
        internal static string RequestMissing {
            get {
                return ResourceManager.GetString("RequestMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Amazon DynamoDB secret key is required.
        /// </summary>
        internal static string SecretKeyMissing {
            get {
                return ResourceManager.GetString("SecretKeyMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Amazon DynamoDB service URL should be provided as part of the connection string.
        /// </summary>
        internal static string ServiceUrlMissing {
            get {
                return ResourceManager.GetString("ServiceUrlMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reads data from Amazon DynamoDB tables.
        /// </summary>
        internal static string SourceDescription {
            get {
                return ResourceManager.GetString("SourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &quot;{0}&quot; is not supported by the &quot;{1}&quot; converter.
        /// </summary>
        internal static string TypeConversionNotSupportedFormat {
            get {
                return ResourceManager.GetString("TypeConversionNotSupportedFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token of type &quot;{0}&quot; cannot be used to represent binary data.
        /// </summary>
        internal static string UnsupportedBinaryFormatFormat {
            get {
                return ResourceManager.GetString("UnsupportedBinaryFormatFormat", resourceCulture);
            }
        }
    }
}
