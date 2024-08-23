using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200026D RID: 621
	[AttributeUsage(AttributeTargets.Method)]
	[global::Cpp2ILInjected.Token(Token = "0x2000363")]
	public sealed class DataObjectMethodAttribute : Attribute
	{
		// Token: 0x0600145C RID: 5212 RVA: 0x00006845 File Offset: 0x00004A45
		[global::Cpp2ILInjected.Token(Token = "0x60016A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47B9C", Offset = "0x1E47B9C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectMethodAttribute(DataObjectMethodType methodType)
		{
			throw null;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00006848 File Offset: 0x00004A48
		[global::Cpp2ILInjected.Token(Token = "0x60016A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47BC8", Offset = "0x1E47BC8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectMethodAttribute(DataObjectMethodType methodType, bool isDefault)
		{
			throw null;
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x0600145E RID: 5214 RVA: 0x0000684B File Offset: 0x00004A4B
		[global::Cpp2ILInjected.Token(Token = "0x17000526")]
		public bool IsDefault
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47BF8", Offset = "0x1E47BF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x0000684E File Offset: 0x00004A4E
		[global::Cpp2ILInjected.Token(Token = "0x17000527")]
		public DataObjectMethodType MethodType
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60016A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E47C00", Offset = "0x1E47C00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00006851 File Offset: 0x00004A51
		[global::Cpp2ILInjected.Token(Token = "0x60016A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47C08", Offset = "0x1E47C08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00006854 File Offset: 0x00004A54
		[global::Cpp2ILInjected.Token(Token = "0x60016A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47CA8", Offset = "0x1E47CA8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00006857 File Offset: 0x00004A57
		[global::Cpp2ILInjected.Token(Token = "0x60016A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47CF0", Offset = "0x1E47CF0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Match(object obj)
		{
			throw null;
		}

		// Token: 0x04000DEB RID: 3563
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsDefault>k__BackingField;

		// Token: 0x04000DEC RID: 3564
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private readonly DataObjectMethodType <MethodType>k__BackingField;
	}
}
