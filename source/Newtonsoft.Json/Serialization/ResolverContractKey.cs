using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000088")]
	internal struct ResolverContractKey
	{
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3CA8", Offset = "0x1CE3CA8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ResolverContractKey(Type resolverType, Type contractType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3CB0", Offset = "0x1CE3CB0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3CEC", Offset = "0x1CE3CEC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3D74", Offset = "0x1CE3D74", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ResolverContractKey other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000223")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Type _resolverType;

		[global::Cpp2ILInjected.Token(Token = "0x4000224")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly Type _contractType;
	}
}
