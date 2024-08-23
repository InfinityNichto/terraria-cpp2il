using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A1 RID: 929
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200044B")]
	public sealed class ComCompatibleVersionAttribute : global::System.Attribute
	{
		// Token: 0x06001F38 RID: 7992 RVA: 0x00019CA0 File Offset: 0x00017EA0
		[global::Cpp2ILInjected.Token(Token = "0x6002179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70464", Offset = "0x1B70464", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		{
			throw null;
		}

		// Token: 0x04000F7C RID: 3964
		[global::Cpp2ILInjected.Token(Token = "0x4001271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int _major;

		// Token: 0x04000F7D RID: 3965
		[global::Cpp2ILInjected.Token(Token = "0x4001272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int _minor;

		// Token: 0x04000F7E RID: 3966
		[global::Cpp2ILInjected.Token(Token = "0x4001273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int _build;

		// Token: 0x04000F7F RID: 3967
		[global::Cpp2ILInjected.Token(Token = "0x4001274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal int _revision;
	}
}
