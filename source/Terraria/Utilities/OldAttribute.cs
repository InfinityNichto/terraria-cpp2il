using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Utilities
{
	[global::Cpp2ILInjected.Token(Token = "0x2000506")]
	public sealed class OldAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303398", Offset = "0x1303398", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public OldAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003119")]
		[global::Cpp2ILInjected.Address(RVA = "0x13033EC", Offset = "0x13033EC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OldAttribute(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000624")]
		public string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x600311A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303414", Offset = "0x1303414", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003AEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string message;
	}
}
