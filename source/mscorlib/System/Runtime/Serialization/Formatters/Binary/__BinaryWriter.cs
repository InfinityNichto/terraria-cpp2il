using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036F RID: 879
	[global::Cpp2ILInjected.Token(Token = "0x2000417")]
	internal sealed class __BinaryWriter
	{
		// Token: 0x06001E0F RID: 7695 RVA: 0x00019934 File Offset: 0x00017B34
		[global::Cpp2ILInjected.Token(Token = "0x600204D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60A64", Offset = "0x1B60A64", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.BinaryWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal __BinaryWriter(global::System.IO.Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle)
		{
			throw null;
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00019937 File Offset: 0x00017B37
		[global::Cpp2ILInjected.Token(Token = "0x600204E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60DE0", Offset = "0x1B60DE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void WriteBegin()
		{
			throw null;
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0001993A File Offset: 0x00017B3A
		[global::Cpp2ILInjected.Token(Token = "0x600204F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60DE4", Offset = "0x1B60DE4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteEnd()
		{
			throw null;
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x0001993D File Offset: 0x00017B3D
		[global::Cpp2ILInjected.Token(Token = "0x6002050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60DF4", Offset = "0x1B60DF4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteBoolean(bool value)
		{
			throw null;
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00019940 File Offset: 0x00017B40
		[global::Cpp2ILInjected.Token(Token = "0x6002051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5BE70", Offset = "0x1B5BE70", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00019943 File Offset: 0x00017B43
		[global::Cpp2ILInjected.Token(Token = "0x6002052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60E08", Offset = "0x1B60E08", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteBytes(byte[] value)
		{
			throw null;
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00019946 File Offset: 0x00017B46
		[global::Cpp2ILInjected.Token(Token = "0x6002053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60E1C", Offset = "0x1B60E1C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteBytes(byte[] byteA, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00019949 File Offset: 0x00017B49
		[global::Cpp2ILInjected.Token(Token = "0x6002054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60E30", Offset = "0x1B60E30", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteChar(char value)
		{
			throw null;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0001994C File Offset: 0x00017B4C
		[global::Cpp2ILInjected.Token(Token = "0x6002055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60E44", Offset = "0x1B60E44", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteChars(char[] value)
		{
			throw null;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0001994F File Offset: 0x00017B4F
		[global::Cpp2ILInjected.Token(Token = "0x6002056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60E58", Offset = "0x1B60E58", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "ToString", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void WriteDecimal(decimal value)
		{
			throw null;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00019952 File Offset: 0x00017B52
		[global::Cpp2ILInjected.Token(Token = "0x6002057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F10", Offset = "0x1B60F10", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteSingle(float value)
		{
			throw null;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00019955 File Offset: 0x00017B55
		[global::Cpp2ILInjected.Token(Token = "0x6002058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F24", Offset = "0x1B60F24", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteDouble(double value)
		{
			throw null;
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00019958 File Offset: 0x00017B58
		[global::Cpp2ILInjected.Token(Token = "0x6002059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F38", Offset = "0x1B60F38", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteInt16(short value)
		{
			throw null;
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0001995B File Offset: 0x00017B5B
		[global::Cpp2ILInjected.Token(Token = "0x600205A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5BE94", Offset = "0x1B5BE94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteInt32(int value)
		{
			throw null;
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x0001995E File Offset: 0x00017B5E
		[global::Cpp2ILInjected.Token(Token = "0x600205B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F4C", Offset = "0x1B60F4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteInt64(long value)
		{
			throw null;
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00019961 File Offset: 0x00017B61
		[global::Cpp2ILInjected.Token(Token = "0x600205C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F60", Offset = "0x1B60F60", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteSByte(sbyte value)
		{
			throw null;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00019964 File Offset: 0x00017B64
		[global::Cpp2ILInjected.Token(Token = "0x600205D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5BE80", Offset = "0x1B5BE80", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteString(string value)
		{
			throw null;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00019967 File Offset: 0x00017B67
		[global::Cpp2ILInjected.Token(Token = "0x600205E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F70", Offset = "0x1B60F70", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteTimeSpan(global::System.TimeSpan value)
		{
			throw null;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0001996A File Offset: 0x00017B6A
		[global::Cpp2ILInjected.Token(Token = "0x600205F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F84", Offset = "0x1B60F84", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteDateTime(global::System.DateTime value)
		{
			throw null;
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0001996D File Offset: 0x00017B6D
		[global::Cpp2ILInjected.Token(Token = "0x6002060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60F98", Offset = "0x1B60F98", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteUInt16(ushort value)
		{
			throw null;
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00019970 File Offset: 0x00017B70
		[global::Cpp2ILInjected.Token(Token = "0x6002061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60FAC", Offset = "0x1B60FAC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteUInt32(uint value)
		{
			throw null;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00019973 File Offset: 0x00017B73
		[global::Cpp2ILInjected.Token(Token = "0x6002062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60FC0", Offset = "0x1B60FC0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void WriteUInt64(ulong value)
		{
			throw null;
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00019976 File Offset: 0x00017B76
		[global::Cpp2ILInjected.Token(Token = "0x6002063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60FD4", Offset = "0x1B60FD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(object[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			throw null;
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00019979 File Offset: 0x00017B79
		[global::Cpp2ILInjected.Token(Token = "0x6002064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B60FD8", Offset = "0x1B60FD8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void WriteSerializationHeaderEnd()
		{
			throw null;
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0001997C File Offset: 0x00017B7C
		[global::Cpp2ILInjected.Token(Token = "0x6002065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61038", Offset = "0x1B61038", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteSerializedStreamHeader", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationHeaderRecord), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion)
		{
			throw null;
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0001997F File Offset: 0x00017B7F
		[global::Cpp2ILInjected.Token(Token = "0x6002066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B610C8", Offset = "0x1B610C8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryMethodCall), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteMethodCall()
		{
			throw null;
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00019982 File Offset: 0x00017B82
		[global::Cpp2ILInjected.Token(Token = "0x6002067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61138", Offset = "0x1B61138", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryMethodReturn), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteMethodReturn()
		{
			throw null;
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00019985 File Offset: 0x00017B85
		[global::Cpp2ILInjected.Token(Token = "0x6002068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B611A8", Offset = "0x1B611A8", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(object[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMapInfo), Member = "isCompatible", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string[]),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObject), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(string),
			typeof(ObjectWriter),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMapTyped), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectWithMap), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, global::System.Type[] memberTypes, WriteObjectInfo[] memberObjectInfos)
		{
			throw null;
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00019988 File Offset: 0x00017B88
		[global::Cpp2ILInjected.Token(Token = "0x6002069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61764", Offset = "0x1B61764", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMemberString", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryObjectString), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteObjectString(int objectId, string value)
		{
			throw null;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0001998B File Offset: 0x00017B8B
		[global::Cpp2ILInjected.Token(Token = "0x600206A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B617EC", Offset = "0x1B617EC", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObjectByteArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(string),
			typeof(ObjectWriter),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "TypeLength", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteArrayAsBytes", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, global::System.Array array)
		{
			throw null;
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x0001998E File Offset: 0x00017B8E
		[global::Cpp2ILInjected.Token(Token = "0x600206B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61AAC", Offset = "0x1B61AAC", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void WriteArrayAsBytes(global::System.Array array, int typeLength)
		{
			throw null;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00019991 File Offset: 0x00017B91
		[global::Cpp2ILInjected.Token(Token = "0x600206C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61C9C", Offset = "0x1B61C9C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(string),
			typeof(ObjectWriter),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound)
		{
			throw null;
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00019994 File Offset: 0x00017B94
		[global::Cpp2ILInjected.Token(Token = "0x600206D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61DF0", Offset = "0x1B61DF0", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameInfo), Member = "get_NIname", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(string),
			typeof(ObjectWriter),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryArray), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA)
		{
			throw null;
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00019997 File Offset: 0x00017B97
		[global::Cpp2ILInjected.Token(Token = "0x600206E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61F20", Offset = "0x1B61F20", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA)
		{
			throw null;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x0001999A File Offset: 0x00017B9A
		[global::Cpp2ILInjected.Token(Token = "0x600206F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B61F80", Offset = "0x1B61F80", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItem", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberPrimitiveTyped), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value)
		{
			throw null;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x0001999D File Offset: 0x00017B9D
		[global::Cpp2ILInjected.Token(Token = "0x6002070")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62070", Offset = "0x1B62070", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "CheckForNull", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			throw null;
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000199A0 File Offset: 0x00017BA0
		[global::Cpp2ILInjected.Token(Token = "0x6002071")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B620FC", Offset = "0x1B620FC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItemObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef)
		{
			throw null;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x000199A3 File Offset: 0x00017BA3
		[global::Cpp2ILInjected.Token(Token = "0x6002072")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62194", Offset = "0x1B62194", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		internal void WriteMemberNested(NameInfo memberNameInfo)
		{
			throw null;
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000199A6 File Offset: 0x00017BA6
		[global::Cpp2ILInjected.Token(Token = "0x6002073")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62198", Offset = "0x1B62198", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value)
		{
			throw null;
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x000199A9 File Offset: 0x00017BA9
		[global::Cpp2ILInjected.Token(Token = "0x6002074")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B621C8", Offset = "0x1B621C8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value)
		{
			throw null;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x000199AC File Offset: 0x00017BAC
		[global::Cpp2ILInjected.Token(Token = "0x6002075")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62208", Offset = "0x1B62208", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "CheckForNull", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo)
		{
			throw null;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x000199AF File Offset: 0x00017BAF
		[global::Cpp2ILInjected.Token(Token = "0x6002076")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62218", Offset = "0x1B62218", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "CheckForNull", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void WriteDelayedNullItem()
		{
			throw null;
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x000199B2 File Offset: 0x00017BB2
		[global::Cpp2ILInjected.Token(Token = "0x6002077")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62228", Offset = "0x1B62228", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		internal void WriteItemEnd()
		{
			throw null;
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x000199B5 File Offset: 0x00017BB5
		[global::Cpp2ILInjected.Token(Token = "0x6002078")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B615B4", Offset = "0x1B615B4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteArrayAsBytes", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObjectByteArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteNullMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMemberNested", MemberParameters = new object[] { typeof(NameInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMemberString", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItem", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteNullItem", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItemEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteItemObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectNull), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InternalWriteItemNull()
		{
			throw null;
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x000199B8 File Offset: 0x00017BB8
		[global::Cpp2ILInjected.Token(Token = "0x6002079")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6222C", Offset = "0x1B6222C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void WriteItemObjectRef(NameInfo nameInfo, int idRef)
		{
			throw null;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x000199BB File Offset: 0x00017BBB
		[global::Cpp2ILInjected.Token(Token = "0x600207A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6225C", Offset = "0x1B6225C", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "InternalWriteItemNull", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssembly), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void WriteAssembly(global::System.Type type, string assemblyString, int assemId, bool isNew)
		{
			throw null;
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x000199BE File Offset: 0x00017BBE
		[global::Cpp2ILInjected.Token(Token = "0x600207B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C67C", Offset = "0x1B5C67C", Length = "0x5FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberPrimitiveTyped), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberPrimitiveUnTyped), Member = "Write", MemberParameters = new object[] { typeof(__BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToBoolean", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToChar", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToSByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToDecimal", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(decimal))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteDecimal", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToByte", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
		internal void WriteValue(InternalPrimitiveTypeE code, object value)
		{
			throw null;
		}

		// Token: 0x04000E01 RID: 3585
		[global::Cpp2ILInjected.Token(Token = "0x40010F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IO.Stream sout;

		// Token: 0x04000E02 RID: 3586
		[global::Cpp2ILInjected.Token(Token = "0x40010F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal FormatterTypeStyle formatterTypeStyle;

		// Token: 0x04000E03 RID: 3587
		[global::Cpp2ILInjected.Token(Token = "0x40010F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal global::System.Collections.Hashtable objectMapTable;

		// Token: 0x04000E04 RID: 3588
		[global::Cpp2ILInjected.Token(Token = "0x40010F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal ObjectWriter objectWriter;

		// Token: 0x04000E05 RID: 3589
		[global::Cpp2ILInjected.Token(Token = "0x40010F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.IO.BinaryWriter dataWriter;

		// Token: 0x04000E06 RID: 3590
		[global::Cpp2ILInjected.Token(Token = "0x40010F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal int m_nestedObjectCount;

		// Token: 0x04000E07 RID: 3591
		[global::Cpp2ILInjected.Token(Token = "0x40010F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int nullCount;

		// Token: 0x04000E08 RID: 3592
		[global::Cpp2ILInjected.Token(Token = "0x40010FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal BinaryMethodCall binaryMethodCall;

		// Token: 0x04000E09 RID: 3593
		[global::Cpp2ILInjected.Token(Token = "0x40010FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal BinaryMethodReturn binaryMethodReturn;

		// Token: 0x04000E0A RID: 3594
		[global::Cpp2ILInjected.Token(Token = "0x40010FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal BinaryObject binaryObject;

		// Token: 0x04000E0B RID: 3595
		[global::Cpp2ILInjected.Token(Token = "0x40010FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal BinaryObjectWithMap binaryObjectWithMap;

		// Token: 0x04000E0C RID: 3596
		[global::Cpp2ILInjected.Token(Token = "0x40010FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal BinaryObjectWithMapTyped binaryObjectWithMapTyped;

		// Token: 0x04000E0D RID: 3597
		[global::Cpp2ILInjected.Token(Token = "0x40010FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal BinaryObjectString binaryObjectString;

		// Token: 0x04000E0E RID: 3598
		[global::Cpp2ILInjected.Token(Token = "0x4001100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal BinaryArray binaryArray;

		// Token: 0x04000E0F RID: 3599
		[global::Cpp2ILInjected.Token(Token = "0x4001101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private byte[] byteBuffer;

		// Token: 0x04000E10 RID: 3600
		[global::Cpp2ILInjected.Token(Token = "0x4001102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private int chunkSize;

		// Token: 0x04000E11 RID: 3601
		[global::Cpp2ILInjected.Token(Token = "0x4001103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal MemberPrimitiveUnTyped memberPrimitiveUnTyped;

		// Token: 0x04000E12 RID: 3602
		[global::Cpp2ILInjected.Token(Token = "0x4001104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal MemberPrimitiveTyped memberPrimitiveTyped;

		// Token: 0x04000E13 RID: 3603
		[global::Cpp2ILInjected.Token(Token = "0x4001105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal ObjectNull objectNull;

		// Token: 0x04000E14 RID: 3604
		[global::Cpp2ILInjected.Token(Token = "0x4001106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal MemberReference memberReference;

		// Token: 0x04000E15 RID: 3605
		[global::Cpp2ILInjected.Token(Token = "0x4001107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal BinaryAssembly binaryAssembly;
	}
}
