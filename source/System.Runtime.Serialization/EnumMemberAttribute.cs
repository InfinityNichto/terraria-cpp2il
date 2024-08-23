using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000004 RID: 4
	[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public sealed class EnumMemberAttribute : Attribute
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D5C420", Offset = "0x1D5C420", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000006 RID: 6
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string value;
	}
}
