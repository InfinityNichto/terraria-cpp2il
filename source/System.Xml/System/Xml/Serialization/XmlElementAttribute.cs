using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	public class XmlElementAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A34", Offset = "0x1DB3A34", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlElementAttribute(string elementName, Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string elementName;

		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Type type;

		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int order;
	}
}
