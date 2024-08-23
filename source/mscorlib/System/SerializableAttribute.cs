using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C5 RID: 197
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Delegate, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20000F7")]
	public sealed class SerializableAttribute : global::System.Attribute
	{
		// Token: 0x0600088A RID: 2186 RVA: 0x00015E0F File Offset: 0x0001400F
		[global::Cpp2ILInjected.Token(Token = "0x6000932")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C46BB8", Offset = "0x1C46BB8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SerializableAttribute()
		{
			throw null;
		}
	}
}
