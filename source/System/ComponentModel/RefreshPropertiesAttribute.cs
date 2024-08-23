using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002F3 RID: 755
	[AttributeUsage(AttributeTargets.All)]
	[global::Cpp2ILInjected.Token(Token = "0x2000404")]
	public sealed class RefreshPropertiesAttribute : Attribute
	{
		// Token: 0x06001913 RID: 6419 RVA: 0x000074C3 File Offset: 0x000056C3
		[global::Cpp2ILInjected.Token(Token = "0x6001BEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A8FC", Offset = "0x1E8A8FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public RefreshPropertiesAttribute(RefreshProperties refresh)
		{
			throw null;
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x000074C6 File Offset: 0x000056C6
		[global::Cpp2ILInjected.Token(Token = "0x1700063A")]
		public RefreshProperties RefreshProperties
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001BEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8A924", Offset = "0x1E8A924", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000074C9 File Offset: 0x000056C9
		[global::Cpp2ILInjected.Token(Token = "0x6001BED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A92C", Offset = "0x1E8A92C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000074CC File Offset: 0x000056CC
		[global::Cpp2ILInjected.Token(Token = "0x6001BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A99C", Offset = "0x1E8A99C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x000074CF File Offset: 0x000056CF
		[global::Cpp2ILInjected.Token(Token = "0x6001BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8A9A4", Offset = "0x1E8A9A4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool IsDefaultAttribute()
		{
			throw null;
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x000074D2 File Offset: 0x000056D2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8AA0C", Offset = "0x1E8AA0C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RefreshPropertiesAttribute()
		{
			throw null;
		}

		// Token: 0x04000F43 RID: 3907
		[global::Cpp2ILInjected.Token(Token = "0x4001383")]
		public static readonly RefreshPropertiesAttribute All;

		// Token: 0x04000F44 RID: 3908
		[global::Cpp2ILInjected.Token(Token = "0x4001384")]
		public static readonly RefreshPropertiesAttribute Repaint;

		// Token: 0x04000F45 RID: 3909
		[global::Cpp2ILInjected.Token(Token = "0x4001385")]
		public static readonly RefreshPropertiesAttribute Default;

		// Token: 0x04000F46 RID: 3910
		[global::Cpp2ILInjected.Token(Token = "0x4001386")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RefreshProperties refresh;
	}
}
