using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000643 RID: 1603
	[global::Cpp2ILInjected.Token(Token = "0x2000968")]
	public class NPCNetIdBestiaryInfoElement : IBestiaryInfoElement, IBestiaryEntryDisplayIndex
	{
		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06003F04 RID: 16132 RVA: 0x0002D3FB File Offset: 0x0002B5FB
		// (set) Token: 0x06003F05 RID: 16133 RVA: 0x0002D3FE File Offset: 0x0002B5FE
		[global::Cpp2ILInjected.Token(Token = "0x1700082C")]
		public int NetId
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600481C")]
			[global::Cpp2ILInjected.Address(RVA = "0x81EA50", Offset = "0x81EA50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600481D")]
			[global::Cpp2ILInjected.Address(RVA = "0x81EA58", Offset = "0x81EA58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x0002D401 File Offset: 0x0002B601
		[global::Cpp2ILInjected.Token(Token = "0x600481E")]
		[global::Cpp2ILInjected.Address(RVA = "0x819990", Offset = "0x819990", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public NPCNetIdBestiaryInfoElement(int npcNetId)
		{
			throw null;
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x0002D404 File Offset: 0x0002B604
		[global::Cpp2ILInjected.Token(Token = "0x600481F")]
		[global::Cpp2ILInjected.Address(RVA = "0x81EA60", Offset = "0x81EA60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			throw null;
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06003F08 RID: 16136 RVA: 0x0002D407 File Offset: 0x0002B607
		[global::Cpp2ILInjected.Token(Token = "0x1700082D")]
		public int BestiaryDisplayIndex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004820")]
			[global::Cpp2ILInjected.Address(RVA = "0x81EA68", Offset = "0x81EA68", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006C89 RID: 27785
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40083AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <NetId>k__BackingField;
	}
}
