using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BE")]
	public class XmlIgnoreAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A90", Offset = "0x1DB3A90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlIgnoreAttribute()
		{
			throw null;
		}
	}
}
