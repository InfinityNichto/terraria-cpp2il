using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Parameter)]
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public sealed class DefaultParameterValueAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA814C", Offset = "0x1EA814C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultParameterValueAttribute(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8174", Offset = "0x1EA8174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object value;
	}
}
