using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	// Token: 0x02000093 RID: 147
	[AttributeUsage(AttributeTargets.Field)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BD")]
	public class XmlEnumAttribute : Attribute
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x0000449F File Offset: 0x0000269F
		[global::Cpp2ILInjected.Token(Token = "0x60007F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A68", Offset = "0x1DB3A68", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlEnumAttribute(string name)
		{
			throw null;
		}

		// Token: 0x0400029A RID: 666
		[global::Cpp2ILInjected.Token(Token = "0x400040C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;
	}
}
