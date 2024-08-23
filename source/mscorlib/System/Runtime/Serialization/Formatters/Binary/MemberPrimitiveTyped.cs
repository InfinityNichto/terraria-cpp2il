using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000363 RID: 867
	[global::Cpp2ILInjected.Token(Token = "0x200040B")]
	internal sealed class MemberPrimitiveTyped
	{
		// Token: 0x06001DBE RID: 7614 RVA: 0x00019841 File Offset: 0x00017A41
		[global::Cpp2ILInjected.Token(Token = "0x6001FFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5E0", Offset = "0x1B5D5E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberPrimitiveTyped()
		{
			throw null;
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00019844 File Offset: 0x00017A44
		[global::Cpp2ILInjected.Token(Token = "0x6001FFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5E8", Offset = "0x1B5D5E8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value)
		{
			throw null;
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x00019847 File Offset: 0x00017A47
		[global::Cpp2ILInjected.Token(Token = "0x6001FFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5F4", Offset = "0x1B5D5F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0001984A File Offset: 0x00017A4A
		[global::Cpp2ILInjected.Token(Token = "0x6001FFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D648", Offset = "0x1B5D648", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadByte", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(object))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0001984D File Offset: 0x00017A4D
		[global::Cpp2ILInjected.Token(Token = "0x6002000")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D688", Offset = "0x1B5D688", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D8D RID: 3469
		[global::Cpp2ILInjected.Token(Token = "0x400107F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal InternalPrimitiveTypeE primitiveTypeEnum;

		// Token: 0x04000D8E RID: 3470
		[global::Cpp2ILInjected.Token(Token = "0x4001080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object value;
	}
}
