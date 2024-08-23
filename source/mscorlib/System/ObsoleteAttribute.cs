using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000B7 RID: 183
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
	[global::System.Serializable]
	public sealed class ObsoleteAttribute : global::System.Attribute
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x00015CBC File Offset: 0x00013EBC
		[global::Cpp2ILInjected.Token(Token = "0x60008BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44004", Offset = "0x1C44004", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ObsoleteAttribute()
		{
			throw null;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00015CBF File Offset: 0x00013EBF
		[global::Cpp2ILInjected.Token(Token = "0x60008C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44024", Offset = "0x1C44024", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ObsoleteAttribute(string message)
		{
			throw null;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00015CC2 File Offset: 0x00013EC2
		[global::Cpp2ILInjected.Token(Token = "0x60008C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44050", Offset = "0x1C44050", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ObsoleteAttribute(string message, bool error)
		{
			throw null;
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00015CC5 File Offset: 0x00013EC5
		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C44080", Offset = "0x1C44080", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400022D RID: 557
		[global::Cpp2ILInjected.Token(Token = "0x400037F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _message;

		// Token: 0x0400022E RID: 558
		[global::Cpp2ILInjected.Token(Token = "0x4000380")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _error;
	}
}
