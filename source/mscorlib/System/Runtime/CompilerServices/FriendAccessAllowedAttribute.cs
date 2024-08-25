using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	[FriendAccessAllowed]
	[global::Cpp2ILInjected.Token(Token = "0x200049C")]
	internal sealed class FriendAccessAllowedAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x600228C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75940", Offset = "0x1B75940", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FriendAccessAllowedAttribute()
		{
			throw null;
		}
	}
}
