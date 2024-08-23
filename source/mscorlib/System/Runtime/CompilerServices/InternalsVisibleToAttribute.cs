using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003E3 RID: 995
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200049B")]
	public sealed class InternalsVisibleToAttribute : global::System.Attribute
	{
		// Token: 0x0600201A RID: 8218 RVA: 0x00019EEF File Offset: 0x000180EF
		[global::Cpp2ILInjected.Token(Token = "0x600228A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75904", Offset = "0x1B75904", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public InternalsVisibleToAttribute(string assemblyName)
		{
			throw null;
		}

		// Token: 0x17000417 RID: 1047
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x00019EF2 File Offset: 0x000180F2
		[global::Cpp2ILInjected.Token(Token = "0x1700047B")]
		public bool AllInternalsVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x600228B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75934", Offset = "0x1B75934", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000FDA RID: 4058
		[global::Cpp2ILInjected.Token(Token = "0x40012E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _assemblyName;

		// Token: 0x04000FDB RID: 4059
		[global::Cpp2ILInjected.Token(Token = "0x40012E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _allInternalsVisible;
	}
}
