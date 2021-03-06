// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: map_road.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class BoundaryEdge : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public BoundaryEdge()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Curve curve { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(Type.UNKNOWN)]
        public Type type
        {
            get { return __pbn__type ?? Type.UNKNOWN; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            UNKNOWN = 0,
            NORMAL = 1,
            LEFT_BOUNDARY = 2,
            RIGHT_BOUNDARY = 3,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BoundaryPolygon : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public BoundaryPolygon()
        {
            edge = new global::System.Collections.Generic.List<BoundaryEdge>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<BoundaryEdge> edge { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RoadBoundary : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RoadBoundary()
        {
            hole = new global::System.Collections.Generic.List<BoundaryPolygon>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public BoundaryPolygon outer_polygon { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<BoundaryPolygon> hole { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RoadROIBoundary : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RoadROIBoundary()
        {
            road_boundaries = new global::System.Collections.Generic.List<RoadBoundary>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<RoadBoundary> road_boundaries { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RoadSection : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RoadSection()
        {
            lane_id = new global::System.Collections.Generic.List<Id>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Id> lane_id { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        public RoadBoundary boundary { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Road : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Road()
        {
            section = new global::System.Collections.Generic.List<RoadSection>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<RoadSection> section { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        public Id junction_id { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(Type.UNKNOWN)]
        public Type type
        {
            get { return __pbn__type ?? Type.UNKNOWN; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            UNKNOWN = 0,
            HIGHWAY = 1,
            CITY_ROAD = 2,
            PARK = 3,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
