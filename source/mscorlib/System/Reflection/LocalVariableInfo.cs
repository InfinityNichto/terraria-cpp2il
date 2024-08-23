using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000444 RID: 1092
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000505")]
	[StructLayout(0)]
	public class LocalVariableInfo
	{
		// Token: 0x060022C6 RID: 8902 RVA: 0x0001A5E2 File Offset: 0x000187E2
		[global::Cpp2ILInjected.Token(Token = "0x6002562")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BADC", Offset = "0x1B8BADC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected LocalVariableInfo()
		{
			throw null;
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x0001A5E5 File Offset: 0x000187E5
		[global::Cpp2ILInjected.Token(Token = "0x6002563")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8BAE4", Offset = "0x1B8BAE4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040011AD RID: 4525
		[global::Cpp2ILInjected.Token(Token = "0x40014CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.Type type;

		// Token: 0x040011AE RID: 4526
		[global::Cpp2ILInjected.Token(Token = "0x40014CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal bool is_pinned;

		// Token: 0x040011AF RID: 4527
		[global::Cpp2ILInjected.Token(Token = "0x40014CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		internal ushort position;
	}
}
