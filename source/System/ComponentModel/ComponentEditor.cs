using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200034D")]
	public abstract class ComponentEditor
	{
		[global::Cpp2ILInjected.Token(Token = "0x60015F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F150", Offset = "0x1E3F150", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool EditComponent(object component)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60015FA")]
		public abstract bool EditComponent(ITypeDescriptorContext context, object component);

		[global::Cpp2ILInjected.Token(Token = "0x60015FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3F164", Offset = "0x1E3F164", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ComponentEditor()
		{
			throw null;
		}
	}
}
