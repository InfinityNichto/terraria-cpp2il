using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D0")]
	[global::System.Serializable]
	internal sealed class MemberHolder
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001EE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5139C", Offset = "0x1B5139C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberHolder(global::System.Type type, StreamingContext ctx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B513D8", Offset = "0x1B513D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001EE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B513E8", Offset = "0x1B513E8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly global::System.Type _memberType;

		[global::Cpp2ILInjected.Token(Token = "0x4000F80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly StreamingContext _context;
	}
}
