using ObjectiveC;using System;using SwiftSharp.Attributes;using System.Collections.Generic;using Foundation;using CoreGraphics;namespace UIKit{    /// <summary>    /// The UITableViewDataSource protocol is adopted by an object that mediates the application’s data model for a UITableView object. The data source provides the table-view object with the information it needs to construct and modify a table view.    /// </summary>    /// <see cref="https://developer.apple.com/library/prerelease/ios/documentation/UIKit/Reference/UITableViewDataSource_Protocol/index.html#//apple_ref/occ/intf/UITableViewDataSource"/>    [iOSVersion(2)]    public interface UITableViewDataSource//: NSObjectProtocol    {        /// <summary>        /// Asks the data source for a cell to insert in a particular location of the table view. (required)        /// </summary>        /// <param name="tableView">A table-view object requesting the cell.</param>        /// <param name="cellForRowAtIndexPath">An index path locating a row in tableView.</param>        [iOSVersion(2)]        [Export("tableView")]        UITableViewCell TableView(UITableView tableView, NSIndexPath cellForRowAtIndexPath);                /// <summary>        /// Asks the data source to return the number of sections in the table view.        /// </summary>        /// <param name="tableView">An object representing the table view requesting this information.</param>        [iOSVersion(2)]        [Export("numberOfSectionsInTableView")]        int NumberOfSectionsInTableView(UITableView tableView);                /// <summary>        /// Tells the data source to return the number of rows in a given section of a table view. (required)        /// </summary>        /// <param name="tableView">The table-view object requesting this information.</param>        /// <param name="numberOfRowsInSection">An index number identifying a section in tableView.</param>        [iOSVersion(2)]        [Export("tableView")]        int TableView(UITableView tableView, int numberOfRowsInSection);                /// <summary>        /// Asks the data source to return the titles for the sections for a table view.        /// </summary>        /// <param name="tableView">The table-view object requesting this information.</param>        [iOSVersion(2)]        [Export("sectionIndexTitlesForTableView")]        AnyObject[] SectionIndexTitlesForTableView(UITableView tableView);                /// <summary>        /// Asks the data source to return the index of the section having the given title and section title index.        /// </summary>        /// <param name="tableView">The table-view object requesting this information.</param>        /// <param name="sectionForSectionIndexTitle">The title as displayed in the section index of tableView.</param>        /// <param name="atIndex">An index number identifying a section title in the array returned by sectionIndexTitlesForTableView:.</param>        [iOSVersion(2)]        [Export("tableView")]        int TableView(UITableView tableView, string sectionForSectionIndexTitle, int atIndex);                /// <summary>        /// Asks the data source for the title of the header of the specified section of the table view.        /// </summary>        /// <param name="tableView">The table-view object asking for the title.</param>        /// <param name="titleForHeaderInSection">An index number identifying a section of tableView .</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("tableView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        string TableView(UITableView tableView, int titleForHeaderInSection, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Asks the data source for the title of the footer of the specified section of the table view.        /// </summary>        /// <param name="tableView">The table-view object asking for the title.</param>        /// <param name="titleForFooterInSection">An index number identifying a section of tableView .</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("tableView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        string TableView(UITableView tableView, int titleForFooterInSection, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Asks the data source to commit the insertion or deletion of a specified row in the receiver.        /// </summary>        /// <param name="tableView">The table-view object requesting the insertion or deletion.</param>        /// <param name="commitEditingStyle">The cell editing style corresponding to a insertion or deletion requested for the row specified by indexPath. Possible editing styles are UITableViewCellEditingStyleInsert or UITableViewCellEditingStyleDelete.</param>        /// <param name="forRowAtIndexPath">An index path locating the row in tableView.</param>        [iOSVersion(2)]        [Export("tableView")]        void TableView(UITableView tableView, UITableViewCellEditingStyle commitEditingStyle, NSIndexPath forRowAtIndexPath);                /// <summary>        /// Asks the data source to verify that the given row is editable.        /// </summary>        /// <param name="tableView">The table-view object requesting this information.</param>        /// <param name="canEditRowAtIndexPath">An index path locating a row in tableView.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("tableView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        bool TableView(UITableView tableView, NSIndexPath canEditRowAtIndexPath, bool NAME_YOUR_PARAMS = false);                /// <summary>        /// Asks the data source whether a given row can be moved to another location in the table view.        /// </summary>        /// <param name="tableView">The table-view object requesting this information.</param>        /// <param name="canMoveRowAtIndexPath">An index path locating a row in tableView.</param>        /// <param name="NAME_YOUR_PARAMS">DO NOT USE THIS PARAMETER - Instead make sure to name the parameters you're using.</param>        [iOSVersion(2)]        [Export("tableView")]        [IgnoreParameter("NAME_YOUR_PARAMS")]        bool TableView(UITableView tableView, NSIndexPath canMoveRowAtIndexPath, int NAME_YOUR_PARAMS = 0);                /// <summary>        /// Tells the data source to move a row at a specific location in the table view to another location.        /// </summary>        /// <param name="tableView">The table-view object requesting this action.</param>        /// <param name="moveRowAtIndexPath">An index path locating the row to be moved in tableView.</param>        /// <param name="toIndexPath">An index path locating the row in tableView that is the destination of the move.</param>        [iOSVersion(2)]        [Export("tableView")]        void TableView(UITableView tableView, NSIndexPath moveRowAtIndexPath, NSIndexPath toIndexPath);    }}