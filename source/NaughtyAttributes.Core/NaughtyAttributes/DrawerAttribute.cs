using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace NaughtyAttributes
{
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public abstract class DrawerAttribute : NaughtyAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB545C", Offset = "0x1CB545C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		protected DrawerAttribute()
		{
			throw null;
		}
	}
}
