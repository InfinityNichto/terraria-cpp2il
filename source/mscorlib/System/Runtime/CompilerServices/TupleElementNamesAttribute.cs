using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003D0 RID: 976
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Parameter | global::System.AttributeTargets.ReturnValue)]
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000480")]
	public sealed class TupleElementNamesAttribute : global::System.Attribute
	{
		// Token: 0x06001FD3 RID: 8147 RVA: 0x00019E1A File Offset: 0x0001801A
		[global::Cpp2ILInjected.Token(Token = "0x600222A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B738A0", Offset = "0x1B738A0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TupleElementNamesAttribute(string[] transformNames)
		{
			throw null;
		}

		// Token: 0x04000FBC RID: 4028
		[global::Cpp2ILInjected.Token(Token = "0x40012B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string[] _transformNames;
	}
}
