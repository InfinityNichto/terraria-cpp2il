using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003CE RID: 974
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200047E")]
	[global::System.Serializable]
	public class StateMachineAttribute : global::System.Attribute
	{
		// Token: 0x06001FD0 RID: 8144 RVA: 0x00019E11 File Offset: 0x00018011
		[global::Cpp2ILInjected.Token(Token = "0x6002227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72EFC", Offset = "0x1B72EFC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public StateMachineAttribute(global::System.Type stateMachineType)
		{
			throw null;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00019E14 File Offset: 0x00018014
		[global::Cpp2ILInjected.Token(Token = "0x1700046F")]
		public global::System.Type StateMachineType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6002228")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B73890", Offset = "0x1B73890", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000FBB RID: 4027
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type <StateMachineType>k__BackingField;
	}
}
