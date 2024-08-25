using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BA")]
	internal class XmlTypeConvertorAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001EC")]
		private string Method
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60007F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB39DC", Offset = "0x1DB39DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB39E4", Offset = "0x1DB39E4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlTypeConvertorAttribute(string method)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000407")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <Method>k__BackingField;
	}
}
