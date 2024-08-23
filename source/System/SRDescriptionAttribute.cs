using System;
using System.ComponentModel;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200004E RID: 78
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x200009F")]
	internal class SRDescriptionAttribute : DescriptionAttribute
	{
		// Token: 0x06000244 RID: 580 RVA: 0x00003488 File Offset: 0x00001688
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA7AC0", Offset = "0x1EA7AC0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DescriptionAttribute), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public SRDescriptionAttribute(string description)
		{
			throw null;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000348B File Offset: 0x0000168B
		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		public override string Description
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA7B28", Offset = "0x1EA7B28", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "Locale", Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool isReplaced;
	}
}
