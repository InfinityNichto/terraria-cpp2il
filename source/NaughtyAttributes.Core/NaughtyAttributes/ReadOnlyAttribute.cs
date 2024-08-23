using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000011 RID: 17
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	public class ReadOnlyAttribute : DrawerAttribute
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB56E0", Offset = "0x1CB56E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ReadOnlyAttribute()
		{
			throw null;
		}
	}
}
