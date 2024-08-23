using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x0200033F RID: 831
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20003E7")]
	public sealed class OptionalFieldAttribute : global::System.Attribute
	{
		// Token: 0x06001D4E RID: 7502 RVA: 0x000196F1 File Offset: 0x000178F1
		[global::Cpp2ILInjected.Token(Token = "0x6001F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B59A94", Offset = "0x1B59A94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public OptionalFieldAttribute()
		{
			throw null;
		}

		// Token: 0x170003D6 RID: 982
		// (set) Token: 0x06001D4F RID: 7503 RVA: 0x000196F4 File Offset: 0x000178F4
		[global::Cpp2ILInjected.Token(Token = "0x17000434")]
		public int VersionAdded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B59AA4", Offset = "0x1B59AA4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000CD6 RID: 3286
		[global::Cpp2ILInjected.Token(Token = "0x4000FC8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int versionAdded;
	}
}
