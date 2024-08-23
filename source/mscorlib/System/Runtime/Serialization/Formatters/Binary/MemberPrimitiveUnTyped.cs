using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000367 RID: 871
	[global::Cpp2ILInjected.Token(Token = "0x200040F")]
	internal sealed class MemberPrimitiveUnTyped
	{
		// Token: 0x06001DD3 RID: 7635 RVA: 0x00019880 File Offset: 0x00017A80
		[global::Cpp2ILInjected.Token(Token = "0x6002011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E220", Offset = "0x1B5E220", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberPrimitiveUnTyped()
		{
			throw null;
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00019883 File Offset: 0x00017A83
		[global::Cpp2ILInjected.Token(Token = "0x6002012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E228", Offset = "0x1B5E228", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(InternalPrimitiveTypeE typeInformation, object value)
		{
			throw null;
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00019886 File Offset: 0x00017A86
		[global::Cpp2ILInjected.Token(Token = "0x6002013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E234", Offset = "0x1B5E234", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(InternalPrimitiveTypeE typeInformation)
		{
			throw null;
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00019889 File Offset: 0x00017A89
		[global::Cpp2ILInjected.Token(Token = "0x6002014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E23C", Offset = "0x1B5E23C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0001988C File Offset: 0x00017A8C
		[global::Cpp2ILInjected.Token(Token = "0x6002015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E250", Offset = "0x1B5E250", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(object))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0001988F File Offset: 0x00017A8F
		[global::Cpp2ILInjected.Token(Token = "0x6002016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E278", Offset = "0x1B5E278", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000DA7 RID: 3495
		[global::Cpp2ILInjected.Token(Token = "0x4001099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal InternalPrimitiveTypeE typeInformation;

		// Token: 0x04000DA8 RID: 3496
		[global::Cpp2ILInjected.Token(Token = "0x400109A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object value;
	}
}
