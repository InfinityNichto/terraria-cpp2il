using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200035C")]
	public abstract class ContainerFilterService
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41A1C", Offset = "0x1E41A1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ContainerFilterService()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41A24", Offset = "0x1E41A24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual ComponentCollection FilterComponents(ComponentCollection components)
		{
			throw null;
		}
	}
}
