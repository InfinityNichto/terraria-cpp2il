using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

namespace System.ComponentModel
{
	// Token: 0x02000009 RID: 9
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000009")]
	public class PropertyChangingEventArgs : EventArgs
	{
		// Token: 0x06000026 RID: 38 RVA: 0x0000213B File Offset: 0x0000033B
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB6244", Offset = "0x1CB6244", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JObject), Member = "OnPropertyChanging", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PropertyChangingEventArgs(string propertyName)
		{
			throw null;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000027 RID: 39 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002141 File Offset: 0x00000341
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		public virtual string PropertyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000027")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB62BC", Offset = "0x1CB62BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000028")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB62C4", Offset = "0x1CB62C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400000D RID: 13
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <PropertyName>k__BackingField;
	}
}
