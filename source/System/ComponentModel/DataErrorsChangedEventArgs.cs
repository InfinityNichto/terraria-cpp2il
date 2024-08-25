using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003CC")]
	public class DataErrorsChangedEventArgs : EventArgs
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6037C", Offset = "0x1E6037C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DataErrorsChangedEventArgs(string propertyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005DE")]
		public virtual string PropertyName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E603E8", Offset = "0x1E603E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string _propertyName;
	}
}
