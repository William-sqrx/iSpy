// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ma_metrics_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ma_metrics_data.proto</summary>
public static partial class MaMetricsDataReflection {

  #region Descriptor
  /// <summary>File descriptor for ma_metrics_data.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MaMetricsDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChVtYV9tZXRyaWNzX2RhdGEucHJvdG8aF21hX2NvbGxpc2lvbl9kYXRhLnBy",
          "b3RvGhNtYV9wdW5jaF9kYXRhLnByb3RvGhZtYV9zZXF1ZW5jZV9kYXRhLnBy",
          "b3RvIpQBCgtNZXRyaWNzRGF0YRIVCg1yZWFjdGlvbl90aW1lGAEgASgCEh4K",
          "CnB1bmNoX2RhdGEYAiABKAsyCi5QdW5jaERhdGESJAoNc2VxdWVuY2VfZGF0",
          "YRgDIAEoCzINLlNlcXVlbmNlRGF0YRIoCg5jb2xsaXNpb25fZGF0YRgEIAEo",
          "CzIQLk1hQ29sbGlzaW9uRGF0YQ=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MaCollisionDataReflection.Descriptor, global::MaPunchDataReflection.Descriptor, global::MaSequenceDataReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MetricsData), global::MetricsData.Parser, new[]{ "ReactionTime", "PunchData", "SequenceData", "CollisionData" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
[global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
public sealed partial class MetricsData : pb::IMessage<MetricsData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<MetricsData> _parser = new pb::MessageParser<MetricsData>(() => new MetricsData());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<MetricsData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MaMetricsDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MetricsData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MetricsData(MetricsData other) : this() {
    _hasBits0 = other._hasBits0;
    reactionTime_ = other.reactionTime_;
    punchData_ = other.punchData_ != null ? other.punchData_.Clone() : null;
    sequenceData_ = other.sequenceData_ != null ? other.sequenceData_.Clone() : null;
    collisionData_ = other.collisionData_ != null ? other.collisionData_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public MetricsData Clone() {
    return new MetricsData(this);
  }

  /// <summary>Field number for the "reaction_time" field.</summary>
  public const int ReactionTimeFieldNumber = 1;
  private readonly static float ReactionTimeDefaultValue = 0F;

  private float reactionTime_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float ReactionTime {
    get { if ((_hasBits0 & 1) != 0) { return reactionTime_; } else { return ReactionTimeDefaultValue; } }
    set {
      _hasBits0 |= 1;
      reactionTime_ = value;
    }
  }
  /// <summary>Gets whether the "reaction_time" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasReactionTime {
    get { return (_hasBits0 & 1) != 0; }
  }
  /// <summary>Clears the value of the "reaction_time" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearReactionTime() {
    _hasBits0 &= ~1;
  }

  /// <summary>Field number for the "punch_data" field.</summary>
  public const int PunchDataFieldNumber = 2;
  private global::PunchData punchData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::PunchData PunchData {
    get { return punchData_; }
    set {
      punchData_ = value;
    }
  }

  /// <summary>Field number for the "sequence_data" field.</summary>
  public const int SequenceDataFieldNumber = 3;
  private global::SequenceData sequenceData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::SequenceData SequenceData {
    get { return sequenceData_; }
    set {
      sequenceData_ = value;
    }
  }

  /// <summary>Field number for the "collision_data" field.</summary>
  public const int CollisionDataFieldNumber = 4;
  private global::MaCollisionData collisionData_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public global::MaCollisionData CollisionData {
    get { return collisionData_; }
    set {
      collisionData_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as MetricsData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(MetricsData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ReactionTime, other.ReactionTime)) return false;
    if (!object.Equals(PunchData, other.PunchData)) return false;
    if (!object.Equals(SequenceData, other.SequenceData)) return false;
    if (!object.Equals(CollisionData, other.CollisionData)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    if (HasReactionTime) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ReactionTime);
    if (punchData_ != null) hash ^= PunchData.GetHashCode();
    if (sequenceData_ != null) hash ^= SequenceData.GetHashCode();
    if (collisionData_ != null) hash ^= CollisionData.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (HasReactionTime) {
      output.WriteRawTag(13);
      output.WriteFloat(ReactionTime);
    }
    if (punchData_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(PunchData);
    }
    if (sequenceData_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(SequenceData);
    }
    if (collisionData_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(CollisionData);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (HasReactionTime) {
      output.WriteRawTag(13);
      output.WriteFloat(ReactionTime);
    }
    if (punchData_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(PunchData);
    }
    if (sequenceData_ != null) {
      output.WriteRawTag(26);
      output.WriteMessage(SequenceData);
    }
    if (collisionData_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(CollisionData);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    if (HasReactionTime) {
      size += 1 + 4;
    }
    if (punchData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(PunchData);
    }
    if (sequenceData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(SequenceData);
    }
    if (collisionData_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(CollisionData);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(MetricsData other) {
    if (other == null) {
      return;
    }
    if (other.HasReactionTime) {
      ReactionTime = other.ReactionTime;
    }
    if (other.punchData_ != null) {
      if (punchData_ == null) {
        PunchData = new global::PunchData();
      }
      PunchData.MergeFrom(other.PunchData);
    }
    if (other.sequenceData_ != null) {
      if (sequenceData_ == null) {
        SequenceData = new global::SequenceData();
      }
      SequenceData.MergeFrom(other.SequenceData);
    }
    if (other.collisionData_ != null) {
      if (collisionData_ == null) {
        CollisionData = new global::MaCollisionData();
      }
      CollisionData.MergeFrom(other.CollisionData);
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 13: {
          ReactionTime = input.ReadFloat();
          break;
        }
        case 18: {
          if (punchData_ == null) {
            PunchData = new global::PunchData();
          }
          input.ReadMessage(PunchData);
          break;
        }
        case 26: {
          if (sequenceData_ == null) {
            SequenceData = new global::SequenceData();
          }
          input.ReadMessage(SequenceData);
          break;
        }
        case 34: {
          if (collisionData_ == null) {
            CollisionData = new global::MaCollisionData();
          }
          input.ReadMessage(CollisionData);
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 13: {
          ReactionTime = input.ReadFloat();
          break;
        }
        case 18: {
          if (punchData_ == null) {
            PunchData = new global::PunchData();
          }
          input.ReadMessage(PunchData);
          break;
        }
        case 26: {
          if (sequenceData_ == null) {
            SequenceData = new global::SequenceData();
          }
          input.ReadMessage(SequenceData);
          break;
        }
        case 34: {
          if (collisionData_ == null) {
            CollisionData = new global::MaCollisionData();
          }
          input.ReadMessage(CollisionData);
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
