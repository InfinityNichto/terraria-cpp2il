using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000018 RID: 24
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public class TagAttribute : DrawerAttribute
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB57CC", Offset = "0x1CB57CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public TagAttribute()
		{
			throw null;
		}
	}
}
