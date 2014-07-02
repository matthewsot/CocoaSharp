using CoreGraphics;
using ObjectiveC;using System;using SwiftSharp.Attributes;using Foundation;namespace UIKit{    //https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITableViewCell_Class/index.html#//apple_ref/occ/cl/UITableViewCell    /// <summary>    /// The UITableViewCell class defines the attributes and behavior of the cells that appear in UITableView objects. This class includes properties and methods for setting and managing cell content and background (including text, images, and custom views), managing the cell selection and highlight state, managing accessory views, and initiating the editing of the cell contents.    /// </summary>    [iOSVersion(2)]    public class UITableViewCell : UIView    {        /// <summary>        /// Initializes a table cell with a style and a reuse identifier and returns it to the caller.        /// </summary>        /// <param name="style">A constant indicating a cell style. See UITableViewCellStyle for descriptions of these constants.</param>        /// <param name="reuseIdentifier">A string used to identify the cell object if it is to be reused for drawing multiple rows of a table view. Pass nil if the cell object is not to be reused. You should use the same reuse identifier for all cells of the same form.</param>        /// <returns>An initialized UITableViewCell object or nil if the object could not be created.</returns>        [iOSVersion(3)]        public UITableViewCell(UITableViewCellStyle style, string reuseIdentifier) : base(new CGRect()) { }                /// <summary>        /// A string used to identify a cell that is reusable. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("reuseIdentifier")]        public string ReuseIdentifier { get; private set; }                /// <summary>        /// Prepares a reusable cell for reuse by the table view's delegate.        /// </summary>        [iOSVersion(2)]        [Export("prepareForReuse")]        public void PrepareForReuse() { }                /// <summary>        /// Returns the label used for the main textual content of the table cell. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("textLabel")]        public UILabel TextLabel { get; private set; }                /// <summary>        /// Returns the secondary label of the table cell if one exists. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("detailTextLabel")]        public UILabel DetailTextLabel { get; private set; }                /// <summary>        /// Returns the image view of the table cell. (read-only)        /// </summary>        [iOSVersion(3)]        [Export("imageView")]        public UIImageView ImageView { get; private set; }                /// <summary>        /// Returns the content view of the cell object. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("contentView")]        public UIView ContentView { get; private set; }                /// <summary>        /// The view used as the background of the cell.        /// </summary>        [iOSVersion(2)]        [Export("backgroundView")]        public UIView BackgroundView { get; set; }                /// <summary>        /// The view used as the background of the cell when it is selected.        /// </summary>        [iOSVersion(2)]        [Export("selectedBackgroundView")]        public UIView SelectedBackgroundView { get; set; }                /// <summary>        /// The background view to use for a selected cell when the table view allows multiple row selections.        /// </summary>        [iOSVersion(5)]        [Export("multipleSelectionBackgroundView")]        public UIView MultipleSelectionBackgroundView { get; set; }                /// <summary>        /// The type of standard accessory view the cell should use (normal state).        /// </summary>        [iOSVersion(2)]        [Export("accessoryType")]        public UITableViewCellAccessoryType AccessoryType { get; set; }                /// <summary>        /// A view that is used, typically as a control, on the right side of the cell (normal state).        /// </summary>        [iOSVersion(2)]        [Export("accessoryView")]        public UIView AccessoryView { get; set; }                /// <summary>        /// The type of standard accessory view the cell should use in the table view’s editing state.        /// </summary>        [iOSVersion(3)]        [Export("editingAccessoryType")]        public UITableViewCellAccessoryType EditingAccessoryType { get; set; }                /// <summary>        /// A view that is used typically as a control on the right side of the cell when it is in editing mode.        /// </summary>        [iOSVersion(3)]        [Export("editingAccessoryView")]        public UIView EditingAccessoryView { get; set; }                /// <summary>        /// A Boolean value that indicates whether the cell is selected.        /// </summary>        [iOSVersion(2)]        [Export("selected")]        public bool Selected { get; set; }                /// <summary>        /// The style of selection for a cell.        /// </summary>        [iOSVersion(2)]        [Export("selectionStyle")]        public UITableViewCellSelectionStyle SelectionStyle { get; set; }                /// <summary>        /// Sets the selected state of the cell, optionally animating the transition between states.        /// </summary>        /// <param name="selected">true to set the cell as selected, false to set it as unselected. The default is false.</param>        /// <param name="animated">true to animate the transition between selected states, false to make the transition immediate.</param>        [iOSVersion(2)]        [Export("setSelected")]        public void SetSelected(bool selected, bool animated) { }                /// <summary>        /// A Boolean value that indicates whether the cell is highlighted.        /// </summary>        [iOSVersion(3)]        [Export("highlighted")]        public bool Highlighted { get; set; }                /// <summary>        /// Sets the highlighted state of the cell, optionally animating the transition between states.        /// </summary>        /// <param name="highlighted">true to set the cell as highlighted, false to set it as unhighlighted. The default is false.</param>        /// <param name="animated">true to animate the transition between highlighted states, false to make the transition immediate.</param>        [iOSVersion(3)]        [Export("setHighlighted")]        public void SetHighlighted(bool highlighted, bool animated) { }                /// <summary>        /// A Boolean value that indicates whether the cell is in an editable state.        /// </summary>        [iOSVersion(2)]        [Export("editing")]        public bool Editing { get; set; }                /// <summary>        /// Toggles the receiver into and out of editing mode.        /// </summary>        /// <param name="editing">true to enter editing mode, false to leave it. The default value is false .</param>        /// <param name="animated">true to animate the appearance or disappearance of the insertion/deletion control and the reordering control, false to make the transition immediate.</param>        [iOSVersion(2)]        [Export("setEditing")]        public void SetEditing(bool editing, bool animated) { }                /// <summary>        /// The editing style of the cell. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("editingStyle")]        public UITableViewCellEditingStyle EditingStyle { get; private set; }                /// <summary>        /// Returns whether the cell is currently showing the delete-confirmation button. (read-only)        /// </summary>        [iOSVersion(2)]        [Export("showingDeleteConfirmation")]        public bool ShowingDeleteConfirmation { get; private set; }                /// <summary>        /// A Boolean value that determines whether the cell shows the reordering control.        /// </summary>        [iOSVersion(2)]        [Export("showsReorderControl")]        public bool ShowsReorderControl { get; set; }                /// <summary>        /// Called on the cell just before it transitions between cell states.        /// </summary>        /// <param name="state">A bit mask indicating the state or combination of states the cell is transitioning to.</param>        [iOSVersion(3)]        [Export("willTransitionToState")]        public void WillTransitionToState(UITableViewCellStateMask state) { }                /// <summary>        /// Called on the cell just after it transitions between cell states.        /// </summary>        /// <param name="state">A bit mask indicating the state or combination of states the cell is transitioning to.</param>        [iOSVersion(3)]        [Export("didTransitionToState")]        public void DidTransitionToState(UITableViewCellStateMask state) { }                /// <summary>        /// The indentation level of the cell’s content.        /// </summary>        [iOSVersion(2)]        [Export("indentationLevel")]        public int IndentationLevel { get; set; }                /// <summary>        /// The width for each level of indentation of a cell's content.        /// </summary>        [iOSVersion(2)]        [Export("indentationWidth")]        public CGFloat IndentationWidth { get; set; }                /// <summary>        /// A Boolean value that controls whether the cell background is indented when the table view is in editing mode.        /// </summary>        [iOSVersion(2)]        [Export("shouldIndentWhileEditing")]        public bool ShouldIndentWhileEditing { get; set; }                /// <summary>        /// The inset values for the cell’s content.        /// </summary>        [iOSVersion(7)]        [Export("separatorInset")]        public UIEdgeInsets SeparatorInset { get; set; }                /// <summary>        /// Initializes and returns a table cell object.				 		  Deprecation Statement		  		 Use initWithStyle:reuseIdentifier: instead.        /// </summary>        /// <param name="frame">The frame rectangle of the cell. Because the table view automatically positions the cell and makes it the optimal size, you can pass in CGRectZero in most cases. However, if you have a custom cell with multiple subviews, each with its own autoresizing mask, you must specify a non-zero frame rectangle; this allows the table view to position the subviews automatically as the cell changes size.</param>        /// <param name="reuseIdentifier">A string used to identify the cell object if it is to be reused for drawing multiple rows of a table view. Pass nil if the cell object is not to be reused.</param>        /// <returns>An initialized UITableViewCell object or nil if the object could not be created.</returns>        [Obsolete]        [iOSVersion(2)]        public UITableViewCell(CGRect frame, string reuseIdentifier) : base(new CGRect()) { }                /// <summary>        /// The text of the cell.				 		  Deprecation Statement		  		     Use the textLabel and detailTextLabel properties instead.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("text")]        public string Text { get; set; }                /// <summary>        /// The font of the title. 				 		  Deprecation Statement		  		     Instead, set the fonts of the UILabel objects assigned to the textLabel and detailTextLabel properties.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("font")]        public UIFont Font { get; set; }                /// <summary>        /// A constant that specifies the alignment of text in the cell.				 		  Deprecation Statement		  		     Instead set the text alignment of the UILabel objects assigned to the textLabel and detailTextLabel properties.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("textAlignment")]        public NSTextAlignment TextAlignment { get; set; }                /// <summary>        /// The color of the title text.				 		  Deprecation Statement		  		     Instead set the text color attribute of the UILabel objects assigned to the textLabel and detailTextLabel properties.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("textColor")]        public UIColor TextColor { get; set; }                /// <summary>        /// The color of the title text when the cell is selected.				 		  Deprecation Statement		  		     Instead set the highlightedTextColor property of the UILabel objects assigned to the textLabel and detailTextLabel properties.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("selectedTextColor")]        public UIColor SelectedTextColor { get; set; }                /// <summary>        /// The mode for for wrapping and truncating text in the cell.				 		  Deprecation Statement		  		     Instead set the line-break mode attribute of the UILabel objects assigned to the textLabel and detailTextLabel properties.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("lineBreakMode")]        public NSLineBreakMode LineBreakMode { get; set; }                /// <summary>        /// The image to use as content for the cell.				 		  Deprecation Statement		  		   Instead use the imageView property to get UIImageView object and then get or set the encapsulated image.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("image")]        public UIImage Image { get; set; }                /// <summary>        /// The image to use a cell content when the cell is selected.				 		  Deprecation Statement		  		   Instead use the imageView property to obtain the UIImageView object and then get or set its highlightedImage property.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("selectedImage")]        public UIImage SelectedImage { get; set; }                /// <summary>        /// A Boolean value that determines whether the accessory view is hidden when the cell is being edited.				 		  Deprecation Statement		  		     Use the editingAccessoryType and editingAccessoryView properties instead.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("hidesAccessoryWhenEditing")]        public bool HidesAccessoryWhenEditing { get; set; }                /// <summary>        /// The target object to receive action messages.				 		  Deprecation Statement		  		 Instead use the tableView:commitEditingStyle:forRowAtIndexPath: or tableView:accessoryButtonTappedForRowWithIndexPath: for handling taps on cells.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("target")]        public AnyObject Target { get; set; }                /// <summary>        /// The selector defining the action message to invoke when users tap the insert or delete button.				 		  Deprecation Statement		  		 Instead use the tableView:commitEditingStyle:forRowAtIndexPath: or tableView:accessoryButtonTappedForRowWithIndexPath: for handling taps on cells.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("editAction")]        public Selector EditAction { get; set; }                /// <summary>        /// The selector defining the action message to invoke when users tap the accessory view.				 		  Deprecation Statement		  		 Instead use the tableView:commitEditingStyle:forRowAtIndexPath: or tableView:accessoryButtonTappedForRowWithIndexPath: for handling taps on cells.        /// </summary>        [Obsolete]        [iOSVersion(2)]        [Export("accessoryAction")]        public Selector AccessoryAction { get; set; }
    }

    /// <summary>
    /// An enumeration for the various styles of cells.
    /// </summary>
    public enum UITableViewCellStyle
    {
        /// <summary>
        /// A simple style for a cell with a text label (black and left-aligned) and an optional image view. Note that this is the default style for cells prior to iOS 3.0.
        /// </summary>
        [iOSVersion(3)]
        Default,

        /// <summary>
        /// A style for a cell with a label on the left side of the cell with left-aligned and black text; on the right side is a label that has smaller blue text and is right-aligned. The Settings application uses cells in this style.
        /// </summary>
        [iOSVersion(3)]
        Value1,

        /// <summary>
        /// A style for a cell with a label on the left side of the cell with text that is right-aligned and blue; on the right side of the cell is another label with smaller text that is left-aligned and black. The Phone/Contacts application uses cells in this style.
        /// </summary>
        [iOSVersion(3)]
        Value2,

        /// <summary>
        /// A style for a cell with a left-aligned label across the top and a left-aligned label below it in smaller gray text. The iPod application uses cells in this style.
        /// </summary>
        [iOSVersion(3)]
        Subtitle,
    }
    /// <summary>
    /// The style of selected cells.
    /// </summary>
    public enum UITableViewCellSelectionStyle
    {
        /// <summary>
        /// The cell has no distinct style for when it is selected.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The cell has a default background color when selected.
        /// </summary>
        [iOSVersion(2)]
        Blue,

        /// <summary>
        /// Then cell when selected has a gray background.
        /// </summary>
        [iOSVersion(2)]
        Gray,

        /// <summary>
        /// The cell selection style to use for tables. This is the default value.
        /// </summary>
        [iOSVersion(7)]
        Default,
    }
    /// <summary>
    /// The editing control used by a cell.
    /// </summary>
    public enum UITableViewCellEditingStyle
    {
        /// <summary>
        /// The cell has no editing control. This is the default value.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The cell has the delete editing control; this control is a red circle enclosing a minus sign.
        /// </summary>
        [iOSVersion(2)]
        Delete,

        /// <summary>
        /// The cell has the insert editing control; this control is a green circle enclosing a plus sign.
        /// </summary>
        [iOSVersion(2)]
        Insert,
    }
    /// <summary>
    /// The type of standard accessory control used by a cell.
    /// </summary>
    public enum UITableViewCellAccessoryType
    {
        /// <summary>
        /// The cell does not have any accessory view. This is the default value.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The cell has an accessory control shaped like a chevron. This control indicates that tapping the cell triggers a push action. The control does not track touches.
        /// </summary>
        [iOSVersion(2)]
        DisclosureIndicator,

        /// <summary>
        /// The cell has an info button and a chevron image as content. This control indicates that tapping the cell allows the user to configure the cell’s contents. The control tracks touches.
        /// </summary>
        [iOSVersion(2)]
        DetailDisclosureButton,

        /// <summary>
        /// The cell has a check mark on its right side. This control does not track touches. The delegate of the table view can manage check marks in a section of rows (possibly limiting the check mark to one row of the section) in its tableView:didSelectRowAtIndexPath: method.
        /// </summary>
        [iOSVersion(2)]
        Checkmark,

        /// <summary>
        /// The cell has an info button without a chevron. This control indicates that tapping the cell displays additional information about the cell’s contents. The control tracks touches.
        /// </summary>
        [iOSVersion(7)]
        DetailButton,
    }
    /// <summary>
    /// Constants used to determine the new state of a cell as it transitions between states.
    /// </summary>
    public enum UITableViewCellStateMask
    {
        /// <summary>
        /// The normal state of a table cell.
        /// </summary>
        [iOSVersion(3)]
        DefaultMask,

        /// <summary>
        /// The state of a table view cell when the table view is in editing mode.
        /// </summary>
        [iOSVersion(3)]
        ShowingEditControlMask,

        /// <summary>
        /// The state of a table view cell that shows a button requesting confirmation of a delete gesture.
        /// </summary>
        [iOSVersion(3)]
        ShowingDeleteConfirmationMask,
    }
    /// <summary>
    /// The style for cells used as separators.
    /// </summary>
    public enum UITableViewCellSeparatorStyle
    {
        /// <summary>
        /// The separator cell has no distinct style.
        /// </summary>
        [iOSVersion(2)]
        None,

        /// <summary>
        /// The separator cell has a single line running across its width. This is the default value
        /// </summary>
        [iOSVersion(2)]
        SingleLine,

        /// <summary>
        /// The separator cell has double lines running across its width, giving it an etched look. This style is currently only supported for grouped-style table views.
        /// </summary>
        [iOSVersion(3.2)]
        SingleLineEtched,
    }}