using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200044B")]
	public sealed class ComCompatibleVersionAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70464", Offset = "0x1B70464", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int _major;

		[global::Cpp2ILInjected.Token(Token = "0x4001272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int _minor;

		[global::Cpp2ILInjected.Token(Token = "0x4001273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int _build;

		[global::Cpp2ILInjected.Token(Token = "0x4001274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int _revision;
	}
}
