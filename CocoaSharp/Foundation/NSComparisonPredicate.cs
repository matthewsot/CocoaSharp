using ObjectiveC;
using System;
using SwiftSharp.Attributes;

namespace Foundation
{
    //https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSComparisonPredicate_Class/index.html#//apple_ref/occ/cl/NSComparisonPredicate
    /// <summary>
    /// NSComparisonPredicate is a subclass of NSPredicate that you use to compare expressions.
    /// </summary>
    [iOSVersion(3)]
    public class NSComparisonPredicate : NSPredicate
    {
        /// <summary>
        /// Initializes a predicate formed by combining given left and right expressions using a given selector.
        /// </summary>
        /// <param name="leftExpression">The left hand expression.</param>
        /// <param name="rightExpression">The right hand expression.</param>
        /// <param name="customSelector">The selector to use. The method defined by the selector must take a single argument and return a BOOL value.</param>
        /// <returns>The receiver, initialized by combining the left and right expressions using selector.</returns>
        [iOSVersion(3)]
        public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, Selector customSelector) : base(false) { }

        /// <summary>
        /// Initializes a predicate to a given type formed by combining given left and right expressions using a given modifier and options.
        /// </summary>
        /// <param name="leftExpression">The left hand expression.</param>
        /// <param name="rightExpression">The right hand expression.</param>
        /// <param name="modifier">The modifier to apply.</param>
        /// <param name="type">The predicate operator type.</param>
        /// <param name="options">The options to apply (see NSComparisonPredicate Options). For no options, pass 0.</param>
        /// <returns>The receiver, initialized to a predicate of type type formed by combining the left and right expressions using the modifier and options.</returns>
        [iOSVersion(3)]
        public NSComparisonPredicate(NSExpression leftExpression, NSExpression rightExpression, NSComparisonPredicateModifier modifier, NSPredicateOperatorType type, NSComparisonPredicateOptions options) : base(false) { }

        /// <summary>
        /// Returns the comparison predicate modifier for the receiver.
        /// </summary>
        /// <returns>The comparison predicate modifier for the receiver.</returns>
        [iOSVersion(3)]
        [Export("comparisonPredicateModifier")]
        public NSComparisonPredicateModifier ComparisonPredicateModifier { get; private set; }

        /// <summary>
        /// Returns the selector for the receiver.
        /// </summary>
        /// <returns>The selector for the receiver, or NULL if there is none.</returns>
        [iOSVersion(3)]
        [Export("customSelector")]
        public Selector CustomSelector { get; private set; }

        /// <summary>
        /// Returns the left expression for the receiver.
        /// </summary>
        /// <returns>The left expression for the receiver, or nil if there is none.</returns>
        [iOSVersion(3)]
        [Export("leftExpression")]
        public NSExpression LeftExpression { get; private set; }

        /// <summary>
        /// Returns the options that are set for the receiver.
        /// </summary>
        /// <returns>The options that are set for the receiver.</returns>
        [iOSVersion(3)]
        [Export("options")]
        public NSComparisonPredicateOptions Options { get; private set; }

        /// <summary>
        /// Returns the predicate type for the receiver.
        /// </summary>
        /// <returns>The predicate type for the receiver.</returns>
        [iOSVersion(3)]
        [Export("predicateOperatorType")]
        public NSPredicateOperatorType PredicateOperatorType { get; private set; }

        /// <summary>
        /// Returns the right expression for the receiver.
        /// </summary>
        /// <returns>The right expression for the receiver, or nil if there is none.</returns>
        [iOSVersion(3)]
        [Export("rightExpression")]
        public NSExpression RightExpression { get; private set; }

        /// <summary>
        /// These constants describe the possible types of modifier for NSComparisonPredicate.
        /// </summary>
        public enum NSComparisonPredicateModifier
        {
            /// <summary>
            /// A predicate to compare directly the left and right hand sides.
            /// </summary>
            [iOSVersion(3)]
            DirectPredicateModifier,

            /// <summary>
            /// A predicate to compare all entries in the destination of a to-many relationship.
            /// </summary>
            [iOSVersion(3)]
            AllPredicateModifier,

            /// <summary>
            /// A predicate to match with any entry in the destination of a to-many relationship.
            /// </summary>
            [iOSVersion(3)]
            AnyPredicateModifier,
        }
        /// <summary>
        /// These constants describe the possible types of string comparison for NSComparisonPredicate. These options are supported for LIKE as well as all of the equality/comparison operators.
        /// </summary>
        public enum NSComparisonPredicateOptions
        {
            /// <summary>
            /// A case-insensitive predicate.
            /// </summary>
            [iOSVersion(3)]
            CaseInsensitivePredicateOption,

            /// <summary>
            /// A diacritic-insensitive predicate.
            /// </summary>
            [iOSVersion(3)]
            DiacriticInsensitivePredicateOption,

            /// <summary>
            /// Indicates that the strings to be compared have been preprocessed.
            /// </summary>
            [iOSVersion(4)]
            NormalizedPredicateOption,
        }
        /// <summary>
        /// Defines the type of comparison for NSComparisonPredicate.
        /// </summary>
        public enum NSPredicateOperatorType
        {
            /// <summary>
            /// A less-than predicate.
            /// </summary>
            [iOSVersion(3)]
            LessThanPredicateOperatorType,

            /// <summary>
            /// A less-than-or-equal-to predicate.
            /// </summary>
            [iOSVersion(3)]
            LessThanOrEqualToPredicateOperatorType,

            /// <summary>
            /// A greater-than predicate.
            /// </summary>
            [iOSVersion(3)]
            GreaterThanPredicateOperatorType,

            /// <summary>
            /// A greater-than-or-equal-to predicate.
            /// </summary>
            [iOSVersion(3)]
            GreaterThanOrEqualToPredicateOperatorType,

            /// <summary>
            /// An equal-to predicate.
            /// </summary>
            [iOSVersion(3)]
            EqualToPredicateOperatorType,

            /// <summary>
            /// A not-equal-to predicate.
            /// </summary>
            [iOSVersion(3)]
            NotEqualToPredicateOperatorType,

            /// <summary>
            /// A full regular expression matching predicate.
            /// </summary>
            [iOSVersion(3)]
            MatchesPredicateOperatorType,

            /// <summary>
            /// A simple subset of the MATCHES predicate, similar in behavior to SQL LIKE.
            /// </summary>
            [iOSVersion(3)]
            LikePredicateOperatorType,

            /// <summary>
            /// A begins-with predicate.
            /// </summary>
            [iOSVersion(3)]
            BeginsWithPredicateOperatorType,

            /// <summary>
            /// An ends-with predicate.
            /// </summary>
            [iOSVersion(3)]
            EndsWithPredicateOperatorType,

            /// <summary>
            /// A predicate to determine if the left hand side is in the right hand side.
            /// </summary>
            [iOSVersion(3)]
            InPredicateOperatorType,

            /// <summary>
            /// A predicate that uses a custom selector that takes a single argument and returns a BOOL value.
            /// </summary>
            [iOSVersion(3)]
            CustomSelectorPredicateOperatorType,

            /// <summary>
            /// A predicate to determine if the left hand side contains the right hand side.
            /// </summary>
            [iOSVersion(3)]
            ContainsPredicateOperatorType,

            /// <summary>
            /// A predicate to determine if the right hand side lies at or between bounds specified by the left hand side.
            /// </summary>
            [iOSVersion(3)]
            BetweenPredicateOperatorType,
        }
    }
}