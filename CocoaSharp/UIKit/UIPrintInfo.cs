using ObjectiveC;using System;using SharpSwift.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// A UIPrintInfo object encapsulates information about a print job, including printer identifier, job name, output type (photo, normal, grayscale), orientation (portrait or landscape), and any selected duplex mode. This information is used by the printing system when it prints.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UIPrintInfo_Class/index.html#//apple_ref/occ/cl/UIPrintInfo"/>    [iOSVersion(4.2)]    public class UIPrintInfo : NSObject//, AnyObject, NSCoding, NSCopying, NSObjectProtocol    {        /// <summary>        /// Returns a print-information object that is initialized with the data in the passed-in dictionary.        /// </summary>        /// <param name="dictionary">A dictionary that contains data to initialize the UIPrintInfo object with.</param>        [iOSVersion(4.2)]        public UIPrintInfo(Dictionary<NSObject, AnyObject> dictionary) { }                /// <summary>        /// Returns a dictionary representation of a print-information object.        /// </summary>        [iOSVersion(4.2)]        [Export("dictionaryRepresentation")]        public Dictionary<NSObject, AnyObject> DictionaryRepresentation() { return default(Dictionary<NSObject, AnyObject>); }                /// <summary>        /// Specifies the duplex mode to use for the print job.        /// </summary>        [iOSVersion(4.2)]        [Export("duplex")]        public UIPrintInfoDuplex Duplex { get; set; }                /// <summary>        /// The name of the print job.        /// </summary>        [iOSVersion(4.2)]        [Export("jobName")]        public string JobName { get; set; }                /// <summary>        /// The orientation of the printed content, portrait or landscape.        /// </summary>        [iOSVersion(4.2)]        [Export("orientation")]        public UIPrintInfoOrientation Orientation { get; set; }                /// <summary>        /// The kind of printable content.        /// </summary>        [iOSVersion(4.2)]        [Export("outputType")]        public UIPrintInfoOutputType OutputType { get; set; }                /// <summary>        /// An identifier of the printer to use for the print job.        /// </summary>        [iOSVersion(4.2)]        [Export("printerID")]        public string PrinterID { get; set; }    }    /// <summary>    /// The duplex mode of a selected printer.    /// </summary>    [iOSVersion(4.2)]    public enum UIPrintInfoDuplex    {        /// <summary>        /// No double-sided (duplex) printing; single-sided printing only.        /// </summary>        [iOSVersion(4.2)]        None,        /// <summary>        /// Duplex printing that flips the back page along the long edge of the paper.        /// </summary>        [iOSVersion(4.2)]        LongEdge,        /// <summary>        /// Duplex print that flips the back page along the short edge of the paper.        /// </summary>        [iOSVersion(4.2)]        ShortEdge,    }    /// <summary>    /// The orientation of printing on a page.    /// </summary>    [iOSVersion(4.2)]    public enum UIPrintInfoOrientation    {        /// <summary>        /// Pages are printed in portrait orientation.        /// </summary>        [iOSVersion(4.2)]        Portrait,        /// <summary>        /// Pages are printed in landscape orientation.        /// </summary>        [iOSVersion(4.2)]        Landscape,    }    /// <summary>    /// The output type, which is an indication of the type of content the application is drawing or providing.    /// </summary>    [iOSVersion(4.2)]    public enum UIPrintInfoOutputType    {        /// <summary>        /// Specifies that the printed content consists of mixed text, graphics, and images. The default paper is Letter, A4, or similar locale-specific designation. Output is normal quality, duplex.        /// </summary>        [iOSVersion(4.2)]        General,        /// <summary>        /// Specifies that the printed content consists of black-and-white or color images. The default paper is 4x6, A6, or similar locale-specific designation. Output is high quality, simplex.        /// </summary>        [iOSVersion(4.2)]        Photo,        /// <summary>        /// Specifies that the printed content is grayscale. Set the output type to this value when your printable content contains no color—for example, it’s black text only. The default paper is Letter/A4. Output is grayscale quality, duplex. This content type can produce a performance improvement in some cases.        /// </summary>        [iOSVersion(4.2)]        Grayscale,        /// <summary>        /// Specifies that the printed content is a grayscale image. Set the output type to this value when your printable content contains no color—for example, it’s black text only. The default paper is Letter/A4. Output is high quality grayscale, duplex.        /// </summary>        [iOSVersion(7)]        PhotoGrayscale,    }}