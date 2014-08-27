using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;namespace Foundation{    /// <summary>    /// Instances of this class parse XML documents (including DTD declarations) in an event-driven manner. An NSXMLParser notifies its delegate about the items (elements, attributes, CDATA blocks, comments, and so on) that it encounters as it processes an XML document. It does not itself do anything with those parsed items except report them. It also reports parsing errors. For convenience, an NSXMLParser object in the following descriptions is sometimes referred to as a parser object. Unless used in a callback, the NSXMLParser is a thread-safe class as long as any given instance is only used in one thread.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSXMLParser_Class/index.html#//apple_ref/occ/cl/NSXMLParser"/>    [iOSVersion(2)]    public class NSXMLParser : NSObject//, AnyObject, NSObjectProtocol    {        /// <summary>        /// Initializes a parser with the XML content referenced by the given URL.        /// </summary>        /// <param name="contentsOfURL">An NSURL object specifying a URL. The URL must be fully qualified and refer to a scheme that is supported by the NSURL class.</param>        [iOSVersion(2)]        [Export("convenience init")]        public NSXMLParser(NSURL contentsOfURL) { }                /// <summary>        /// Initializes a parser with the XML contents encapsulated in a given data object.        /// </summary>        /// <param name="data">An NSData object containing XML markup.</param>        [iOSVersion(2)]        public NSXMLParser(NSData data) { }                /// <summary>        /// Initializes a parser with the XML contents from the specified stream and parses it..        /// </summary>        /// <param name="stream">The input stream. The content is incrementally loaded from the specified stream and parsed. The NSXMLParser will open the stream, and synchronously read from it without scheduling it.</param>        [iOSVersion(5)]        [Export("convenience init")]        public NSXMLParser(NSInputStream stream) { }                /// <summary>        /// Starts the event-driven parsing operation.        /// </summary>        [iOSVersion(2)]        [Export("parse")]        public bool Parse() { return default(bool); }                /// <summary>        /// Stops the parser object.        /// </summary>        [iOSVersion(2)]        [Export("abortParsing")]        public void AbortParsing() {  }                /// <summary>        /// A delegate object that receives messages about the parsing process.        /// </summary>        [iOSVersion(2)]        [Export("delegate")]        public NSXMLParserDelegate Delegate { get; set; }                /// <summary>        /// A Boolean value that determines whether the parser reports the namespaces and qualified names of elements.        /// </summary>        [iOSVersion(2)]        [Export("shouldProcessNamespaces")]        public bool ShouldProcessNamespaces { get; set; }                /// <summary>        /// A Boolean value that determines whether the parser reports the prefixes indicating the scope of namespace declarations.        /// </summary>        [iOSVersion(2)]        [Export("shouldReportNamespacePrefixes")]        public bool ShouldReportNamespacePrefixes { get; set; }                /// <summary>        /// A Boolean value that determines whether the parser reports declarations of external entities.        /// </summary>        [iOSVersion(2)]        [Export("shouldResolveExternalEntities")]        public bool ShouldResolveExternalEntities { get; set; }                /// <summary>        /// An NSError object from which you can obtain information about a parsing error. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("parserError")]        public NSError ParserError { get; private set; }                /// <summary>        /// The column number of the XML document being processed by the parser. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("columnNumber")]        public int ColumnNumber { get; private set; }                /// <summary>        /// The line number of the XML document being processed by the parser. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("lineNumber")]        public int LineNumber { get; private set; }                /// <summary>        /// The public identifier of the external entity referenced in the XML document. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("publicID")]        public string PublicID { get; private set; }                /// <summary>        /// The system identifier of the external entity referenced in the XML document. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("systemID")]        public string SystemID { get; private set; }    }    /// <summary>    /// The following error codes are defined by NSXMLParser. For error codes not listed here, see the <libxml/xmlerror.h> header file.    /// </summary>    [iOSVersion(2)]    public enum NSXMLParserError    {        /// <summary>        /// The parser object encountered an internal error.        /// </summary>        [iOSVersion(2)]        InternalError,        /// <summary>        /// The parser object ran out of memory.        /// </summary>        [iOSVersion(2)]        OutOfMemoryError,        /// <summary>        /// The parser object is unable to start parsing.        /// </summary>        [iOSVersion(2)]        DocumentStartError,        /// <summary>        /// The document is empty.        /// </summary>        [iOSVersion(2)]        EmptyDocumentError,        /// <summary>        /// The document ended unexpectedly.        /// </summary>        [iOSVersion(2)]        PrematureDocumentEndError,        /// <summary>        /// Invalid hexadecimal character reference encountered.        /// </summary>        [iOSVersion(2)]        InvalidHexCharacterRefError,        /// <summary>        /// Invalid decimal character reference encountered.        /// </summary>        [iOSVersion(2)]        InvalidDecimalCharacterRefError,        /// <summary>        /// Invalid character reference encountered.        /// </summary>        [iOSVersion(2)]        InvalidCharacterRefError,        /// <summary>        /// Invalid character encountered.        /// </summary>        [iOSVersion(2)]        InvalidCharacterError,        /// <summary>        /// Target of character reference cannot be found.        /// </summary>        [iOSVersion(2)]        CharacterRefAtEOFError,        /// <summary>        /// Invalid character found in the prolog.        /// </summary>        [iOSVersion(2)]        CharacterRefInPrologError,        /// <summary>        /// Invalid character found in the epilog.        /// </summary>        [iOSVersion(2)]        CharacterRefInEpilogError,        /// <summary>        /// Invalid character encountered in the DTD.        /// </summary>        [iOSVersion(2)]        CharacterRefInDTDError,        /// <summary>        /// Target of entity reference is not found.        /// </summary>        [iOSVersion(2)]        EntityRefAtEOFError,        /// <summary>        /// Invalid entity reference found in the prolog.        /// </summary>        [iOSVersion(2)]        EntityRefInPrologError,        /// <summary>        /// Invalid entity reference found in the epilog.        /// </summary>        [iOSVersion(2)]        EntityRefInEpilogError,        /// <summary>        /// Invalid entity reference found in the DTD.        /// </summary>        [iOSVersion(2)]        EntityRefInDTDError,        /// <summary>        /// Target of parsed entity reference is not found.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefAtEOFError,        /// <summary>        /// Target of parsed entity reference is not found in prolog.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefInPrologError,        /// <summary>        /// Target of parsed entity reference is not found in epilog.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefInEpilogError,        /// <summary>        /// Target of parsed entity reference is not found in internal subset.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefInInternalSubsetError,        /// <summary>        /// Entity reference is without name.        /// </summary>        [iOSVersion(2)]        EntityReferenceWithoutNameError,        /// <summary>        /// Entity reference is missing semicolon.        /// </summary>        [iOSVersion(2)]        EntityReferenceMissingSemiError,        /// <summary>        /// Parsed entity reference is without an entity name.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefNoNameError,        /// <summary>        /// Parsed entity reference is missing semicolon.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefMissingSemiError,        /// <summary>        /// Entity is not declared.        /// </summary>        [iOSVersion(2)]        UndeclaredEntityError,        /// <summary>        /// Cannot parse entity.        /// </summary>        [iOSVersion(2)]        UnparsedEntityError,        /// <summary>        /// Cannot parse external entity.        /// </summary>        [iOSVersion(2)]        EntityIsExternalError,        /// <summary>        /// Entity is a parameter.        /// </summary>        [iOSVersion(2)]        EntityIsParameterError,        /// <summary>        /// Document encoding is unknown.        /// </summary>        [iOSVersion(2)]        UnknownEncodingError,        /// <summary>        /// Document encoding is not supported.        /// </summary>        [iOSVersion(2)]        EncodingNotSupportedError,        /// <summary>        /// String is not started.        /// </summary>        [iOSVersion(2)]        StringNotStartedError,        /// <summary>        /// String is not closed.        /// </summary>        [iOSVersion(2)]        StringNotClosedError,        /// <summary>        /// Invalid namespace declaration encountered.        /// </summary>        [iOSVersion(2)]        NamespaceDeclarationError,        /// <summary>        /// Entity is not started.        /// </summary>        [iOSVersion(2)]        EntityNotStartedError,        /// <summary>        /// Entity is not finished.        /// </summary>        [iOSVersion(2)]        EntityNotFinishedError,        /// <summary>        /// Angle bracket is used in attribute.        /// </summary>        [iOSVersion(2)]        LessThanSymbolInAttributeError,        /// <summary>        /// Attribute is not started.        /// </summary>        [iOSVersion(2)]        AttributeNotStartedError,        /// <summary>        /// Attribute is not finished.        /// </summary>        [iOSVersion(2)]        AttributeNotFinishedError,        /// <summary>        /// Attribute doesn’t contain a value.        /// </summary>        [iOSVersion(2)]        AttributeHasNoValueError,        /// <summary>        /// Attribute is redefined.        /// </summary>        [iOSVersion(2)]        AttributeRedefinedError,        /// <summary>        /// Literal is not started.        /// </summary>        [iOSVersion(2)]        LiteralNotStartedError,        /// <summary>        /// Literal is not finished.        /// </summary>        [iOSVersion(2)]        LiteralNotFinishedError,        /// <summary>        /// Comment is not finished.        /// </summary>        [iOSVersion(2)]        CommentNotFinishedError,        /// <summary>        /// Processing instruction is not started.        /// </summary>        [iOSVersion(2)]        ProcessingInstructionNotStartedError,        /// <summary>        /// Processing instruction is not finished.        /// </summary>        [iOSVersion(2)]        ProcessingInstructionNotFinishedError,        /// <summary>        /// Notation is not started.        /// </summary>        [iOSVersion(2)]        NotationNotStartedError,        /// <summary>        /// Notation is not finished.        /// </summary>        [iOSVersion(2)]        NotationNotFinishedError,        /// <summary>        /// Attribute list is not started.        /// </summary>        [iOSVersion(2)]        AttributeListNotStartedError,        /// <summary>        /// Attribute list is not finished.        /// </summary>        [iOSVersion(2)]        AttributeListNotFinishedError,        /// <summary>        /// Mixed content declaration is not started.        /// </summary>        [iOSVersion(2)]        MixedContentDeclNotStartedError,        /// <summary>        /// Mixed content declaration is not finished.        /// </summary>        [iOSVersion(2)]        MixedContentDeclNotFinishedError,        /// <summary>        /// Element content declaration is not started.        /// </summary>        [iOSVersion(2)]        ElementContentDeclNotStartedError,        /// <summary>        /// Element content declaration is not finished.        /// </summary>        [iOSVersion(2)]        ElementContentDeclNotFinishedError,        /// <summary>        /// XML declaration is not started.        /// </summary>        [iOSVersion(2)]        XMLDeclNotStartedError,        /// <summary>        /// XML declaration is not finished.        /// </summary>        [iOSVersion(2)]        XMLDeclNotFinishedError,        /// <summary>        /// Conditional section is not started.        /// </summary>        [iOSVersion(2)]        ConditionalSectionNotStartedError,        /// <summary>        /// Conditional section is not finished.        /// </summary>        [iOSVersion(2)]        ConditionalSectionNotFinishedError,        /// <summary>        /// External subset is not finished.        /// </summary>        [iOSVersion(2)]        ExternalSubsetNotFinishedError,        /// <summary>        /// Document type declaration is not finished.        /// </summary>        [iOSVersion(2)]        DOCTYPEDeclNotFinishedError,        /// <summary>        /// Misplaced CDATA end string.        /// </summary>        [iOSVersion(2)]        MisplacedCDATAEndStringError,        /// <summary>        /// CDATA block is not finished.        /// </summary>        [iOSVersion(2)]        CDATANotFinishedError,        /// <summary>        /// Misplaced XML declaration.        /// </summary>        [iOSVersion(2)]        MisplacedXMLDeclarationError,        /// <summary>        /// Space is required.        /// </summary>        [iOSVersion(2)]        SpaceRequiredError,        /// <summary>        /// Separator is required.        /// </summary>        [iOSVersion(2)]        SeparatorRequiredError,        /// <summary>        /// Name token is required.        /// </summary>        [iOSVersion(2)]        NMTOKENRequiredError,        /// <summary>        /// Name is required.        /// </summary>        [iOSVersion(2)]        NAMERequiredError,        /// <summary>        /// CDATA is required.        /// </summary>        [iOSVersion(2)]        PCDATARequiredError,        /// <summary>        /// URI is required.        /// </summary>        [iOSVersion(2)]        URIRequiredError,        /// <summary>        /// Public identifier is required.        /// </summary>        [iOSVersion(2)]        PublicIdentifierRequiredError,        /// <summary>        /// Left angle bracket is required.        /// </summary>        [iOSVersion(2)]        LTRequiredError,        /// <summary>        /// Right angle bracket is required.        /// </summary>        [iOSVersion(2)]        GTRequiredError,        /// <summary>        /// Left angle bracket slash is required.        /// </summary>        [iOSVersion(2)]        LTSlashRequiredError,        /// <summary>        /// Equal sign expected.        /// </summary>        [iOSVersion(2)]        EqualExpectedError,        /// <summary>        /// Tag name mismatch.        /// </summary>        [iOSVersion(2)]        TagNameMismatchError,        /// <summary>        /// Unfinished tag found.        /// </summary>        [iOSVersion(2)]        UnfinishedTagError,        /// <summary>        /// Standalone value found.        /// </summary>        [iOSVersion(2)]        StandaloneValueError,        /// <summary>        /// Invalid encoding name found.        /// </summary>        [iOSVersion(2)]        InvalidEncodingNameError,        /// <summary>        /// Comment contains double hyphen.        /// </summary>        [iOSVersion(2)]        CommentContainsDoubleHyphenError,        /// <summary>        /// Invalid encoding.        /// </summary>        [iOSVersion(2)]        InvalidEncodingError,        /// <summary>        /// External standalone entity.        /// </summary>        [iOSVersion(2)]        ExternalStandaloneEntityError,        /// <summary>        /// Invalid conditional section.        /// </summary>        [iOSVersion(2)]        InvalidConditionalSectionError,        /// <summary>        /// Entity value is required.        /// </summary>        [iOSVersion(2)]        EntityValueRequiredError,        /// <summary>        /// Document is not well balanced.        /// </summary>        [iOSVersion(2)]        NotWellBalancedError,        /// <summary>        /// Error in content found.        /// </summary>        [iOSVersion(2)]        ExtraContentError,        /// <summary>        /// Invalid character in entity found.        /// </summary>        [iOSVersion(2)]        InvalidCharacterInEntityError,        /// <summary>        /// Internal error in parsed entity reference found.        /// </summary>        [iOSVersion(2)]        ParsedEntityRefInInternalError,        /// <summary>        /// Entity reference loop encountered.        /// </summary>        [iOSVersion(2)]        EntityRefLoopError,        /// <summary>        /// Entity boundary error.        /// </summary>        [iOSVersion(2)]        EntityBoundaryError,        /// <summary>        /// Invalid URI specified.        /// </summary>        [iOSVersion(2)]        InvalidURIError,        /// <summary>        /// URI fragment.        /// </summary>        [iOSVersion(2)]        URIFragmentError,        /// <summary>        /// Missing DTD.        /// </summary>        [iOSVersion(2)]        NoDTDError,        /// <summary>        /// Delegate aborted parse.        /// </summary>        [iOSVersion(2)]        DelegateAbortedParseError,    }}