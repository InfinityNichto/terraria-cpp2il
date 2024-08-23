using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003BD RID: 957
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200046C")]
	[global::System.Serializable]
	public abstract class CustomConstantAttribute : global::System.Attribute
	{
		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001FB7 RID: 8119
		[global::Cpp2ILInjected.Token(Token = "0x17000465")]
		public abstract object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002208")]
			get;
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x00019DD5 File Offset: 0x00017FD5
		[global::Cpp2ILInjected.Token(Token = "0x6002209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B73310", Offset = "0x1B73310", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomConstantAttribute()
		{
			throw null;
		}
	}
}
