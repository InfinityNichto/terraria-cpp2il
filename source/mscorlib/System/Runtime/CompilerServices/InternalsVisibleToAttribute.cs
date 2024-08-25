using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200049B")]
	public sealed class InternalsVisibleToAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600228A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75904", Offset = "0x1B75904", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InternalsVisibleToAttribute(string assemblyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700047B")]
		public bool AllInternalsVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x600228B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75934", Offset = "0x1B75934", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _assemblyName;

		[global::Cpp2ILInjected.Token(Token = "0x40012E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _allInternalsVisible;
	}
}
