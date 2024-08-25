using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000402")]
	internal sealed class SerializationHeaderRecord
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CDCC", Offset = "0x1B5CDCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SerializationHeaderRecord()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CDDC", Offset = "0x1B5CDDC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FD9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CE34", Offset = "0x1B5CE34", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSerializationHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CEC8", Offset = "0x1B5CEC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetInt32(byte[] buffer, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FDB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CEF8", Offset = "0x1B5CEF8", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.__Error), Member = "EndOfFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D008", Offset = "0x1B5D008", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400105E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int binaryFormatterMajorVersion;

		[global::Cpp2ILInjected.Token(Token = "0x400105F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int binaryFormatterMinorVersion;

		[global::Cpp2ILInjected.Token(Token = "0x4001060")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001061")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int topId;

		[global::Cpp2ILInjected.Token(Token = "0x4001062")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int headerId;

		[global::Cpp2ILInjected.Token(Token = "0x4001063")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int majorVersion;

		[global::Cpp2ILInjected.Token(Token = "0x4001064")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int minorVersion;
	}
}
