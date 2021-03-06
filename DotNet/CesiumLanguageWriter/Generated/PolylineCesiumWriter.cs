// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Polyline</c> to a <see cref="CesiumOutputStream" />.  A <c>Polyline</c> is a polyline, which is a line in the scene composed of multiple segments.
    /// </summary>
    public class PolylineCesiumWriter : CesiumPropertyWriter<PolylineCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>positions</c> property.
        /// </summary>
        public const string PositionsPropertyName = "positions";

        /// <summary>
        /// The name of the <c>width</c> property.
        /// </summary>
        public const string WidthPropertyName = "width";

        /// <summary>
        /// The name of the <c>granularity</c> property.
        /// </summary>
        public const string GranularityPropertyName = "granularity";

        /// <summary>
        /// The name of the <c>material</c> property.
        /// </summary>
        public const string MaterialPropertyName = "material";

        /// <summary>
        /// The name of the <c>followSurface</c> property.
        /// </summary>
        public const string FollowSurfacePropertyName = "followSurface";

        /// <summary>
        /// The name of the <c>shadows</c> property.
        /// </summary>
        public const string ShadowsPropertyName = "shadows";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<PositionListCesiumWriter> m_positions = new Lazy<PositionListCesiumWriter>(() => new PositionListCesiumWriter(PositionsPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_width = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(WidthPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_granularity = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(GranularityPropertyName), false);
        private readonly Lazy<PolylineMaterialCesiumWriter> m_material = new Lazy<PolylineMaterialCesiumWriter>(() => new PolylineMaterialCesiumWriter(MaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_followSurface = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(FollowSurfacePropertyName), false);
        private readonly Lazy<ShadowModeCesiumWriter> m_shadows = new Lazy<ShadowModeCesiumWriter>(() => new ShadowModeCesiumWriter(ShadowsPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public PolylineCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected PolylineCesiumWriter(PolylineCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override PolylineCesiumWriter Clone()
        {
            return new PolylineCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowProperty(bool value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowPropertyReference(Reference value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowPropertyReference(string value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the polyline is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>positions</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>positions</c> property defines the array of positions defining the polyline as a line strip.
        /// </summary>
        public PositionListCesiumWriter PositionsWriter
        {
            get { return m_positions.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>positions</c> property.  The <c>positions</c> property defines the array of positions defining the polyline as a line strip.
        /// </summary>
        public PositionListCesiumWriter OpenPositionsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(PositionsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>positions</c> property as a <c>cartesian</c> value.  The <c>positions</c> property specifies the array of positions defining the polyline as a line strip.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WritePositionsProperty(IEnumerable<Cartesian> values)
        {
            using (var writer = OpenPositionsProperty())
            {
                writer.WriteCartesian(values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>positions</c> property as a <c>cartographicRadians</c> value.  The <c>positions</c> property specifies the array of positions defining the polyline as a line strip.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WritePositionsPropertyCartographicRadians(IEnumerable<Cartographic> values)
        {
            using (var writer = OpenPositionsProperty())
            {
                writer.WriteCartographicRadians(values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>positions</c> property as a <c>cartographicDegrees</c> value.  The <c>positions</c> property specifies the array of positions defining the polyline as a line strip.
        /// </summary>
        /// <param name="values">The values.</param>
        public void WritePositionsPropertyCartographicDegrees(IEnumerable<Cartographic> values)
        {
            using (var writer = OpenPositionsProperty())
            {
                writer.WriteCartographicDegrees(values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>positions</c> property as a <c>references</c> value.  The <c>positions</c> property specifies the array of positions defining the polyline as a line strip.
        /// </summary>
        /// <param name="references">The list of references.</param>
        public void WritePositionsPropertyReferences(IEnumerable<Reference> references)
        {
            using (var writer = OpenPositionsProperty())
            {
                writer.WriteReferences(references);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>width</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>width</c> property defines the width of the polyline.
        /// </summary>
        public DoubleCesiumWriter WidthWriter
        {
            get { return m_width.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>width</c> property.  The <c>width</c> property defines the width of the polyline.
        /// </summary>
        public DoubleCesiumWriter OpenWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(WidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteWidthProperty(double value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>number</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteWidthPropertyReference(Reference value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteWidthPropertyReference(string value)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>width</c> property as a <c>reference</c> value.  The <c>width</c> property specifies the width of the polyline.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>granularity</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>granularity</c> property defines the sampling distance, in radians.
        /// </summary>
        public DoubleCesiumWriter GranularityWriter
        {
            get { return m_granularity.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>granularity</c> property.  The <c>granularity</c> property defines the sampling distance, in radians.
        /// </summary>
        public DoubleCesiumWriter OpenGranularityProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(GranularityWriter);
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>number</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteGranularityProperty(double value)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>number</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteGranularityProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>number</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteGranularityProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>reference</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteGranularityPropertyReference(Reference value)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>reference</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteGranularityPropertyReference(string value)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>reference</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteGranularityPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>granularity</c> property as a <c>reference</c> value.  The <c>granularity</c> property specifies the sampling distance, in radians.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteGranularityPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenGranularityProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>material</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>material</c> property defines the material to use to draw the polyline.
        /// </summary>
        public PolylineMaterialCesiumWriter MaterialWriter
        {
            get { return m_material.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>material</c> property.  The <c>material</c> property defines the material to use to draw the polyline.
        /// </summary>
        public PolylineMaterialCesiumWriter OpenMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>followSurface</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>followSurface</c> property defines whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter FollowSurfaceWriter
        {
            get { return m_followSurface.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>followSurface</c> property.  The <c>followSurface</c> property defines whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenFollowSurfaceProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(FollowSurfaceWriter);
        }

        /// <summary>
        /// Writes a value for the <c>followSurface</c> property as a <c>boolean</c> value.  The <c>followSurface</c> property specifies whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteFollowSurfaceProperty(bool value)
        {
            using (var writer = OpenFollowSurfaceProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>followSurface</c> property as a <c>reference</c> value.  The <c>followSurface</c> property specifies whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteFollowSurfacePropertyReference(Reference value)
        {
            using (var writer = OpenFollowSurfaceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>followSurface</c> property as a <c>reference</c> value.  The <c>followSurface</c> property specifies whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteFollowSurfacePropertyReference(string value)
        {
            using (var writer = OpenFollowSurfaceProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>followSurface</c> property as a <c>reference</c> value.  The <c>followSurface</c> property specifies whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteFollowSurfacePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenFollowSurfaceProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>followSurface</c> property as a <c>reference</c> value.  The <c>followSurface</c> property specifies whether or not the positions are connected as great arcs (the default) or as straight lines.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteFollowSurfacePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenFollowSurfaceProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>shadows</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>shadows</c> property defines whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        public ShadowModeCesiumWriter ShadowsWriter
        {
            get { return m_shadows.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>shadows</c> property.  The <c>shadows</c> property defines whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        public ShadowModeCesiumWriter OpenShadowsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShadowsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>shadowMode</c> value.  The <c>shadows</c> property specifies whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="value">The shadow mode.</param>
        public void WriteShadowsProperty(CesiumShadowMode value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteShadowMode(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShadowsPropertyReference(Reference value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShadowsPropertyReference(string value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShadowsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the polyline casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShadowsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
