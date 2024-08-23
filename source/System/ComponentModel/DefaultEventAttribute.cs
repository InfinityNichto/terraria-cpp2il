using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000272 RID: 626
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000368")]
	public sealed class DefaultEventAttribute : Attribute
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x00006893 File Offset: 0x00004A93
		[global::Cpp2ILInjected.Token(Token = "0x60016BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48CF4", Offset = "0x1E48CF4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultEventAttribute(string name)
		{
			throw null;
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x00006896 File Offset: 0x00004A96
		[global::Cpp2ILInjected.Token(Token = "0x1700052B")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E48D1C", Offset = "0x1E48D1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x00006899 File Offset: 0x00004A99
		[global::Cpp2ILInjected.Token(Token = "0x60016BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48D24", Offset = "0x1E48D24", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000689C File Offset: 0x00004A9C
		[global::Cpp2ILInjected.Token(Token = "0x60016C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48D98", Offset = "0x1E48D98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x0000689F File Offset: 0x00004A9F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E48DA0", Offset = "0x1E48DA0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static DefaultEventAttribute()
		{
			throw null;
		}

		// Token: 0x04000DF5 RID: 3573
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <Name>k__BackingField;

		// Token: 0x04000DF6 RID: 3574
		[global::Cpp2ILInjected.Token(Token = "0x40011FB")]
		public static readonly DefaultEventAttribute Default;
	}
}
