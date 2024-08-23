using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000287 RID: 647
	[global::Cpp2ILInjected.Token(Token = "0x2000348")]
	public struct GamePadTriggers
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x000256FA File Offset: 0x000238FA
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x000256FD File Offset: 0x000238FD
		[global::Cpp2ILInjected.Token(Token = "0x17000252")]
		public float Left
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001583")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A448", Offset = "0xA9A448", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001584")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A450", Offset = "0xA9A450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x00025700 File Offset: 0x00023900
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x00025703 File Offset: 0x00023903
		[global::Cpp2ILInjected.Token(Token = "0x17000253")]
		public float Right
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001585")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A458", Offset = "0xA9A458", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			readonly get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001586")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9A460", Offset = "0xA9A460", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x00025706 File Offset: 0x00023906
		[global::Cpp2ILInjected.Token(Token = "0x6001587")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99278", Offset = "0xA99278", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public GamePadTriggers(float leftTrigger, float rightTrigger)
		{
			throw null;
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x00025709 File Offset: 0x00023909
		[global::Cpp2ILInjected.Token(Token = "0x6001588")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9959C", Offset = "0xA9959C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(GamePadTriggers left, GamePadTriggers right)
		{
			throw null;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x0002570C File Offset: 0x0002390C
		[global::Cpp2ILInjected.Token(Token = "0x6001589")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A468", Offset = "0xA9A468", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(GamePadTriggers left, GamePadTriggers right)
		{
			throw null;
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x0002570F File Offset: 0x0002390F
		[global::Cpp2ILInjected.Token(Token = "0x600158A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9A480", Offset = "0xA9A480", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x00025712 File Offset: 0x00023912
		[global::Cpp2ILInjected.Token(Token = "0x600158B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA998B4", Offset = "0xA998B4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x00025715 File Offset: 0x00023915
		[global::Cpp2ILInjected.Token(Token = "0x600158C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA99E10", Offset = "0xA99E10", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GamePadState), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001D39 RID: 7481
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002313")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float <Left>k__BackingField;

		// Token: 0x04001D3A RID: 7482
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4002314")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float <Right>k__BackingField;
	}
}
