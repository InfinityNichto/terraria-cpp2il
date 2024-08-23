using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000410 RID: 1040
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface)]
	[global::Cpp2ILInjected.Token(Token = "0x20004CE")]
	public sealed class DefaultMemberAttribute : global::System.Attribute
	{
		// Token: 0x060020E6 RID: 8422 RVA: 0x0001A129 File Offset: 0x00018329
		[global::Cpp2ILInjected.Token(Token = "0x600237E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80A74", Offset = "0x1B80A74", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultMemberAttribute(string memberName)
		{
			throw null;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060020E7 RID: 8423 RVA: 0x0001A12C File Offset: 0x0001832C
		[global::Cpp2ILInjected.Token(Token = "0x1700049A")]
		public string MemberName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600237F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B80A9C", Offset = "0x1B80A9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400106D RID: 4205
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4001387")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <MemberName>k__BackingField;
	}
}
