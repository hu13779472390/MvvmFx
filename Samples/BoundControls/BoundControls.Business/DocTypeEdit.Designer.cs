//  This file was generated by CSLA Object Generator - CslaGenFork v4.5
//
// Filename:    DocTypeEdit
// ObjectType:  DocTypeEdit
// CSLAType:    EditableChild

using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace BoundControls.Business
{

    /// <summary>
    /// Types of document (editable child object).<br/>
    /// This is a generated base class of <see cref="DocTypeEdit"/> business object.
    /// </summary>
    /// <remarks>
    /// This class contains one child collection:<br/>
    /// - <see cref="DocSubTypes"/> of type <see cref="DocSubTypeEditColl"/> (1:M relation to <see cref="DocSubTypeEdit"/>)<br/>
    /// This class is an item of <see cref="DocTypeEditColl"/> collection.
    /// </remarks>
    [Serializable]
    public partial class DocTypeEdit : BusinessBase<DocTypeEdit>
    {

        #region Business Properties

        /// <summary>
        /// Maintains metadata about <see cref="DocTypeID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int> DocTypeIDProperty = RegisterProperty<int>(p => p.DocTypeID, "Doc Type ID");
        /// <summary>
        /// Gets or sets the Doc Type ID.
        /// </summary>
        /// <value>The Doc Type ID.</value>
        public int DocTypeID
        {
            get { return GetProperty(DocTypeIDProperty); }
            set { SetProperty(DocTypeIDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DocTypeParentID"/> property.
        /// </summary>
        public static readonly PropertyInfo<int?> DocTypeParentIDProperty = RegisterProperty<int?>(p => p.DocTypeParentID, "Doc Type Parent ID");
        /// <summary>
        /// Gets or sets the Doc Type Parent ID.
        /// </summary>
        /// <value>The Doc Type Parent ID.</value>
        public int? DocTypeParentID
        {
            get { return GetProperty(DocTypeParentIDProperty); }
            set { SetProperty(DocTypeParentIDProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DocTypeName"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DocTypeNameProperty = RegisterProperty<string>(p => p.DocTypeName, "Doc Type Name");
        /// <summary>
        /// Gets or sets the Doc Type Name.
        /// </summary>
        /// <value>The Doc Type Name.</value>
        public string DocTypeName
        {
            get { return GetProperty(DocTypeNameProperty); }
            set { SetProperty(DocTypeNameProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DocTypeDescription"/> property.
        /// </summary>
        public static readonly PropertyInfo<string> DocTypeDescriptionProperty = RegisterProperty<string>(p => p.DocTypeDescription, "Doc Type Description");
        /// <summary>
        /// Gets or sets the Doc Type Description.
        /// </summary>
        /// <value>The Doc Type Description.</value>
        public string DocTypeDescription
        {
            get { return GetProperty(DocTypeDescriptionProperty); }
            set { SetProperty(DocTypeDescriptionProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about <see cref="DocTypeIsReadOnly"/> property.
        /// </summary>
        public static readonly PropertyInfo<bool> DocTypeIsReadOnlyProperty = RegisterProperty<bool>(p => p.DocTypeIsReadOnly, "Doc Type Is ReadOnly");
        /// <summary>
        /// Gets or sets the Doc Type Is ReadOnly.
        /// </summary>
        /// <value><c>true</c> if Doc Type Is ReadOnly; otherwise, <c>false</c>.</value>
        public bool DocTypeIsReadOnly
        {
            get { return GetProperty(DocTypeIsReadOnlyProperty); }
            set { SetProperty(DocTypeIsReadOnlyProperty, value); }
        }

        /// <summary>
        /// Maintains metadata about child <see cref="DocSubTypes"/> property.
        /// </summary>
        public static readonly PropertyInfo<DocSubTypeEditColl> DocSubTypesProperty = RegisterProperty<DocSubTypeEditColl>(p => p.DocSubTypes, "Doc Sub Types", RelationshipTypes.Child);
        /// <summary>
        /// Gets the Doc Sub Types ("parent load" child property).
        /// </summary>
        /// <value>The Doc Sub Types.</value>
        public DocSubTypeEditColl DocSubTypes
        {
            get { return GetProperty(DocSubTypesProperty); }
            set { SetProperty(DocSubTypesProperty, value); }
        }

        #endregion

        #region Factory Methods

        /// <summary>
        /// Factory method. Creates a new <see cref="DocTypeEdit"/> object.
        /// </summary>
        /// <returns>A reference to the created <see cref="DocTypeEdit"/> object.</returns>
        internal static DocTypeEdit NewDocTypeEdit()
        {
            return DataPortal.CreateChild<DocTypeEdit>();
        }

        /*/// <summary>
        /// Factory method. Loads a <see cref="DocTypeEdit"/> object from the given SafeDataReader.
        /// </summary>
        /// <param name="dr">The SafeDataReader to use.</param>
        /// <returns>A reference to the fetched <see cref="DocTypeEdit"/> object.</returns>
        internal static DocTypeEdit GetDocTypeEdit(SafeDataReader dr)
        {
            DocTypeEdit obj = new DocTypeEdit();
            // show the framework that this is a child object
            obj.MarkAsChild();
            obj.Fetch(dr);
            obj.LoadProperty(DocSubTypesProperty, DocSubTypeEditColl.NewDocSubTypeEditColl());
            obj.MarkOld();
            return obj;
        }*/

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="DocTypeEdit"/> class.
        /// </summary>
        /// <remarks> Do not use to create a Csla object. Use factory methods instead.</remarks>
        public DocTypeEdit()
        {
            // Prevent direct creation

            // show the framework that this is a child object
            MarkAsChild();
        }

        #endregion

        /// <summary>
        /// Loads default values for the <see cref="DocTypeEdit"/> object properties.
        /// </summary>
        [Csla.RunLocal]
        protected override void Child_Create()
        {
            LoadProperty(DocSubTypesProperty, DataPortal.CreateChild<DocSubTypeEditColl>());
            base.DataPortal_Create();
        }

    }
}
