using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	// Token: 0x02000016 RID: 22
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	public class ShowNonSerializedFieldAttribute : DrawerAttribute
	{
		// Token: 0x0600003A RID: 58 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB574C", Offset = "0x1CB574C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ShowNonSerializedFieldAttribute()
		{
			throw null;
		}
	}
}
