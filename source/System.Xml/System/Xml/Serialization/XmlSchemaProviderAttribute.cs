using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Serialization
{
	// Token: 0x02000095 RID: 149
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		// Token: 0x0600076B RID: 1899 RVA: 0x000044A5 File Offset: 0x000026A5
		[global::Cpp2ILInjected.Token(Token = "0x60007F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB3A98", Offset = "0x1DB3A98", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public XmlSchemaProviderAttribute(string methodName)
		{
			throw null;
		}

		// Token: 0x170001C9 RID: 457
		// (set) Token: 0x0600076C RID: 1900 RVA: 0x000044A8 File Offset: 0x000026A8
		[global::Cpp2ILInjected.Token(Token = "0x170001ED")]
		public bool IsAny
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB3AC0", Offset = "0x1DB3AC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400029B RID: 667
		[global::Cpp2ILInjected.Token(Token = "0x400040D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _methodName;

		// Token: 0x0400029C RID: 668
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _isAny;
	}
}
