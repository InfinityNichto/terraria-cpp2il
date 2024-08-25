using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200044A")]
	public sealed class FieldOffsetAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7043C", Offset = "0x1B7043C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FieldOffsetAttribute(int offset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int _val;
	}
}
