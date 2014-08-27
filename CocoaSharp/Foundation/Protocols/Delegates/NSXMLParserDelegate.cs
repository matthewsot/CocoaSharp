using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// The NSXMLParserDelegate protocol defines the optional methods implemented by delegates of NSXMLParser objects.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSXMLParserDelegate_Protocol/index.html#//apple_ref/occ/intf/NSXMLParserDelegate"/>    [iOSVersion(4)]    public interface NSXMLParserDelegate//: NSObjectProtocol    {        /// <summary>        /// Sent by the parser object to the delegate when it begins parsing a document.        /// </summary>        /// <param name="parser">A parser object.</param>        [iOSVersion(2)]        [Export("parserDidStartDocument")]        void ParserDidStartDocument(NSXMLParser parser);                /// <summary>        /// Sent by the parser object to the delegate when it has successfully completed parsing.        /// </summary>        /// <param name="parser">A parser object.</param>        [iOSVersion(2)]        [Export("parserDidEndDocument")]        void ParserDidEndDocument(NSXMLParser parser);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a start tag for a given element.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="didStartElement">A string that is the name of an element (in its start tag).</param>        /// <param name="namespaceURI">If namespace processing is turned on, contains the URI for the current namespace as a string object.</param>        /// <param name="qualifiedName">If namespace processing is turned on, contains the qualified name for the current namespace as a string object.</param>        /// <param name="attributes">A dictionary that contains any attributes associated with the element. Keys are the names of attributes, and values are attribute values.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, string didStartElement, string namespaceURI, string qualifiedName, Dictionary<NSObject, AnyObject> attributes);                /// <summary>        /// Sent by a parser object to its delegate when it encounters an end tag for a specific element.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="didEndElement">A string that is the name of an element (in its end tag).</param>        /// <param name="namespaceURI">If namespace processing is turned on, contains the URI for the current namespace as a string object.</param>        /// <param name="qualifiedName">If namespace processing is turned on, contains the qualified name for the current namespace as a string object.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, string didEndElement, string namespaceURI, string qualifiedName);                /// <summary>        /// Sent by a parser object to its delegate the first time it encounters a given namespace prefix, which is mapped to a URI.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="didStartMappingPrefix">A string that is a namespace prefix.</param>        /// <param name="toURI">A string that specifies a namespace URI.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, string didStartMappingPrefix, string toURI);                /// <summary>        /// Sent by a parser object to its delegate when a given namespace prefix goes out of scope.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="didEndMappingPrefix">A string that is a namespace prefix.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, string didEndMappingPrefix);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a given external entity with a specific system ID.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="resolveExternalEntityName">A string that specifies the external name of an entity.</param>        /// <param name="systemID">A string that specifies the system ID for the external entity.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        NSData Parser(NSXMLParser parser, string resolveExternalEntityName, string systemID, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a fatal error.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="parseErrorOccurred">An NSError object describing the parsing error that occurred.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, NSError parseErrorOccurred);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a fatal validation error. NSXMLParser currently does not invoke this method and does not perform validation.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="validationErrorOccurred">An NSError object describing the validation error that occurred.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, NSError validationErrorOccurred, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent by a parser object to provide its delegate with a string representing all or part of the characters of the current element.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="foundCharacters">A string representing the complete or partial textual content of the current element.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundCharacters, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Reported by a parser object to provide its delegate with a string representing all or part of the ignorable whitespace characters of the current element.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="foundIgnorableWhitespace">A string representing all or part of the ignorable whitespace characters of the current element.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundIgnorableWhitespace, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a processing instruction.        /// </summary>        /// <param name="parser">A parser object.</param>        /// <param name="foundProcessingInstructionWithTarget">A string representing the target of a processing instruction.</param>        /// <param name="data">A string representing the data for a processing instruction.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundProcessingInstructionWithTarget, string data, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a comment in the XML.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundComment">A string that is a the content of a comment in the XML.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundComment, uint NAME_YOUR_PARAMS = 0);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a CDATA block.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundCDATA">A data object containing a block of CDATA.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, NSData foundCDATA);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a declaration of an attribute that is associated with a specific element.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundAttributeDeclarationWithName">A string that is the name of an attribute.</param>        /// <param name="forElement">A string that is the name of an element that has the attribute attributeName.</param>        /// <param name="type">A string, such as &quot;ENTITY&quot;, &quot;NOTATION&quot;, or &quot;ID&quot;, that indicates the type of the attribute.</param>        /// <param name="defaultValue">A string that specifies the default value of the attribute.</param>        [iOSVersion(2)]        [Export("parser")]        void Parser(NSXMLParser parser, string foundAttributeDeclarationWithName, string forElement, string type, string defaultValue);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a declaration of an element with a given model.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundElementDeclarationWithName">A string that is the name of an element.</param>        /// <param name="model">A string that specifies a model for elementName.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundElementDeclarationWithName, string model, UInt16 NAME_YOUR_PARAMS = 2);                /// <summary>        /// Sent by a parser object to its delegate when it encounters an external entity declaration.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundExternalEntityDeclarationWithName">A string that is the name of an entity.</param>        /// <param name="publicID">A string that specifies the public ID associated with entityName.</param>        /// <param name="systemID">A string that specifies the system ID associated with entityName.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundExternalEntityDeclarationWithName, string publicID, string systemID, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent by a parser object to the delegate when it encounters an internal entity declaration.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundInternalEntityDeclarationWithName">A string that is the declared name of an internal entity.</param>        /// <param name="value">A string that is the value of entity name.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundInternalEntityDeclarationWithName, string value, double NAME_YOUR_PARAMS = 4.2);                /// <summary>        /// Sent by a parser object to its delegate when it encounters an unparsed entity declaration.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundUnparsedEntityDeclarationWithName">A string that is the name of the unparsed entity in the declaration.</param>        /// <param name="publicID">A string specifying the public ID associated with the entity name.</param>        /// <param name="systemID">A string specifying the system ID associated with the entity name.</param>        /// <param name="notationName">A string specifying a notation of the declaration of entity name.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundUnparsedEntityDeclarationWithName, string publicID, string systemID, string notationName, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Sent by a parser object to its delegate when it encounters a notation declaration.        /// </summary>        /// <param name="parser">An NSXMLParser object parsing XML.</param>        /// <param name="foundNotationDeclarationWithName">A string that is the name of the notation.</param>        /// <param name="publicID">A string specifying the public ID associated with the notation name.</param>        /// <param name="systemID">A string specifying the system ID associated with the notation name.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("parser")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        void Parser(NSXMLParser parser, string foundNotationDeclarationWithName, string publicID, string systemID, int NAME_YOUR_PARAMS = 0);    }}