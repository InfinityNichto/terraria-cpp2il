using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035B RID: 859
	[global::Cpp2ILInjected.Token(Token = "0x2000403")]
	internal sealed class BinaryAssembly
	{
		// Token: 0x06001D9F RID: 7583 RVA: 0x000197E4 File Offset: 0x000179E4
		[global::Cpp2ILInjected.Token(Token = "0x6001FDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D00C", Offset = "0x1B5D00C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryAssembly()
		{
			throw null;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000197E7 File Offset: 0x000179E7
		[global::Cpp2ILInjected.Token(Token = "0x6001FDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D014", Offset = "0x1B5D014", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int assemId, string assemblyString)
		{
			throw null;
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000197EA File Offset: 0x000179EA
		[global::Cpp2ILInjected.Token(Token = "0x6001FDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D020", Offset = "0x1B5D020", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000197ED File Offset: 0x000179ED
		[global::Cpp2ILInjected.Token(Token = "0x6001FE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D080", Offset = "0x1B5D080", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000197F0 File Offset: 0x000179F0
		[global::Cpp2ILInjected.Token(Token = "0x6001FE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D0BC", Offset = "0x1B5D0BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D73 RID: 3443
		[global::Cpp2ILInjected.Token(Token = "0x4001065")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int assemId;

		// Token: 0x04000D74 RID: 3444
		[global::Cpp2ILInjected.Token(Token = "0x4001066")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string assemblyString;
	}
}
