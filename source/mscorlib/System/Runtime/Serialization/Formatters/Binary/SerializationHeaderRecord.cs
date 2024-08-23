using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035A RID: 858
	[global::Cpp2ILInjected.Token(Token = "0x2000402")]
	internal sealed class SerializationHeaderRecord
	{
		// Token: 0x06001D99 RID: 7577 RVA: 0x000197D2 File Offset: 0x000179D2
		[global::Cpp2ILInjected.Token(Token = "0x6001FD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CDCC", Offset = "0x1B5CDCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SerializationHeaderRecord()
		{
			throw null;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000197D5 File Offset: 0x000179D5
		[global::Cpp2ILInjected.Token(Token = "0x6001FD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CDDC", Offset = "0x1B5CDDC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal SerializationHeaderRecord(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion)
		{
			throw null;
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x000197D8 File Offset: 0x000179D8
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

		// Token: 0x06001D9C RID: 7580 RVA: 0x000197DB File Offset: 0x000179DB
		[global::Cpp2ILInjected.Token(Token = "0x6001FDA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5CEC8", Offset = "0x1B5CEC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetInt32(byte[] buffer, int index)
		{
			throw null;
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000197DE File Offset: 0x000179DE
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

		// Token: 0x06001D9E RID: 7582 RVA: 0x000197E1 File Offset: 0x000179E1
		[global::Cpp2ILInjected.Token(Token = "0x6001FDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D008", Offset = "0x1B5D008", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D6C RID: 3436
		[global::Cpp2ILInjected.Token(Token = "0x400105E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int binaryFormatterMajorVersion;

		// Token: 0x04000D6D RID: 3437
		[global::Cpp2ILInjected.Token(Token = "0x400105F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int binaryFormatterMinorVersion;

		// Token: 0x04000D6E RID: 3438
		[global::Cpp2ILInjected.Token(Token = "0x4001060")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000D6F RID: 3439
		[global::Cpp2ILInjected.Token(Token = "0x4001061")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int topId;

		// Token: 0x04000D70 RID: 3440
		[global::Cpp2ILInjected.Token(Token = "0x4001062")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int headerId;

		// Token: 0x04000D71 RID: 3441
		[global::Cpp2ILInjected.Token(Token = "0x4001063")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int majorVersion;

		// Token: 0x04000D72 RID: 3442
		[global::Cpp2ILInjected.Token(Token = "0x4001064")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int minorVersion;
	}
}
