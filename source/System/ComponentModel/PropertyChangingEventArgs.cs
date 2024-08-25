using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D2")]
	public class PropertyChangingEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E605DC", Offset = "0x1E605DC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PropertyChangingEventArgs(string propertyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E1")]
		public virtual string PropertyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E60648", Offset = "0x1E60648", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
