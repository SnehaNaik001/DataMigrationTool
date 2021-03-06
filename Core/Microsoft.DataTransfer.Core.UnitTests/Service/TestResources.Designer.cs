//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.DataTransfer.Core.UnitTests.Service {
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
    internal class TestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.DataTransfer.Core.UnitTests.Service.TestResources", typeof(TestResources).Assembly);
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
        ///   Looks up a localized string similar to Data sink adapter name provided in the transfer context is invalid.
        /// </summary>
        internal static string InvalidDataSinkNameInTransferContext {
            get {
                return ResourceManager.GetString("InvalidDataSinkNameInTransferContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data source adapter name provided in the transfer context is invalid.
        /// </summary>
        internal static string InvalidDataSourceNameInTransferContext {
            get {
                return ResourceManager.GetString("InvalidDataSourceNameInTransferContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of data items received by sink does not match those emitted by source.
        /// </summary>
        internal static string InvalidNumberOfDataItems {
            get {
                return ResourceManager.GetString("InvalidNumberOfDataItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid number of transfer exceptions reported after the transfer.
        /// </summary>
        internal static string InvalidNumberOfTransferExceptions {
            get {
                return ResourceManager.GetString("InvalidNumberOfTransferExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data received by sink is null.
        /// </summary>
        internal static string NullDataInSink {
            get {
                return ResourceManager.GetString("NullDataInSink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Statistics snapshot is null.
        /// </summary>
        internal static string NullStatisticsSnapshot {
            get {
                return ResourceManager.GetString("NullStatisticsSnapshot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No exceptions were reported during the transfer.
        /// </summary>
        internal static string NullTransferExceptions {
            get {
                return ResourceManager.GetString("NullTransferExceptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Data received by sink doesn&apos;t match to what was emitted by source.
        /// </summary>
        internal static string ReceivedDataDoesNotMatch {
            get {
                return ResourceManager.GetString("ReceivedDataDoesNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elapsed time recorded by statistics is empty.
        /// </summary>
        internal static string StatisticsElapsedTimeIsEmpty {
            get {
                return ResourceManager.GetString("StatisticsElapsedTimeIsEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Errors recorded by statistics are invalid.
        /// </summary>
        internal static string StatisticsInvalidErrors {
            get {
                return ResourceManager.GetString("StatisticsInvalidErrors", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of failed items recorded by statistics is invalid.
        /// </summary>
        internal static string StatisticsInvalidFailedCount {
            get {
                return ResourceManager.GetString("StatisticsInvalidFailedCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Number of transferred items recorded by statistics is invalid.
        /// </summary>
        internal static string StatisticsInvalidTransferredCount {
            get {
                return ResourceManager.GetString("StatisticsInvalidTransferredCount", resourceCulture);
            }
        }
    }
}
