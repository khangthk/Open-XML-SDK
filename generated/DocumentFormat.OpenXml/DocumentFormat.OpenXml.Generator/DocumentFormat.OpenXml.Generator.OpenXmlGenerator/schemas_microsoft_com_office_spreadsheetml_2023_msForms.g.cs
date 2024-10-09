﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms
{
    /// <summary>
    /// <para>Defines the Question Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlmsforms:question.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList" /> <c>&lt;xlmsforms:extLst></c></description></item>
    /// </list>
    /// </remarks>
    public partial class Question : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the Question class.
        /// </summary>
        public Question() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Question class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Question(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Question class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public Question(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Question class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public Question(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlmsforms:question");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList>();
            builder.AddElement<Question>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                });
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList), 0, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <summary>
        /// <para>ExtensionList.</para>
        /// <para>Represents the following element tag in the schema: xlmsforms:extLst.</para>
        /// </summary>
        /// <remarks>
        /// xmlns:xlmsforms = http://schemas.microsoft.com/office/spreadsheetml/2023/msForms
        /// </remarks>
        public DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList? ExtensionList
        {
            get => GetElement<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList>();
            set => SetElement(value);
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<Question>(deep);
    }

    /// <summary>
    /// <para>Defines the MsForm Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlmsforms:msForm.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList" /> <c>&lt;xlmsforms:extLst></c></description></item>
    ///   <item><description><see cref="DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.SyncedQuestionId" /> <c>&lt;xlmsforms:syncedQuestionId></c></description></item>
    /// </list>
    /// </remarks>
    public partial class MsForm : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the MsForm class.
        /// </summary>
        public MsForm() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the MsForm class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MsForm(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MsForm class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public MsForm(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the MsForm class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public MsForm(string outerXml) : base(outerXml)
        {
        }

        /// <summary>
        /// <para>id, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: id</para>
        /// </summary>
        public StringValue? Id
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>isFormConnected, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: isFormConnected</para>
        /// </summary>
        public BooleanValue? IsFormConnected
        {
            get => GetAttribute<BooleanValue>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>maxResponseId, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: maxResponseId</para>
        /// </summary>
        public Int32Value? MaxResponseId
        {
            get => GetAttribute<Int32Value>();
            set => SetAttribute(value);
        }

        /// <summary>
        /// <para>latestEventMarker, this property is only available in Microsoft365 and later.</para>
        /// <para>Represents the following attribute in the schema: latestEventMarker</para>
        /// </summary>
        public StringValue? LatestEventMarker
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlmsforms:msForm");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList>();
            builder.AddChild<DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.SyncedQuestionId>();
            builder.AddElement<MsForm>()
                .AddAttribute("id", a => a.Id, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                })
                .AddAttribute("isFormConnected", a => a.IsFormConnected)
                .AddAttribute("maxResponseId", a => a.MaxResponseId)
                .AddAttribute("latestEventMarker", a => a.LatestEventMarker);
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.SyncedQuestionId), 0, 0, version: FileFormatVersions.Microsoft365),
                new ElementParticle(typeof(DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms.ExtensionList), 0, 1, version: FileFormatVersions.Microsoft365)
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<MsForm>(deep);
    }

    /// <summary>
    /// <para>Defines the SyncedQuestionId Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlmsforms:syncedQuestionId.</para>
    /// </summary>
    public partial class SyncedQuestionId : OpenXmlLeafTextElement
    {
        /// <summary>
        /// Initializes a new instance of the SyncedQuestionId class.
        /// </summary>
        public SyncedQuestionId() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SyncedQuestionId class with the specified text content.
        /// </summary>
        /// <param name="text">Specifies the text content of the element.</param>
        public SyncedQuestionId(string text) : base(text)
        {
        }

        internal override OpenXmlSimpleType InnerTextToValue(string text)
        {
            return new StringValue { InnerText = text };
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlmsforms:syncedQuestionId");
            builder.Availability = FileFormatVersions.Microsoft365;
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<SyncedQuestionId>(deep);
    }

    /// <summary>
    /// <para>Defines the ExtensionList Class.</para>
    /// <para>This class is available in Microsoft365 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is xlmsforms:extLst.</para>
    /// </summary>
    /// <remarks>
    /// <para>The following table lists the possible child types:</para>
    /// <list type="bullet">
    ///   <item><description><see cref="DocumentFormat.OpenXml.Spreadsheet.Extension" /> <c>&lt;x:ext></c></description></item>
    /// </list>
    /// </remarks>
    public partial class ExtensionList : OpenXmlCompositeElement
    {
        /// <summary>
        /// Initializes a new instance of the ExtensionList class.
        /// </summary>
        public ExtensionList() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(IEnumerable<OpenXmlElement> childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class with the specified child elements.
        /// </summary>
        /// <param name="childElements">Specifies the child elements.</param>
        public ExtensionList(params OpenXmlElement[] childElements) : base(childElements)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ExtensionList class from outer XML.
        /// </summary>
        /// <param name="outerXml">Specifies the outer XML of the element.</param>
        public ExtensionList(string outerXml) : base(outerXml)
        {
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema("xlmsforms:extLst");
            builder.Availability = FileFormatVersions.Microsoft365;
            builder.AddChild<DocumentFormat.OpenXml.Spreadsheet.Extension>();
            builder.Particle = new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
            {
                new CompositeParticle.Builder(ParticleType.Group, 0, 1)
                {
                    new CompositeParticle.Builder(ParticleType.Sequence, 1, 1)
                    {
                        new ElementParticle(typeof(DocumentFormat.OpenXml.Spreadsheet.Extension), 0, 0)
                    }
                }
            };
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<ExtensionList>(deep);
    }
}