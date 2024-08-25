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
	[global::Cpp2ILInjected.Token(Token = "0x20006D1")]
	public class TriggersSet
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003A74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1470688", Offset = "0x1470688", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003A75")]
		[global::Cpp2ILInjected.Address(RVA = "0x147063C", Offset = "0x147063C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersPack), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Clone(TriggersSet output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003A76")]
		[global::Cpp2ILInjected.Address(RVA = "0x14705D0", Offset = "0x14705D0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetupKeys()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14716E0", Offset = "0x14716E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsInputFromGamepad(InputMode mode)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4007A70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public bool[] KeyStatus;

		[global::Cpp2ILInjected.Token(Token = "0x4007A71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool UsedMovementKey;

		[global::Cpp2ILInjected.Token(Token = "0x4007A72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int HotbarScrollCD;

		[global::Cpp2ILInjected.Token(Token = "0x4007A73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int HotbarHoldTime;
	}
}
