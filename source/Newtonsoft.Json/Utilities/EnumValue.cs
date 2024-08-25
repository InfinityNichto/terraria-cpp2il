using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000068")]
	internal class EnumValue<T> where T : struct
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x164228C", Offset = "0x164228C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
		public T Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1642294", Offset = "0x1642294", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x164229C", Offset = "0x164229C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EnumValue(string name, T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;

		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T _value;
	}
}
