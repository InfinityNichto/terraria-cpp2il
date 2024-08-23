using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035C RID: 860
	[global::Cpp2ILInjected.Token(Token = "0x2000404")]
	internal sealed class BinaryCrossAppDomainAssembly
	{
		// Token: 0x06001DA4 RID: 7588 RVA: 0x000197F3 File Offset: 0x000179F3
		[global::Cpp2ILInjected.Token(Token = "0x6001FE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D0C0", Offset = "0x1B5D0C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryCrossAppDomainAssembly()
		{
			throw null;
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000197F6 File Offset: 0x000179F6
		[global::Cpp2ILInjected.Token(Token = "0x6001FE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D0C8", Offset = "0x1B5D0C8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000197F9 File Offset: 0x000179F9
		[global::Cpp2ILInjected.Token(Token = "0x6001FE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D104", Offset = "0x1B5D104", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D75 RID: 3445
		[global::Cpp2ILInjected.Token(Token = "0x4001067")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int assemId;

		// Token: 0x04000D76 RID: 3446
		[global::Cpp2ILInjected.Token(Token = "0x4001068")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int assemblyIndex;
	}
}
