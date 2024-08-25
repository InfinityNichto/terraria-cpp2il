using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x200038C")]
	public abstract class InstanceCreationEditor
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000568")]
		public virtual string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4D0DC", Offset = "0x1E4D0DC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017AF")]
		public abstract object CreateInstance(ITypeDescriptorContext context, Type instanceType);

		[global::Cpp2ILInjected.Token(Token = "0x60017B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D11C", Offset = "0x1E4D11C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected InstanceCreationEditor()
		{
			throw null;
		}
	}
}
