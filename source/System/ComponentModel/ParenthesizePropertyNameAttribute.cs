using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002F1 RID: 753
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000402")]
	public sealed class ParenthesizePropertyNameAttribute : Attribute
	{
		// Token: 0x0600190C RID: 6412 RVA: 0x000074AE File Offset: 0x000056AE
		[global::Cpp2ILInjected.Token(Token = "0x6001BE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A770", Offset = "0x1E8A770", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ParenthesizePropertyNameAttribute()
		{
			throw null;
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000074B1 File Offset: 0x000056B1
		[global::Cpp2ILInjected.Token(Token = "0x6001BE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A78C", Offset = "0x1E8A78C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public ParenthesizePropertyNameAttribute(bool needParenthesis)
		{
			throw null;
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000074B4 File Offset: 0x000056B4
		[global::Cpp2ILInjected.Token(Token = "0x17000639")]
		public bool NeedParenthesis
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8A7B4", Offset = "0x1E8A7B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x000074B7 File Offset: 0x000056B7
		[global::Cpp2ILInjected.Token(Token = "0x6001BE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A7BC", Offset = "0x1E8A7BC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x000074BA File Offset: 0x000056BA
		[global::Cpp2ILInjected.Token(Token = "0x6001BE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A82C", Offset = "0x1E8A82C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x000074BD File Offset: 0x000056BD
		[global::Cpp2ILInjected.Token(Token = "0x6001BE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A834", Offset = "0x1E8A834", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000074C0 File Offset: 0x000056C0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A89C", Offset = "0x1E8A89C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ParenthesizePropertyNameAttribute()
		{
			throw null;
		}

		// Token: 0x04000F3D RID: 3901
		[global::Cpp2ILInjected.Token(Token = "0x400137D")]
		public static readonly ParenthesizePropertyNameAttribute Default;

		// Token: 0x04000F3E RID: 3902
		[global::Cpp2ILInjected.Token(Token = "0x400137E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool needParenthesis;
	}
}
