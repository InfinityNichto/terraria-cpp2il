using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.CodeDom.Compiler
{
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000C6")]
	public sealed class GeneratedCodeAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC48E4", Offset = "0x1EC48E4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public GeneratedCodeAttribute(string tool, string version)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400038B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string tool;

		[global::Cpp2ILInjected.Token(Token = "0x400038C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string version;
	}
}
