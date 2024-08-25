using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	public class XmlAttributeAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A0C", Offset = "0x1DB3A0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlAttributeAttribute(string attributeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000408")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string attributeName;
	}
}
