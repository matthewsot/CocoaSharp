using ObjectiveC;using System;using SwiftSharp.Attributes;namespace Foundation{	//https://developer.apple.com/library/prerelease/ios/documentation/Cocoa/Reference/Foundation/Classes/NSPredicate_Class/index.html#//apple_ref/occ/cl/NSPredicate	/// <summary>	/// The NSPredicate class is used to define logical conditions used to constrain a search either for a fetch or for in-memory filtering.	/// </summary>	[iOSVersion(3)]	public class NSPredicate : NSObject	{		/// <summary>		/// Creates and returns a new predicate by substituting the values in a given array into a format string and parsing the result.		/// </summary>		/// <param name="format">The format string for the new predicate.</param>		/// <param name="argumentArray">The arguments to substitute into predicateFormat. Values are substituted into predicateFormat in the order they appear in the array.</param>		/// <returns>A new predicate by substituting the values in arguments into predicateFormat, and parsing the result.</returns>		[iOSVersion(3)]		public NSPredicate(string format, AnyObject[] argumentArray) { }				/// <summary>		/// Creates and returns a new predicate by substituting the values in an argument list into a format string and parsing the result.		/// </summary>		/// <param name="format">The format string for the new predicate.</param>		/// <param name="arguments">The arguments to substitute into predicateFormat. Values are substituted into predicateFormat in the order they appear in the argument list.</param>		/// <returns>A new predicate by substituting the values in argList into predicateFormat and parsing the result.</returns>		[iOSVersion(3)]		public NSPredicate(string format, CVaListPointer arguments) { }				/// <summary>		/// Returns a copy of the receiver with the receiver’s variables substituted by values specified in a given substitution variables dictionary.		/// </summary>		/// <param name="variables">The substitution variables dictionary. The dictionary must contain key-value pairs for all variables in the receiver.</param>		/// <returns>A copy of the receiver with the receiver’s variables substituted by values specified in variables.</returns>		[iOSVersion(3)]		[Export("predicateWithSubstitutionVariables")]		public NSPredicate PredicateWithSubstitutionVariables(NSDictionary variables) { return null; }				/// <summary>		/// Creates and returns a predicate that always evaluates to a given value.		/// </summary>		/// <param name="value">The value to which the new predicate should evaluate.</param>		/// <returns>A predicate that always evaluates to value.</returns>		[iOSVersion(3)]		public NSPredicate(bool value) { }				/// <summary>		/// Creates and returns a predicate that evaluates using a specified block object and bindings dictionary.		/// </summary>		/// <param name="block">The block is applied to the object to be evaluated.   The block takes two arguments:           evaluatedObject              The object to be evaluated.                bindings              The substitution variables dictionary. The dictionary must contain key-value pairs for all variables in the receiver.        The block returns true if the evaluatedObject evaluates to true, otherwise false.</param>		/// <returns>A new predicate by that evaluates objects using block.</returns>		[iOSVersion(4)]		public NSPredicate(Func<AnyObject, NSDictionary, bool> block) { }				/// <summary>		/// Returns a Boolean value that indicates whether a given object matches the conditions specified by the receiver.		/// </summary>		/// <param name="object">The object against which to evaluate the receiver.</param>		/// <returns>true if object matches the conditions specified by the receiver, otherwise false.</returns>		[iOSVersion(3)]		[Export("evaluateWithObject")]		public bool EvaluateWithObject(AnyObject @object) { return false; }				/// <summary>		/// Returns a Boolean value that indicates whether a given object matches the conditions specified by the receiver after substituting in the values in a given variables dictionary.		/// </summary>		/// <param name="object">The object against which to evaluate the receiver.</param>		/// <param name="substitutionVariables">The substitution variables dictionary. The dictionary must contain key-value pairs for all variables in the receiver.</param>		/// <returns>true if object matches the conditions specified by the receiver after substituting in the values in variables for any replacement tokens, otherwise false.</returns>		[iOSVersion(3)]		[Export("evaluateWithObject")]		public bool EvaluateWithObject(AnyObject @object, NSDictionary substitutionVariables) { return false; }				/// <summary>		/// Force a predicate that was securely decoded to allow evaluation.		/// </summary>		[iOSVersion(7)]		[Export("allowEvaluation")]		public void AllowEvaluation() { }				/// <summary>		/// Returns the receiver’s format string.		/// </summary>		/// <returns>The receiver’s format string.</returns>		[iOSVersion(3)]		[Export("predicateFormat")]		public string PredicateFormat { get; private set; }	}}