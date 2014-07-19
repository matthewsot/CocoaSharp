using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSNetService_Class/index.html#//apple_ref/occ/cl/NSNetService
    /// <summary>
    /// The NSNetService class represents a network service that your application publishes or uses as a client. This class and the NSNetServiceBrowser class use multicast DNS to convey information about network services to and from your application. The API of NSNetService provides a convenient way to publish the services offered by your application and to resolve the socket address for a service.
    /// </summary>
    [iOSVersion(2)]
    public class NSNetService : NSObject
    {
        /// <summary>
        /// Returns the receiver, initialized as a network service of a given type and sets the initial host information.
        /// </summary>
        /// <param name="domain">The domain for the service. To resolve in the default domains, pass in an empty string (@&quot;&quot;). To limit resolution to the local domain, use @&quot;local.&quot;.   If you are creating this object to resolve a service whose information your app stored previously, you should set this to the domain in which the service was originally discovered.   You can also use a NSNetServiceBrowser object to obtain a list of possible domains in which you can discover and resolve services.</param>
        /// <param name="type">The network service type.   type must contain both the service type and transport layer information. To ensure that the mDNS responder searches for services, as opposed to hosts, prefix both the service name and transport layer name with an underscore character (“_”). For example, to search for an HTTP service on TCP, you would use the type string &quot;_http._tcp.&quot;. Note that the period character at the end of the string, which indicates that the domain name is an absolute name, is required.</param>
        /// <param name="name">The name of the service to resolve.</param>
        /// <returns>The receiver, initialized as a network service named name of type type in the domain domain.</returns>
        [iOSVersion(2)]
        public NSNetService(string domain, string type, string name) { }
        
        /// <summary>
        /// Initializes the receiver for publishing a network service of type type at the socket location specified by domain, name, and port.
        /// </summary>
        /// <param name="domain">The domain for the service. To use the default registration domains, pass in an empty string (@&quot;&quot;). To limit registration to the local domain, use @&quot;local.&quot;.   You can also use a NSNetServiceBrowser object to obtain a list of possible domains in which you can publish your service.</param>
        /// <param name="type">The network service type.   type must contain both the service type and transport layer information. To ensure that the mDNS responder searches for services, as opposed to hosts, prefix both the service name and transport layer name with an underscore character (“_”). For example, to search for an HTTP service on TCP, you would use the type string &quot;_http._tcp.&quot;. Note that the period character at the end of the string, which indicates that the domain name is an absolute name, is required.</param>
        /// <param name="name">The name by which the service is identified to the network. The name must be unique. If you pass the empty string (@&quot;&quot;), the system automatically advertises your service using the computer name as the service name.</param>
        /// <param name="port">The port on which the service is published.   If you specify the NSNetServiceListenForConnections flag, you may pass zero (0), in which case the service automatically allocates an arbitrary (ephemeral) port for your service. When the delegate’s netServiceDidPublish: is called, you can determine the actual port chosen by calling the service object’s Backward Compatibility Note method or accessing the corresponding property.   If your app is listening for connections on its own, the value of port must be a port number acquired by your application for the service.</param>
        [iOSVersion(2)]
        public NSNetService(string domain, string type, string name, Cint port) { }
        
        /// <summary>
        /// Returns an NSData object representing a TXT record formed from a given dictionary.
        /// </summary>
        /// <param name="txtDictionary">A dictionary containing a TXT record.</param>
        /// <returns>An NSData object representing TXT data formed from txtDictionary. Fails an assertion if txtDictionary cannot be represented as an NSData object.</returns>
        [iOSVersion(2)]
        [Export("dataFromTXTRecordDictionary")]
        public static NSData DataFromTXTRecordDictionary(NSDictionary txtDictionary) { return null; }
        
        /// <summary>
        /// Returns a dictionary representing a TXT record given as an NSData object.
        /// </summary>
        /// <param name="txtData">A data object encoding a TXT record.</param>
        /// <returns>A dictionary representing txtData. The dictionary’s keys are NSString objects using UTF8 encoding. The values associated with all the dictionary’s keys are NSData objects that encapsulate strings or data.</returns>
        [iOSVersion(2)]
        [Export("dictionaryFromTXTRecordData")]
        public static NSDictionary DictionaryFromTXTRecordData(NSData txtData) { return null; }
        
        /// <summary>
        /// A read-only array containing NSData objects, each of which contains a socket address for the service. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("addresses")]
        public AnyObject[] Addresses { get; private set; }
        
        /// <summary>
        /// A string containing the domain for this service. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("domain")]
        public string Domain { get; private set; }
        
        /// <summary>
        /// Creates a pair of input and output streams for the receiver and returns a Boolean value that indicates whether they were retrieved successfully.
        /// </summary>
        /// <param name="inputStream">Upon return, the input stream for the receiver. Pass NULL if you do not need this stream.</param>
        /// <param name="outputStream">Upon return, the output stream for the receiver. Pass NULL if you do not need this stream.</param>
        /// <returns>true if the streams are created successfully, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("getInputStream")]
        public bool GetInputStream(CMutablePointer<NSInputStream> inputStream, CMutablePointer<NSOutputStream> outputStream) { return false; }
        
        /// <summary>
        /// A string containing the name of this service. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("name")]
        public string Name { get; private set; }
        
        /// <summary>
        /// The type of the published service. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("type")]
        public string Type { get; private set; }
        
        /// <summary>
        /// Returns the TXT record for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("TXTRecordData")]
        public NSData TXTRecordData() { return null; }
        
        /// <summary>
        /// Sets the TXT record for the receiver, and returns a Boolean value that indicates whether the operation was successful.
        /// </summary>
        /// <param name="recordData">The TXT record for the receiver.</param>
        /// <returns>true if recordData is successfully set as the TXT record, otherwise false.</returns>
        [iOSVersion(2)]
        [Export("setTXTRecordData")]
        public bool SetTXTRecordData(NSData recordData) { return false; }
        
        /// <summary>
        /// The delegate for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("delegate")]
        public NSNetServiceDelegate Delegate { get; set; }
        
        /// <summary>
        /// Adds the service to the specified run loop.
        /// </summary>
        /// <param name="aRunLoop">The run loop to which to add the receiver.</param>
        /// <param name="forMode">The run loop mode to which to add the receiver. Possible values for mode are discussed in the &quot;Constants&quot; section of NSRunLoop.</param>
        [iOSVersion(2)]
        [Export("scheduleInRunLoop")]
        public void ScheduleInRunLoop(NSRunLoop aRunLoop, string forMode) { }
        
        /// <summary>
        /// Removes the service from the given run loop for a given mode.
        /// </summary>
        /// <param name="aRunLoop">The run loop from which to remove the receiver.</param>
        /// <param name="forMode">The run loop mode from which to remove the receiver. Possible values for mode are discussed in the &quot;Constants&quot; section of NSRunLoop.</param>
        [iOSVersion(2)]
        [Export("removeFromRunLoop")]
        public void RemoveFromRunLoop(NSRunLoop aRunLoop, string forMode) { }
        
        /// <summary>
        /// Attempts to advertise the receiver’s on the network.
        /// </summary>
        [iOSVersion(2)]
        [Export("publish")]
        public void Publish() { }
        
        /// <summary>
        /// Attempts to advertise the receiver on the network, with the given options.
        /// </summary>
        /// <param name="serviceOptions">Options for the receiver. The supported options are described in NSNetServiceOptions.</param>
        [iOSVersion(2)]
        [Export("publishWithOptions")]
        public void PublishWithOptions(NSNetServiceOptions serviceOptions) { }
        
        /// <summary>
        /// Starts a resolve process for the receiver.				 		  Deprecation Statement		  		 Use resolveWithTimeout: instead.
        /// </summary>
        [Obsolete]
        [iOSVersion(2)]
        [Export("resolve")]
        public void Resolve() { }
        
        /// <summary>
        /// Starts a resolve process of a finite duration for the receiver.
        /// </summary>
        /// <param name="timeout">The maximum number of seconds to attempt a resolve. A value of 0.0 indicates no timeout and a resolve process of indefinite duration.</param>
        [iOSVersion(2)]
        [Export("resolveWithTimeout")]
        public void ResolveWithTimeout(NSTimeinterval timeout) { }
        
        /// <summary>
        /// The port on which the service is listening for connections. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("port")]
        public int Port { get; private set; }
        
        /// <summary>
        /// Starts the monitoring of TXT-record updates for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("startMonitoring")]
        public void StartMonitoring() { }
        
        /// <summary>
        /// Halts a currently running attempt to publish or resolve a service.
        /// </summary>
        [iOSVersion(2)]
        [Export("stop")]
        public void Stop() { }
        
        /// <summary>
        /// Stops the monitoring of TXT-record updates for the receiver.
        /// </summary>
        [iOSVersion(2)]
        [Export("stopMonitoring")]
        public void StopMonitoring() { }
        
        /// <summary>
        /// A string containing the DNS hostname for this service. (read-only)
        /// </summary>
        [iOSVersion(2)]
        [Export("hostName")]
        public string HostName { get; private set; }

        /// <summary>
        /// If an error occurs, the delegate error-handling methods return a dictionary with the following keys.
        /// </summary>
        
        /// <summary>
        /// This key identifies the error that occurred during the most recent operation.
        /// </summary>
        [iOSVersion(2)]
        public string NSNetServicesErrorCode { get; private set; }
        
        /// <summary>
        /// This key identifies the originator of the error, which is either the NSNetService object or the mach network layer. For most errors, you should not need the value provided by this key.
        /// </summary>
        [iOSVersion(2)]
        public string NSNetServicesErrorDomain { get; private set; }
    }

    /// <summary>
    /// These constants specify options for a network service.
    /// </summary>
    [iOSVersion(2)]
    public enum NSNetServiceOptions
    {
        /// <summary>
        /// Specifies that the network service should not rename itself in the event of a name collision.
        /// </summary>
        [iOSVersion(2)]
        NoAutoRename,

        /// <summary>
        /// Specifies that a TCP listener should be started for both IPv4 and IPv6 on the port specified by this service. If the listening port can't be opened, the service calls its delegate’s netService:didNotPublish: method to report the error.
        /// </summary>
        [iOSVersion(7)]
        ListenForConnections,
    }

    /// <summary>
    /// These constants identify errors that can occur when accessing net services.
    /// </summary>
    [iOSVersion(2)]
    public enum NSNetServicesError
    {
        /// <summary>
        /// An unknown error occurred.
        /// </summary>
        [iOSVersion(2)]
        UnknownError,

        /// <summary>
        /// The service could not be published because the name is already in use. The name could be in use locally or on another system.
        /// </summary>
        [iOSVersion(2)]
        CollisionError,

        /// <summary>
        /// The service could not be found on the network.
        /// </summary>
        [iOSVersion(2)]
        NotFoundError,

        /// <summary>
        /// The net service cannot process the request at this time. No additional information about the network state is known.
        /// </summary>
        [iOSVersion(2)]
        ActivityInProgress,

        /// <summary>
        /// An invalid argument was used when creating the NSNetService object.
        /// </summary>
        [iOSVersion(2)]
        BadArgumentError,

        /// <summary>
        /// The client canceled the action.
        /// </summary>
        [iOSVersion(2)]
        CancelledError,

        /// <summary>
        /// The net service was improperly configured.
        /// </summary>
        [iOSVersion(2)]
        InvalidError,

        /// <summary>
        /// The net service has timed out.
        /// </summary>
        [iOSVersion(2)]
        TimeoutError,
    }
}