using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000361 RID: 865
	[global::Cpp2ILInjected.Token(Token = "0x2000409")]
	internal sealed class BinaryCrossAppDomainString
	{
		// Token: 0x06001DB8 RID: 7608 RVA: 0x0001982F File Offset: 0x00017A2F
		[global::Cpp2ILInjected.Token(Token = "0x6001FF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D56C", Offset = "0x1B5D56C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryCrossAppDomainString()
		{
			throw null;
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00019832 File Offset: 0x00017A32
		[global::Cpp2ILInjected.Token(Token = "0x6001FF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D574", Offset = "0x1B5D574", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x00019835 File Offset: 0x00017A35
		[global::Cpp2ILInjected.Token(Token = "0x6001FF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5B0", Offset = "0x1B5D5B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D8A RID: 3466
		[global::Cpp2ILInjected.Token(Token = "0x400107C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectId;

		// Token: 0x04000D8B RID: 3467
		[global::Cpp2ILInjected.Token(Token = "0x400107D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int value;
	}
}
