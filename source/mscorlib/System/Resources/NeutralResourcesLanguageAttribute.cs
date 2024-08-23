using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003EE RID: 1006
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004A8")]
	public sealed class NeutralResourcesLanguageAttribute : global::System.Attribute
	{
		// Token: 0x06002050 RID: 8272 RVA: 0x00019F7F File Offset: 0x0001817F
		[global::Cpp2ILInjected.Token(Token = "0x60022C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75C60", Offset = "0x1B75C60", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public NeutralResourcesLanguageAttribute(string cultureName)
		{
			throw null;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x00019F82 File Offset: 0x00018182
		[global::Cpp2ILInjected.Token(Token = "0x1700047F")]
		public string CultureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60022CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75CD8", Offset = "0x1B75CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x00019F85 File Offset: 0x00018185
		[global::Cpp2ILInjected.Token(Token = "0x17000480")]
		public UltimateResourceFallbackLocation Location
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60022CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B75CE0", Offset = "0x1B75CE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000FE7 RID: 4071
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <CultureName>k__BackingField;

		// Token: 0x04000FE8 RID: 4072
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly UltimateResourceFallbackLocation <Location>k__BackingField;
	}
}
