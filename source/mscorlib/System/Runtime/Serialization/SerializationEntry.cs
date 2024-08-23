using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000323 RID: 803
	[global::Cpp2ILInjected.Token(Token = "0x20003C9")]
	public readonly struct SerializationEntry
	{
		// Token: 0x06001C92 RID: 7314 RVA: 0x000194DB File Offset: 0x000176DB
		[global::Cpp2ILInjected.Token(Token = "0x6001ECB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B50AB4", Offset = "0x1B50AB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal SerializationEntry(string entryName, object entryValue, global::System.Type entryType)
		{
			throw null;
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001C93 RID: 7315 RVA: 0x000194DE File Offset: 0x000176DE
		[global::Cpp2ILInjected.Token(Token = "0x1700040A")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50AC0", Offset = "0x1B50AC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001C94 RID: 7316 RVA: 0x000194E1 File Offset: 0x000176E1
		[global::Cpp2ILInjected.Token(Token = "0x1700040B")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001ECD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B50AC8", Offset = "0x1B50AC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000C87 RID: 3207
		[global::Cpp2ILInjected.Token(Token = "0x4000F76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _name;

		// Token: 0x04000C88 RID: 3208
		[global::Cpp2ILInjected.Token(Token = "0x4000F77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly object _value;

		// Token: 0x04000C89 RID: 3209
		[global::Cpp2ILInjected.Token(Token = "0x4000F78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Type _type;
	}
}
