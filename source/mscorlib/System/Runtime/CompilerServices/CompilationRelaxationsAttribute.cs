using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003E2 RID: 994
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Module | global::System.AttributeTargets.Class | global::System.AttributeTargets.Method)]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200049A")]
	[global::System.Serializable]
	public class CompilationRelaxationsAttribute : global::System.Attribute
	{
		// Token: 0x06002017 RID: 8215 RVA: 0x00019EE6 File Offset: 0x000180E6
		[global::Cpp2ILInjected.Token(Token = "0x6002287")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B758AC", Offset = "0x1B758AC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public CompilationRelaxationsAttribute(int relaxations)
		{
			throw null;
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00019EE9 File Offset: 0x000180E9
		[global::Cpp2ILInjected.Token(Token = "0x6002288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B758D4", Offset = "0x1B758D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
		{
			throw null;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x00019EEC File Offset: 0x000180EC
		[global::Cpp2ILInjected.Token(Token = "0x1700047A")]
		public int CompilationRelaxations
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002289")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B758FC", Offset = "0x1B758FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000FD9 RID: 4057
		[global::Cpp2ILInjected.Token(Token = "0x40012E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_relaxations;
	}
}
