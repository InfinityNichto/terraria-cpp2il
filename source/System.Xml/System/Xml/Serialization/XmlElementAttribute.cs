using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	// Token: 0x02000092 RID: 146
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BC")]
	public class XmlElementAttribute : Attribute
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x0000449C File Offset: 0x0000269C
		[global::Cpp2ILInjected.Token(Token = "0x60007F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A34", Offset = "0x1DB3A34", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlElementAttribute(string elementName, Type type)
		{
			throw null;
		}

		// Token: 0x04000297 RID: 663
		[global::Cpp2ILInjected.Token(Token = "0x4000409")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string elementName;

		// Token: 0x04000298 RID: 664
		[global::Cpp2ILInjected.Token(Token = "0x400040A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Type type;

		// Token: 0x04000299 RID: 665
		[global::Cpp2ILInjected.Token(Token = "0x400040B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int order;
	}
}
