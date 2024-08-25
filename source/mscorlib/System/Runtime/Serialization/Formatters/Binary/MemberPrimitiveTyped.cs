using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200040B")]
	internal sealed class MemberPrimitiveTyped
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5E0", Offset = "0x1B5D5E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberPrimitiveTyped()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5E8", Offset = "0x1B5D5E8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6002000")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D688", Offset = "0x1B5D688", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400107F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal InternalPrimitiveTypeE primitiveTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object value;
	}
}
