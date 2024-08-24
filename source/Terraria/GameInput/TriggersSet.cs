using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.Graphics.Capture;
using Terraria.UI;

namespace Terraria.GameInput
{
	// Token: 0x020004B9 RID: 1209
	[global::Cpp2ILInjected.Token(Token = "0x20006D1")]
	public class TriggersSet
	{
		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x0002B649 File Offset: 0x00029849
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x0002B64C File Offset: 0x0002984C
		[global::Cpp2ILInjected.Token(Token = "0x17000716")]
		public bool MouseLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A04")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470854", Offset = "0x1470854", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIColoredSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVerticalSlider), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A05")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470860", Offset = "0x1470860", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x0002B64F File Offset: 0x0002984F
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x0002B652 File Offset: 0x00029852
		[global::Cpp2ILInjected.Token(Token = "0x17000717")]
		public bool MouseRight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A06")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470870", Offset = "0x1470870", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_ManageRightClickFeatures_ShieldRaise", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A07")]
			[global::Cpp2ILInjected.Address(RVA = "0x147087C", Offset = "0x147087C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x0002B655 File Offset: 0x00029855
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x0002B658 File Offset: 0x00029858
		[global::Cpp2ILInjected.Token(Token = "0x17000718")]
		public bool Up
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A08")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E7C0", Offset = "0x146E7C0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A09")]
			[global::Cpp2ILInjected.Address(RVA = "0x147088C", Offset = "0x147088C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x0002B65B File Offset: 0x0002985B
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x0002B65E File Offset: 0x0002985E
		[global::Cpp2ILInjected.Token(Token = "0x17000719")]
		public bool Down
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E7CC", Offset = "0x146E7CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestHighFPSIssues), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A0B")]
			[global::Cpp2ILInjected.Address(RVA = "0x147089C", Offset = "0x147089C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x0002B661 File Offset: 0x00029861
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x0002B664 File Offset: 0x00029864
		[global::Cpp2ILInjected.Token(Token = "0x1700071A")]
		public bool Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A0C")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E7D8", Offset = "0x146E7D8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A0D")]
			[global::Cpp2ILInjected.Address(RVA = "0x14708AC", Offset = "0x14708AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x0002B667 File Offset: 0x00029867
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x0002B66A File Offset: 0x0002986A
		[global::Cpp2ILInjected.Token(Token = "0x1700071B")]
		public bool Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A0E")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E7E4", Offset = "0x146E7E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A0F")]
			[global::Cpp2ILInjected.Address(RVA = "0x14708BC", Offset = "0x14708BC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060034A2 RID: 13474 RVA: 0x0002B66D File Offset: 0x0002986D
		// (set) Token: 0x060034A3 RID: 13475 RVA: 0x0002B670 File Offset: 0x00029870
		[global::Cpp2ILInjected.Token(Token = "0x1700071C")]
		public bool Jump
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A10")]
			[global::Cpp2ILInjected.Address(RVA = "0x14708CC", Offset = "0x14708CC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A11")]
			[global::Cpp2ILInjected.Address(RVA = "0x14708D8", Offset = "0x14708D8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060034A4 RID: 13476 RVA: 0x0002B673 File Offset: 0x00029873
		// (set) Token: 0x060034A5 RID: 13477 RVA: 0x0002B676 File Offset: 0x00029876
		[global::Cpp2ILInjected.Token(Token = "0x1700071D")]
		public bool Throw
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A12")]
			[global::Cpp2ILInjected.Address(RVA = "0x14708E8", Offset = "0x14708E8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A13")]
			[global::Cpp2ILInjected.Address(RVA = "0x14708F4", Offset = "0x14708F4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060034A6 RID: 13478 RVA: 0x0002B679 File Offset: 0x00029879
		// (set) Token: 0x060034A7 RID: 13479 RVA: 0x0002B67C File Offset: 0x0002987C
		[global::Cpp2ILInjected.Token(Token = "0x1700071E")]
		public bool Inventory
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A14")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470904", Offset = "0x1470904", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470910", Offset = "0x1470910", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060034A8 RID: 13480 RVA: 0x0002B67F File Offset: 0x0002987F
		// (set) Token: 0x060034A9 RID: 13481 RVA: 0x0002B682 File Offset: 0x00029882
		[global::Cpp2ILInjected.Token(Token = "0x1700071F")]
		public bool Grapple
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470920", Offset = "0x1470920", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A17")]
			[global::Cpp2ILInjected.Address(RVA = "0x147092C", Offset = "0x147092C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "OpenChest", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileEntity), Member = "SetInteractionAnchor", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060034AA RID: 13482 RVA: 0x0002B685 File Offset: 0x00029885
		// (set) Token: 0x060034AB RID: 13483 RVA: 0x0002B688 File Offset: 0x00029888
		[global::Cpp2ILInjected.Token(Token = "0x17000720")]
		public bool SmartSelect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A18")]
			[global::Cpp2ILInjected.Address(RVA = "0x147093C", Offset = "0x147093C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470948", Offset = "0x1470948", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060034AC RID: 13484 RVA: 0x0002B68B File Offset: 0x0002988B
		// (set) Token: 0x060034AD RID: 13485 RVA: 0x0002B68E File Offset: 0x0002988E
		[global::Cpp2ILInjected.Token(Token = "0x17000721")]
		public bool SmartCursor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470958", Offset = "0x1470958", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470964", Offset = "0x1470964", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060034AE RID: 13486 RVA: 0x0002B691 File Offset: 0x00029891
		// (set) Token: 0x060034AF RID: 13487 RVA: 0x0002B694 File Offset: 0x00029894
		[global::Cpp2ILInjected.Token(Token = "0x17000722")]
		public bool QuickMount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470974", Offset = "0x1470974", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A1D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470980", Offset = "0x1470980", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060034B0 RID: 13488 RVA: 0x0002B697 File Offset: 0x00029897
		// (set) Token: 0x060034B1 RID: 13489 RVA: 0x0002B69A File Offset: 0x0002989A
		[global::Cpp2ILInjected.Token(Token = "0x17000723")]
		public bool QuickHeal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A1E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470990", Offset = "0x1470990", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A1F")]
			[global::Cpp2ILInjected.Address(RVA = "0x147099C", Offset = "0x147099C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x0002B69D File Offset: 0x0002989D
		// (set) Token: 0x060034B3 RID: 13491 RVA: 0x0002B6A0 File Offset: 0x000298A0
		[global::Cpp2ILInjected.Token(Token = "0x17000724")]
		public bool QuickMana
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A20")]
			[global::Cpp2ILInjected.Address(RVA = "0x14709AC", Offset = "0x14709AC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A21")]
			[global::Cpp2ILInjected.Address(RVA = "0x14709B8", Offset = "0x14709B8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x0002B6A3 File Offset: 0x000298A3
		// (set) Token: 0x060034B5 RID: 13493 RVA: 0x0002B6A6 File Offset: 0x000298A6
		[global::Cpp2ILInjected.Token(Token = "0x17000725")]
		public bool QuickBuff
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A22")]
			[global::Cpp2ILInjected.Address(RVA = "0x14709C8", Offset = "0x14709C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A23")]
			[global::Cpp2ILInjected.Address(RVA = "0x14709D4", Offset = "0x14709D4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060034B6 RID: 13494 RVA: 0x0002B6A9 File Offset: 0x000298A9
		// (set) Token: 0x060034B7 RID: 13495 RVA: 0x0002B6AC File Offset: 0x000298AC
		[global::Cpp2ILInjected.Token(Token = "0x17000726")]
		public bool Loadout1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A24")]
			[global::Cpp2ILInjected.Address(RVA = "0x14709E4", Offset = "0x14709E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A25")]
			[global::Cpp2ILInjected.Address(RVA = "0x14709F0", Offset = "0x14709F0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060034B8 RID: 13496 RVA: 0x0002B6AF File Offset: 0x000298AF
		// (set) Token: 0x060034B9 RID: 13497 RVA: 0x0002B6B2 File Offset: 0x000298B2
		[global::Cpp2ILInjected.Token(Token = "0x17000727")]
		public bool Loadout2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A26")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A00", Offset = "0x1470A00", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A0C", Offset = "0x1470A0C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060034BA RID: 13498 RVA: 0x0002B6B5 File Offset: 0x000298B5
		// (set) Token: 0x060034BB RID: 13499 RVA: 0x0002B6B8 File Offset: 0x000298B8
		[global::Cpp2ILInjected.Token(Token = "0x17000728")]
		public bool Loadout3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A28")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A1C", Offset = "0x1470A1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A29")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A28", Offset = "0x1470A28", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060034BC RID: 13500 RVA: 0x0002B6BB File Offset: 0x000298BB
		// (set) Token: 0x060034BD RID: 13501 RVA: 0x0002B6BE File Offset: 0x000298BE
		[global::Cpp2ILInjected.Token(Token = "0x17000729")]
		public bool MapZoomIn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A2A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A38", Offset = "0x1470A38", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A44", Offset = "0x1470A44", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060034BE RID: 13502 RVA: 0x0002B6C1 File Offset: 0x000298C1
		// (set) Token: 0x060034BF RID: 13503 RVA: 0x0002B6C4 File Offset: 0x000298C4
		[global::Cpp2ILInjected.Token(Token = "0x1700072A")]
		public bool MapZoomOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A54", Offset = "0x1470A54", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A60", Offset = "0x1470A60", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060034C0 RID: 13504 RVA: 0x0002B6C7 File Offset: 0x000298C7
		// (set) Token: 0x060034C1 RID: 13505 RVA: 0x0002B6CA File Offset: 0x000298CA
		[global::Cpp2ILInjected.Token(Token = "0x1700072B")]
		public bool MapAlphaUp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A70", Offset = "0x1470A70", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A7C", Offset = "0x1470A7C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060034C2 RID: 13506 RVA: 0x0002B6CD File Offset: 0x000298CD
		// (set) Token: 0x060034C3 RID: 13507 RVA: 0x0002B6D0 File Offset: 0x000298D0
		[global::Cpp2ILInjected.Token(Token = "0x1700072C")]
		public bool MapAlphaDown
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A8C", Offset = "0x1470A8C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470A98", Offset = "0x1470A98", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060034C4 RID: 13508 RVA: 0x0002B6D3 File Offset: 0x000298D3
		// (set) Token: 0x060034C5 RID: 13509 RVA: 0x0002B6D6 File Offset: 0x000298D6
		[global::Cpp2ILInjected.Token(Token = "0x1700072D")]
		public bool MapFull
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AA8", Offset = "0x1470AA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AB4", Offset = "0x1470AB4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060034C6 RID: 13510 RVA: 0x0002B6D9 File Offset: 0x000298D9
		// (set) Token: 0x060034C7 RID: 13511 RVA: 0x0002B6DC File Offset: 0x000298DC
		[global::Cpp2ILInjected.Token(Token = "0x1700072E")]
		public bool MapStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AC4", Offset = "0x1470AC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A35")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AD0", Offset = "0x1470AD0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060034C8 RID: 13512 RVA: 0x0002B6DF File Offset: 0x000298DF
		// (set) Token: 0x060034C9 RID: 13513 RVA: 0x0002B6E2 File Offset: 0x000298E2
		[global::Cpp2ILInjected.Token(Token = "0x1700072F")]
		public bool Hotbar1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A36")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AE0", Offset = "0x1470AE0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A37")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AEC", Offset = "0x1470AEC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x0002B6E5 File Offset: 0x000298E5
		// (set) Token: 0x060034CB RID: 13515 RVA: 0x0002B6E8 File Offset: 0x000298E8
		[global::Cpp2ILInjected.Token(Token = "0x17000730")]
		public bool Hotbar2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A38")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470AFC", Offset = "0x1470AFC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B08", Offset = "0x1470B08", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x0002B6EB File Offset: 0x000298EB
		// (set) Token: 0x060034CD RID: 13517 RVA: 0x0002B6EE File Offset: 0x000298EE
		[global::Cpp2ILInjected.Token(Token = "0x17000731")]
		public bool Hotbar3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A3A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B18", Offset = "0x1470B18", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B24", Offset = "0x1470B24", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060034CE RID: 13518 RVA: 0x0002B6F1 File Offset: 0x000298F1
		// (set) Token: 0x060034CF RID: 13519 RVA: 0x0002B6F4 File Offset: 0x000298F4
		[global::Cpp2ILInjected.Token(Token = "0x17000732")]
		public bool Hotbar4
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B34", Offset = "0x1470B34", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A3D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B40", Offset = "0x1470B40", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060034D0 RID: 13520 RVA: 0x0002B6F7 File Offset: 0x000298F7
		// (set) Token: 0x060034D1 RID: 13521 RVA: 0x0002B6FA File Offset: 0x000298FA
		[global::Cpp2ILInjected.Token(Token = "0x17000733")]
		public bool Hotbar5
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B50", Offset = "0x1470B50", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A3F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B5C", Offset = "0x1470B5C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x0002B6FD File Offset: 0x000298FD
		// (set) Token: 0x060034D3 RID: 13523 RVA: 0x0002B700 File Offset: 0x00029900
		[global::Cpp2ILInjected.Token(Token = "0x17000734")]
		public bool Hotbar6
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B6C", Offset = "0x1470B6C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B78", Offset = "0x1470B78", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x0002B703 File Offset: 0x00029903
		// (set) Token: 0x060034D5 RID: 13525 RVA: 0x0002B706 File Offset: 0x00029906
		[global::Cpp2ILInjected.Token(Token = "0x17000735")]
		public bool Hotbar7
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B88", Offset = "0x1470B88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470B94", Offset = "0x1470B94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060034D6 RID: 13526 RVA: 0x0002B709 File Offset: 0x00029909
		// (set) Token: 0x060034D7 RID: 13527 RVA: 0x0002B70C File Offset: 0x0002990C
		[global::Cpp2ILInjected.Token(Token = "0x17000736")]
		public bool Hotbar8
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BA4", Offset = "0x1470BA4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BB0", Offset = "0x1470BB0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060034D8 RID: 13528 RVA: 0x0002B70F File Offset: 0x0002990F
		// (set) Token: 0x060034D9 RID: 13529 RVA: 0x0002B712 File Offset: 0x00029912
		[global::Cpp2ILInjected.Token(Token = "0x17000737")]
		public bool Hotbar9
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BC0", Offset = "0x1470BC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A47")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BCC", Offset = "0x1470BCC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060034DA RID: 13530 RVA: 0x0002B715 File Offset: 0x00029915
		// (set) Token: 0x060034DB RID: 13531 RVA: 0x0002B718 File Offset: 0x00029918
		[global::Cpp2ILInjected.Token(Token = "0x17000738")]
		public bool Hotbar10
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BDC", Offset = "0x1470BDC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BE8", Offset = "0x1470BE8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060034DC RID: 13532 RVA: 0x0002B71B File Offset: 0x0002991B
		// (set) Token: 0x060034DD RID: 13533 RVA: 0x0002B71E File Offset: 0x0002991E
		[global::Cpp2ILInjected.Token(Token = "0x17000739")]
		public bool HotbarMinus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E7FC", Offset = "0x146E7FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HandleHotbar", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "PostInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470BF8", Offset = "0x1470BF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060034DE RID: 13534 RVA: 0x0002B721 File Offset: 0x00029921
		// (set) Token: 0x060034DF RID: 13535 RVA: 0x0002B724 File Offset: 0x00029924
		[global::Cpp2ILInjected.Token(Token = "0x1700073A")]
		public bool HotbarPlus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E7F0", Offset = "0x146E7F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HandleHotbar", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "PostInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C08", Offset = "0x1470C08", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060034E0 RID: 13536 RVA: 0x0002B727 File Offset: 0x00029927
		// (set) Token: 0x060034E1 RID: 13537 RVA: 0x0002B72A File Offset: 0x0002992A
		[global::Cpp2ILInjected.Token(Token = "0x1700073B")]
		public bool DpadRadial1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C18", Offset = "0x1470C18", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "ChangeBinding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C24", Offset = "0x1470C24", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060034E2 RID: 13538 RVA: 0x0002B72D File Offset: 0x0002992D
		// (set) Token: 0x060034E3 RID: 13539 RVA: 0x0002B730 File Offset: 0x00029930
		[global::Cpp2ILInjected.Token(Token = "0x1700073C")]
		public bool DpadRadial2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C34", Offset = "0x1470C34", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "ChangeBinding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C40", Offset = "0x1470C40", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060034E4 RID: 13540 RVA: 0x0002B733 File Offset: 0x00029933
		// (set) Token: 0x060034E5 RID: 13541 RVA: 0x0002B736 File Offset: 0x00029936
		[global::Cpp2ILInjected.Token(Token = "0x1700073D")]
		public bool DpadRadial3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C50", Offset = "0x1470C50", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "ChangeBinding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C5C", Offset = "0x1470C5C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060034E6 RID: 13542 RVA: 0x0002B739 File Offset: 0x00029939
		// (set) Token: 0x060034E7 RID: 13543 RVA: 0x0002B73C File Offset: 0x0002993C
		[global::Cpp2ILInjected.Token(Token = "0x1700073E")]
		public bool DpadRadial4
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C6C", Offset = "0x1470C6C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "ChangeBinding", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C78", Offset = "0x1470C78", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060034E8 RID: 13544 RVA: 0x0002B73F File Offset: 0x0002993F
		// (set) Token: 0x060034E9 RID: 13545 RVA: 0x0002B742 File Offset: 0x00029942
		[global::Cpp2ILInjected.Token(Token = "0x1700073F")]
		public bool RadialHotbar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C88", Offset = "0x1470C88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawRadialCircular", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Vector2),
				typeof(Player.SelectionRadial),
				typeof(Item[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470C94", Offset = "0x1470C94", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "PostInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x0002B745 File Offset: 0x00029945
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x0002B748 File Offset: 0x00029948
		[global::Cpp2ILInjected.Token(Token = "0x17000740")]
		public bool RadialQuickbar
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CA4", Offset = "0x1470CA4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player.SelectionRadial), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "DrawRadialQuicks", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CB0", Offset = "0x1470CB0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "PostInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x0002B74B File Offset: 0x0002994B
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x0002B74E File Offset: 0x0002994E
		[global::Cpp2ILInjected.Token(Token = "0x17000741")]
		public bool DpadMouseSnap1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CC0", Offset = "0x1470CC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CCC", Offset = "0x1470CCC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x0002B751 File Offset: 0x00029951
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x0002B754 File Offset: 0x00029954
		[global::Cpp2ILInjected.Token(Token = "0x17000742")]
		public bool DpadMouseSnap2
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CDC", Offset = "0x1470CDC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CE8", Offset = "0x1470CE8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x0002B757 File Offset: 0x00029957
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x0002B75A File Offset: 0x0002995A
		[global::Cpp2ILInjected.Token(Token = "0x17000743")]
		public bool DpadMouseSnap3
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470CF8", Offset = "0x1470CF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D04", Offset = "0x1470D04", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x0002B75D File Offset: 0x0002995D
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x0002B760 File Offset: 0x00029960
		[global::Cpp2ILInjected.Token(Token = "0x17000744")]
		public bool DpadMouseSnap4
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D14", Offset = "0x1470D14", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D20", Offset = "0x1470D20", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x0002B763 File Offset: 0x00029963
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x0002B766 File Offset: 0x00029966
		[global::Cpp2ILInjected.Token(Token = "0x17000745")]
		public bool MenuUp
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A62")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E808", Offset = "0x146E808", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D30", Offset = "0x1470D30", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0002B769 File Offset: 0x00029969
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x0002B76C File Offset: 0x0002996C
		[global::Cpp2ILInjected.Token(Token = "0x17000746")]
		public bool MenuDown
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A64")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E814", Offset = "0x146E814", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D40", Offset = "0x1470D40", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x0002B76F File Offset: 0x0002996F
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x0002B772 File Offset: 0x00029972
		[global::Cpp2ILInjected.Token(Token = "0x17000747")]
		public bool MenuLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A66")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E820", Offset = "0x146E820", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A67")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D50", Offset = "0x1470D50", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x0002B775 File Offset: 0x00029975
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x0002B778 File Offset: 0x00029978
		[global::Cpp2ILInjected.Token(Token = "0x17000748")]
		public bool MenuRight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A68")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E82C", Offset = "0x146E82C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A69")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D60", Offset = "0x1470D60", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x0002B77B File Offset: 0x0002997B
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x0002B77E File Offset: 0x0002997E
		[global::Cpp2ILInjected.Token(Token = "0x17000749")]
		public bool LockOn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A6A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D70", Offset = "0x1470D70", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A6B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D7C", Offset = "0x1470D7C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x0002B781 File Offset: 0x00029981
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x0002B784 File Offset: 0x00029984
		[global::Cpp2ILInjected.Token(Token = "0x1700074A")]
		public bool ViewZoomIn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A6C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D8C", Offset = "0x1470D8C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateViewZoomKeys", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A6D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470D98", Offset = "0x1470D98", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x0002B787 File Offset: 0x00029987
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x0002B78A File Offset: 0x0002998A
		[global::Cpp2ILInjected.Token(Token = "0x1700074B")]
		public bool ViewZoomOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DA8", Offset = "0x1470DA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateViewZoomKeys", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DB4", Offset = "0x1470DB4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x0002B78D File Offset: 0x0002998D
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x0002B790 File Offset: 0x00029990
		[global::Cpp2ILInjected.Token(Token = "0x1700074C")]
		public bool OpenCreativePowersMenu
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A70")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DC4", Offset = "0x1470DC4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A71")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DD0", Offset = "0x1470DD0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x0002B793 File Offset: 0x00029993
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x0002B796 File Offset: 0x00029996
		[global::Cpp2ILInjected.Token(Token = "0x1700074D")]
		public bool ToggleCameraMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A72")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DE0", Offset = "0x1470DE0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003A73")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DEC", Offset = "0x1470DEC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0002B799 File Offset: 0x00029999
		[global::Cpp2ILInjected.Token(Token = "0x6003A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1470688", Offset = "0x1470688", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0002B79C File Offset: 0x0002999C
		[global::Cpp2ILInjected.Token(Token = "0x6003A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x147063C", Offset = "0x147063C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersPack), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Clone(TriggersSet output)
		{
			throw null;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x0002B79F File Offset: 0x0002999F
		[global::Cpp2ILInjected.Token(Token = "0x6003A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x14705D0", Offset = "0x14705D0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetupKeys()
		{
			throw null;
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06003509 RID: 13577 RVA: 0x0002B7A2 File Offset: 0x000299A2
		[global::Cpp2ILInjected.Token(Token = "0x1700074E")]
		public Vector2 DirectionsRaw
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003A77")]
			[global::Cpp2ILInjected.Address(RVA = "0x1470DFC", Offset = "0x1470DFC", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x0002B7A5 File Offset: 0x000299A5
		[global::Cpp2ILInjected.Token(Token = "0x6003A78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1470ED8", Offset = "0x1470ED8", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_Pickaxe_MineSolids", MemberParameters = new object[]
		{
			typeof(Player),
			"Terraria.GameContent.SmartCursorHelper.SmartCursorUsageInfo",
			typeof(List<int>),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ingameOptionsWindow", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editChest", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editSign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerInventory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "UsingDpadMovekeys", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public Vector2 GetNavigatorDirections()
		{
			throw null;
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x0002B7A8 File Offset: 0x000299A8
		[global::Cpp2ILInjected.Token(Token = "0x6003A79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1471170", Offset = "0x1471170", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Ghost", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateDead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_CursorIsBusy", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "QuickBuff", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "TrySwitchingLoadout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void CopyInto(Player p)
		{
			throw null;
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x0002B7AB File Offset: 0x000299AB
		[global::Cpp2ILInjected.Token(Token = "0x6003A7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14713F8", Offset = "0x14713F8", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerInventory", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_LockGamepadTileUseButton", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "ShouldLockTileUsage", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void CopyIntoDuringChat(Player p)
		{
			throw null;
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x0002B7AE File Offset: 0x000299AE
		[global::Cpp2ILInjected.Token(Token = "0x6003A7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1471664", Offset = "0x1471664", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersSet), Member = "CopyIntoDuringChat", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_LockGamepadTileUseButton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool ShouldLockTileUsage()
		{
			throw null;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x0002B7B1 File Offset: 0x000299B1
		[global::Cpp2ILInjected.Token(Token = "0x6003A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14716E0", Offset = "0x14716E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsInputFromGamepad(InputMode mode)
		{
			throw null;
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x0002B7B4 File Offset: 0x000299B4
		[global::Cpp2ILInjected.Token(Token = "0x6003A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14707F4", Offset = "0x14707F4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersPack), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TriggersSet()
		{
			throw null;
		}

		// Token: 0x04006653 RID: 26195
		[global::Cpp2ILInjected.Token(Token = "0x4007A70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool[] KeyStatus;

		// Token: 0x04006654 RID: 26196
		[global::Cpp2ILInjected.Token(Token = "0x4007A71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool UsedMovementKey;

		// Token: 0x04006655 RID: 26197
		[global::Cpp2ILInjected.Token(Token = "0x4007A72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int HotbarScrollCD;

		// Token: 0x04006656 RID: 26198
		[global::Cpp2ILInjected.Token(Token = "0x4007A73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int HotbarHoldTime;
	}
}
