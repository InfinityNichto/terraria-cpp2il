using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003F2 RID: 1010
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004AD")]
	public sealed class SatelliteContractVersionAttribute : global::System.Attribute
	{
		// Token: 0x06002062 RID: 8290 RVA: 0x00019FB5 File Offset: 0x000181B5
		[global::Cpp2ILInjected.Token(Token = "0x60022E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B778E8", Offset = "0x1B778E8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public SatelliteContractVersionAttribute(string version)
		{
			throw null;
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x00019FB8 File Offset: 0x000181B8
		[global::Cpp2ILInjected.Token(Token = "0x17000483")]
		public string Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60022E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B7795C", Offset = "0x1B7795C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04001007 RID: 4103
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400131C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Version>k__BackingField;
	}
}
