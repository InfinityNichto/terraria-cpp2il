using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public enum BindingSourceRejectionType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		DuplicateBindingOnAction,
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		DuplicateBindingOnActionSet
	}
}
