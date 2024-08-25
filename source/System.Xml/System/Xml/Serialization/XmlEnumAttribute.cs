using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Field)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BD")]
	public class XmlEnumAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A68", Offset = "0x1DB3A68", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlEnumAttribute(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;
	}
}
