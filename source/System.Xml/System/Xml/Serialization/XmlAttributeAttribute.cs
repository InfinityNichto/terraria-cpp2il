using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	// Token: 0x02000091 RID: 145
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	public class XmlAttributeAttribute : Attribute
	{
		// Token: 0x06000767 RID: 1895 RVA: 0x00004499 File Offset: 0x00002699
		[global::Cpp2ILInjected.Token(Token = "0x60007F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A0C", Offset = "0x1DB3A0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlAttributeAttribute(string attributeName)
		{
			throw null;
		}

		// Token: 0x04000296 RID: 662
		[global::Cpp2ILInjected.Token(Token = "0x4000408")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string attributeName;
	}
}
