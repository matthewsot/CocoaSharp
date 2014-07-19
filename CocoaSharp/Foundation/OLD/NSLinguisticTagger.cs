using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/NSLinguisticTagger_Class/index.html#//apple_ref/occ/cl/NSLinguisticTagger
    /// <summary>
    /// The NSLinguisticTagger class is used to automatically segment natural-language text and tag it with information, such as parts of speech. It can also tag languages, scripts, stem forms of words, etc. An instance of this class is assigned a string to tag, and clients can then obtain tags and ranges for tokens in that string appropriate to a given tag scheme.
    /// </summary>
    [iOSVersion(5)]
    public class NSLinguisticTagger : NSObject
    {
        /// <summary>
        /// Creates a linguistic tagger instance using the specified tag schemes and options.
        /// </summary>
        /// <param name="tagSchemes">An array of tag schemes. See Linguistic Tag Schemes for the possible values.</param>
        /// <param name="options">The linguistic tagger options to use. See NSLinguisticTaggerOptions for the constants. These constants can be combined using the C-Bitwise OR operator.</param>
        /// <returns>An initialized linguistic tagger.</returns>
        [iOSVersion(5)]
        public NSLinguisticTagger(AnyObject[] tagSchemes, int options) { }
        
        /// <summary>
        /// Returns the tag schemes supported by the linguistic tagger for a particular language.
        /// </summary>
        /// <returns>An array of tag schemes. See Linguistic Tag Schemes for the possible values.</returns>
        [iOSVersion(5)]
        [Export("tagSchemes")]
        public AnyObject[] TagSchemes { get; private set; }
        
        /// <summary>
        /// Returns the tag schemes supported by the linguistic tagger for a particular language.
        /// </summary>
        /// <param name="language">A standard abbreviation as with NSOrthography.</param>
        /// <returns>An array of Linguistic Tag Schemes.</returns>
        [iOSVersion(5)]
        [Export("availableTagSchemesForLanguage")]
        public static AnyObject[] AvailableTagSchemesForLanguage(string language) { return null; }
        
        /// <summary>
        /// Returns the string being analyzed by the linguistic tagger.
        /// </summary>
        /// <returns>The string.</returns>
        [iOSVersion(5)]
        [Export("string")]
        public string String { get; set; }
        
        /// <summary>
        /// Notifies the linguistic tagger that the string (if mutable) has changed as specified by the parameters.
        /// </summary>
        /// <param name="newCharRange">The range in the final string that was edited.</param>
        /// <param name="changeInLength">The change in length.</param>
        [iOSVersion(5)]
        [Export("stringEditedInRange")]
        public void StringEditedInRange(NSRange newCharRange, int changeInLength) { }
        
        /// <summary>
        /// Sets the orthography for the specified range.
        /// </summary>
        /// <param name="orthography">The orthography.</param>
        /// <param name="range">The range.</param>
        [iOSVersion(5)]
        [Export("setOrthography")]
        public void SetOrthography(NSOrthography orthography, NSRange range) { }
        
        /// <summary>
        /// Returns the orthography at the index and also returns the effective range.
        /// </summary>
        /// <param name="charIndex">The character index to begin examination.</param>
        /// <param name="effectiveRange">An NSRangePointer that, upon completion, contains the range of the orthography containing charIndex.</param>
        /// <returns>The orthography for the location.</returns>
        [iOSVersion(5)]
        [Export("orthographyAtIndex")]
        public NSOrthography OrthographyAtIndex(int charIndex, CMutablePointer<NSRange> effectiveRange) { return null; }
        
        /// <summary>
        /// Enumerates the specific range of the string, providing the Block with the located tags.
        /// </summary>
        /// <param name="range">The range to analyze</param>
        /// <param name="scheme">The tag scheme.</param>
        /// <param name="options">The linguistic tagger options to use. See NSLinguisticTaggerOptions for the constants. These constants can be combined using the C Bitwise operator.</param>
        /// <param name="usingBlock">The Block to apply to ranges of the string.   The Block takes four arguments:           tag              The located linguistic tag.                tokenRange              The range of the linguistic tag.                sentenceRange              The range of the sentence in which the tag occurs.                stop              A reference to a Boolean value. The block can set the value to true to stop further processing of the set. The stop argument is an out-only argument. You should only ever set this Boolean to true within the Block.</param>
        [iOSVersion(5)]
        [Export("enumerateTagsInRange")]
        public void EnumerateTagsInRange(NSRange range, string scheme, NSLinguisticTaggerOptions options, Action<String, NSRange, NSRange, CMutablePointer<ObjCBool>> usingBlock) { }
        
        /// <summary>
        /// Returns an array of possible tags for the given scheme at the specified range, supplying matching scores.
        /// </summary>
        /// <param name="charIndex">The initial character index.</param>
        /// <param name="scheme">The tag scheme. See Linguistic Tag Schemes for the possible values.</param>
        /// <param name="tokenRange">The token range.</param>
        /// <param name="sentenceRange">The range of the sentence.</param>
        /// <param name="scores">Returns by-reference an array of numeric scores (wrapped as NSValue objects) indicating the likelihood that the range matches the tag scheme.</param>
        /// <returns>Returns an array of possible tags for the tagScheme at the specified location, starting with the most likely tag scheme. For some tag schemes only a single tag will be returned, but for others a list of possibilities will be provided.</returns>
        [iOSVersion(5)]
        [Export("possibleTagsAtIndex")]
        public AnyObject[] PossibleTagsAtIndex(int charIndex, string scheme, CMutablePointer<NSRange> tokenRange, CMutablePointer<NSRange> sentenceRange, AutoreleasingUnsafePointer<NSArray> scores) { return null; }
        
        /// <summary>
        /// Returns a tag for a single scheme at the specified index.
        /// </summary>
        /// <param name="charIndex">The initial character index.</param>
        /// <param name="scheme">The tag scheme. See Linguistic Tag Schemes for the possible values.</param>
        /// <param name="tokenRange">A pointer to the token range. If NULL, no pointer range is returned.</param>
        /// <param name="sentenceRange">A pointer to the range of the sentence. If NULL, no pointer range is returned.</param>
        /// <returns>Returns the tag for the requested tagScheme. There are cases in which there may not be a tag for a given scheme and token, in which case the return value of the method would be nil.</returns>
        [iOSVersion(5)]
        [Export("tagAtIndex")]
        public string TagAtIndex(int charIndex, string scheme, CMutablePointer<NSRange> tokenRange, CMutablePointer<NSRange> sentenceRange) { return ""; }
        
        /// <summary>
        /// Returns an array of linguistic tags and token ranges.
        /// </summary>
        /// <param name="range">The range from which to return tags.</param>
        /// <param name="scheme">The tag scheme. See Linguistic Tag Schemes for the possible values.</param>
        /// <param name="options">The linguistic tagger options to use. See NSLinguisticTaggerOptions for the constants. These constants can be combined using the C-Bitwise OR operator.</param>
        /// <param name="tokenRanges">Returns by-reference an array of token range objects wrapped in NSValue objects.</param>
        /// <returns>An array of the tag schemes corresponding to the entries in the tokenRanges array.</returns>
        [iOSVersion(5)]
        [Export("tagsInRange")]
        public AnyObject[] TagsInRange(NSRange range, string scheme, NSLinguisticTaggerOptions options, AutoreleasingUnsafePointer<NSArray> tokenRanges) { return null; }
        
        /// <summary>
        /// Returns the range of a sentence boundary containing the specified range.
        /// </summary>
        /// <param name="charRange">The range.</param>
        /// <returns>Returns the range of a sentence that contains charRange.</returns>
        [iOSVersion(5)]
        [Export("sentenceRangeForRange")]
        public NSRange SentenceRangeForRange(NSRange charRange) { return new NSRange(); }

        /// <summary>
        /// These constants specify the linguistic tag schemes used by initWithTagSchemes:options: to create the linguistic tagger instance. The method tagSchemes returns an array of the schemes the instance was created with.
        /// </summary>
        
        /// <summary>
        /// This tag scheme classifies tokens according to their broad type: word, punctuation, whitespace, etc. The possible tags are: NSLinguisticTagWord, NSLinguisticTagPunctuation, NSLinguisticTagWhitespace, or NSLinguisticTagOther. For this scheme a client may use pointer equality to compare the values with the tag constants.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeTokenType { get; private set; }
        
        /// <summary>
        /// This tag scheme classifies tokens according to class: part of speech for words, type of punctuation or whitespace, etc. The value will be one of the constants specified in NSLinguisticTagSchemeLexicalClass. For this scheme a client may use pointer equality to compare the values with the tag constants.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeLexicalClass { get; private set; }
        
        /// <summary>
        /// This tag scheme classifies tokens as to whether they are part of named entities of various types or not. The possible tags are: NSLinguisticTagPersonalName, NSLinguisticTagPlaceName, or NSLinguisticTagOrganizationName. For this scheme a client may use pointer equality to compare the values with the tag constants.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeNameType { get; private set; }
        
        /// <summary>
        /// This tag scheme follows NSLinguisticTagSchemeNameType for names, NSLinguisticTagSchemeLexicalClass for all other tokens. The possible tags are those specified in NSLinguisticTagSchemeLexicalClass or NSLinguisticTagSchemeNameType. For this scheme a client may use pointer equality to compare the values with the tag constants.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeNameTypeOrLexicalClass { get; private set; }
        
        /// <summary>
        /// This tag scheme supplies a stem forms of the words, if known.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeLemma { get; private set; }
        
        /// <summary>
        /// This tag scheme tags tokens according to their script. The tag values will be standard language abbreviations such as “en”, “fr”, “de”, etc., as used with the NSOrthography class. Note that the tagger generally attempts to determine the language of text at the level of an entire sentence or paragraph, rather than word by word.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeLanguage { get; private set; }
        
        /// <summary>
        /// This tag scheme tags tokens according to their script. The tag values will be standard script abbreviations such as “Latn”, “Cyrl”, “Jpan”, “Hans”, “Hant”, etc.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSchemeScript { get; private set; }
        
        /// <summary>
        /// These constants return the linguistic token type according to their broad type.
        /// </summary>
        
        /// <summary>
        /// The token indicates a word.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagWord { get; private set; }
        
        /// <summary>
        /// The token indicates punctuation.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagPunctuation { get; private set; }
        
        /// <summary>
        /// The token indicates white space of any sort.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagWhitespace { get; private set; }
        
        /// <summary>
        /// The token indicates a token other than those currently defined.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOther { get; private set; }
        
        /// <summary>
        /// These constants specify the lexical class of a token.
        /// </summary>
        
        /// <summary>
        /// The token is a noun.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagNoun { get; private set; }
        
        /// <summary>
        /// This token is a verb.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagVerb { get; private set; }
        
        /// <summary>
        /// This token is an adjective
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagAdjective { get; private set; }
        
        /// <summary>
        /// This token is an adverb.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagAdverb { get; private set; }
        
        /// <summary>
        /// This token is a pronoun.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagPronoun { get; private set; }
        
        /// <summary>
        /// This token is a determiner.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagDeterminer { get; private set; }
        
        /// <summary>
        /// This token is a particle.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagParticle { get; private set; }
        
        /// <summary>
        /// This token is a preposition.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagPreposition { get; private set; }
        
        /// <summary>
        /// This token is a number.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagNumber { get; private set; }
        
        /// <summary>
        /// This token is a conjunction.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagConjunction { get; private set; }
        
        /// <summary>
        /// This token is an interjection.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTaginterjection { get; private set; }
        
        /// <summary>
        /// This token is a classifier.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagClassifier { get; private set; }
        
        /// <summary>
        /// This token is an idiom.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagIdiom { get; private set; }
        
        /// <summary>
        /// This token is some other word.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOtherWord { get; private set; }
        
        /// <summary>
        /// This token is a sentence terminator.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagSentenceTerminator { get; private set; }
        
        /// <summary>
        /// This token is an open quote.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOpenQuote { get; private set; }
        
        /// <summary>
        /// This token is a close quote.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagCloseQuote { get; private set; }
        
        /// <summary>
        /// This token is an open parenthesis.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOpenParenthesis { get; private set; }
        
        /// <summary>
        /// This token is a close parenthesis.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagCloseParenthesis { get; private set; }
        
        /// <summary>
        /// This token is a word joiner.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagWordJoiner { get; private set; }
        
        /// <summary>
        /// This token is a dash.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagDash { get; private set; }
        
        /// <summary>
        /// This token is punctuation not recognized as another token type.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOtherPunctuation { get; private set; }
        
        /// <summary>
        /// This token is a paragraph break.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagParagraphBreak { get; private set; }
        
        /// <summary>
        /// This token is whitespace.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOtherWhitespace { get; private set; }
        
        /// <summary>
        /// These constants define linguistic tags for specific types of words: people, places, and organizations.
        /// </summary>
        
        /// <summary>
        /// This token is a personal name.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagPersonalName { get; private set; }
        
        /// <summary>
        /// This token is a place name.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagPlaceName { get; private set; }
        
        /// <summary>
        /// This token is an organization name.
        /// </summary>
        [iOSVersion(5)]
        public string NSLinguisticTagOrganizationName { get; private set; }
    }

    /// <summary>
    /// These constants specify the linguistic tagger options. They can be combined using the C-Bitwise OR operator.
    /// </summary>
    public enum NSLinguisticTaggerOptions
    {
        /// <summary>
        /// Omit tokens of type NSLinguisticTagWord (items considered to be words).
        /// </summary>
        [iOSVersion(5)]
        OmitWords,

        /// <summary>
        /// Omit tokens of type NSLinguisticTagPunctuation (all punctuation).
        /// </summary>
        [iOSVersion(5)]
        OmitPunctuation,

        /// <summary>
        /// Omit tokens of type NSLinguisticTagWhitespace (whitespace of all sorts).
        /// </summary>
        [iOSVersion(5)]
        OmitWhitespace,

        /// <summary>
        /// Omit tokens of type NSLinguisticTagOther (non-linguistic items such as symbols).
        /// </summary>
        [iOSVersion(5)]
        OmitOther,

        /// <summary>
        /// Typically, multiple-word names will be returned as multiple tokens, following the standard tokenization practice of the tagger. If this option is set, then multiple-word names will be joined together and returned as a single token.
        /// </summary>
        [iOSVersion(5)]
        JoinNames,
    }
}