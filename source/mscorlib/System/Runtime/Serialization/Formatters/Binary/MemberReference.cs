using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000368 RID: 872
	[global::Cpp2ILInjected.Token(Token = "0x2000410")]
	internal sealed class MemberReference
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x00019892 File Offset: 0x00017A92
		[global::Cpp2ILInjected.Token(Token = "0x6002017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E27C", Offset = "0x1B5E27C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberReference()
		{
			throw null;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00019895 File Offset: 0x00017A95
		[global::Cpp2ILInjected.Token(Token = "0x6002018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E284", Offset = "0x1B5E284", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int idRef)
		{
			throw null;
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00019898 File Offset: 0x00017A98
		[global::Cpp2ILInjected.Token(Token = "0x6002019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E28C", Offset = "0x1B5E28C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0001989B File Offset: 0x00017A9B
		[global::Cpp2ILInjected.Token(Token = "0x600201A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E2D4", Offset = "0x1B5E2D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0001989E File Offset: 0x00017A9E
		[global::Cpp2ILInjected.Token(Token = "0x600201B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E2F4", Offset = "0x1B5E2F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000DA9 RID: 3497
		[global::Cpp2ILInjected.Token(Token = "0x400109B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int idRef;
	}
}
