using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x2000113")]
	public struct ShaderTagId : IEquatable<ShaderTagId>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000583")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B704", Offset = "0x1F8B704", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "TagToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		public ShaderTagId(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000584")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B724", Offset = "0x1F8B724", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000585")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B79C", Offset = "0x1F8B79C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ShaderTagId other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000586")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B7AC", Offset = "0x1F8B7AC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000490")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_Id;
	}
}
