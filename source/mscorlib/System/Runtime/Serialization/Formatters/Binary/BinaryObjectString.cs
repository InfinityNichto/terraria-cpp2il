using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000360 RID: 864
	[global::Cpp2ILInjected.Token(Token = "0x2000408")]
	internal sealed class BinaryObjectString
	{
		// Token: 0x06001DB3 RID: 7603 RVA: 0x00019820 File Offset: 0x00017A20
		[global::Cpp2ILInjected.Token(Token = "0x6001FF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D4B8", Offset = "0x1B5D4B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectString()
		{
			throw null;
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00019823 File Offset: 0x00017A23
		[global::Cpp2ILInjected.Token(Token = "0x6001FF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D4C0", Offset = "0x1B5D4C0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int objectId, string value)
		{
			throw null;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00019826 File Offset: 0x00017A26
		[global::Cpp2ILInjected.Token(Token = "0x6001FF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D4CC", Offset = "0x1B5D4CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00019829 File Offset: 0x00017A29
		[global::Cpp2ILInjected.Token(Token = "0x6001FF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D52C", Offset = "0x1B5D52C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x0001982C File Offset: 0x00017A2C
		[global::Cpp2ILInjected.Token(Token = "0x6001FF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D568", Offset = "0x1B5D568", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D88 RID: 3464
		[global::Cpp2ILInjected.Token(Token = "0x400107A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x04000D89 RID: 3465
		[global::Cpp2ILInjected.Token(Token = "0x400107B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string value;
	}
}
