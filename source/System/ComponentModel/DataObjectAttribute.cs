using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200026B RID: 619
	[AttributeUsage(AttributeTargets.Class)]
	[global::Cpp2ILInjected.Token(Token = "0x2000361")]
	public sealed class DataObjectAttribute : Attribute
	{
		// Token: 0x0600144B RID: 5195 RVA: 0x00006812 File Offset: 0x00004A12
		[global::Cpp2ILInjected.Token(Token = "0x6001692")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E477A8", Offset = "0x1E477A8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectAttribute()
		{
			throw null;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00006815 File Offset: 0x00004A15
		[global::Cpp2ILInjected.Token(Token = "0x6001693")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E477C8", Offset = "0x1E477C8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DataObjectAttribute(bool isDataObject)
		{
			throw null;
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00006818 File Offset: 0x00004A18
		[global::Cpp2ILInjected.Token(Token = "0x17000521")]
		public bool IsDataObject
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001694")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E477F0", Offset = "0x1E477F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0000681B File Offset: 0x00004A1B
		[global::Cpp2ILInjected.Token(Token = "0x6001695")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E477F8", Offset = "0x1E477F8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0000681E File Offset: 0x00004A1E
		[global::Cpp2ILInjected.Token(Token = "0x6001696")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E47884", Offset = "0x1E47884", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00006821 File Offset: 0x00004A21
		[global::Cpp2ILInjected.Token(Token = "0x6001697")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E478A4", Offset = "0x1E478A4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00006824 File Offset: 0x00004A24
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001698")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4790C", Offset = "0x1E4790C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DataObjectAttribute()
		{
			throw null;
		}

		// Token: 0x04000DE3 RID: 3555
		[global::Cpp2ILInjected.Token(Token = "0x40011E8")]
		public static readonly DataObjectAttribute DataObject;

		// Token: 0x04000DE4 RID: 3556
		[global::Cpp2ILInjected.Token(Token = "0x40011E9")]
		public static readonly DataObjectAttribute NonDataObject;

		// Token: 0x04000DE5 RID: 3557
		[global::Cpp2ILInjected.Token(Token = "0x40011EA")]
		public static readonly DataObjectAttribute Default;

		// Token: 0x04000DE6 RID: 3558
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40011EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly bool <IsDataObject>k__BackingField;
	}
}
