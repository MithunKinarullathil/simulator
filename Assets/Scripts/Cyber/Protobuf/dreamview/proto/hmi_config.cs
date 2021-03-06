// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: hmi_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.dreamview
{

    [global::ProtoBuf.ProtoContract()]
    public partial class HMIConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public HMIConfig()
        {
            modes = new global::System.Collections.Generic.Dictionary<string, string>();
            maps = new global::System.Collections.Generic.Dictionary<string, string>();
            vehicles = new global::System.Collections.Generic.Dictionary<string, string>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, string> modes { get; private set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, string> maps { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::ProtoBuf.ProtoMap]
        public global::System.Collections.Generic.Dictionary<string, string> vehicles { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class AudioCapture : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public AudioCapture()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public byte[] wav_stream
        {
            get { return __pbn__wav_stream; }
            set { __pbn__wav_stream = value; }
        }
        public bool ShouldSerializewav_stream()
        {
            return __pbn__wav_stream != null;
        }
        public void Resetwav_stream()
        {
            __pbn__wav_stream = null;
        }
        private byte[] __pbn__wav_stream;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class VehicleData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public VehicleData()
        {
            data_files = new global::System.Collections.Generic.List<DataFile>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<DataFile> data_files { get; private set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class DataFile : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public DataFile()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string source_path
            {
                get { return __pbn__source_path ?? ""; }
                set { __pbn__source_path = value; }
            }
            public bool ShouldSerializesource_path()
            {
                return __pbn__source_path != null;
            }
            public void Resetsource_path()
            {
                __pbn__source_path = null;
            }
            private string __pbn__source_path;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string dest_path
            {
                get { return __pbn__dest_path ?? ""; }
                set { __pbn__dest_path = value; }
            }
            public bool ShouldSerializedest_path()
            {
                return __pbn__dest_path != null;
            }
            public void Resetdest_path()
            {
                __pbn__dest_path = null;
            }
            private string __pbn__dest_path;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum HMIAction
    {
        NONE = 0,
        SETUP_MODE = 1,
        RESET_MODE = 2,
        ENTER_AUTO_MODE = 3,
        DISENGAGE = 4,
        CHANGE_MODE = 5,
        CHANGE_MAP = 6,
        CHANGE_VEHICLE = 7,
        START_MODULE = 8,
        STOP_MODULE = 9,
        RECORD_AUDIO = 10,
    }

}

#pragma warning restore 0612, 1591, 3021
