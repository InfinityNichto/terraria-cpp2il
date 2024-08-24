using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Light;

namespace Terraria.GameInput
{
	// Token: 0x020004AF RID: 1199
	[global::Cpp2ILInjected.Token(Token = "0x20006C3")]
	public class LockOnHelper
	{
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x0002B44B File Offset: 0x0002964B
		// (set) Token: 0x060033ED RID: 13293 RVA: 0x0002B44E File Offset: 0x0002964E
		[global::Cpp2ILInjected.Token(Token = "0x170006DE")]
		public static LockOnHelper.LockOnMode UseMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003946")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BF04", Offset = "0x144BF04", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003947")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BF1C", Offset = "0x144BF1C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x0002B451 File Offset: 0x00029651
		// (set) Token: 0x060033EF RID: 13295 RVA: 0x0002B454 File Offset: 0x00029654
		[global::Cpp2ILInjected.Token(Token = "0x170006DF")]
		private static bool _enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003948")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BF38", Offset = "0x144BF38", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003949")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BF50", Offset = "0x144BF50", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x0002B457 File Offset: 0x00029657
		// (set) Token: 0x060033F1 RID: 13297 RVA: 0x0002B45A File Offset: 0x0002965A
		[global::Cpp2ILInjected.Token(Token = "0x170006E0")]
		private static bool _canLockOn
		{
			[global::Cpp2ILInjected.Token(Token = "0x600394A")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BF6C", Offset = "0x144BF6C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600394B")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BF84", Offset = "0x144BF84", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x060033F2 RID: 13298 RVA: 0x0002B45D File Offset: 0x0002965D
		// (set) Token: 0x060033F3 RID: 13299 RVA: 0x0002B460 File Offset: 0x00029660
		[global::Cpp2ILInjected.Token(Token = "0x170006E1")]
		private static List<int> _targets
		{
			[global::Cpp2ILInjected.Token(Token = "0x600394C")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BFA0", Offset = "0x144BFA0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600394D")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BFB8", Offset = "0x144BFB8", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x060033F4 RID: 13300 RVA: 0x0002B463 File Offset: 0x00029663
		// (set) Token: 0x060033F5 RID: 13301 RVA: 0x0002B466 File Offset: 0x00029666
		[global::Cpp2ILInjected.Token(Token = "0x170006E2")]
		private static int _pickedTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x600394E")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BFD4", Offset = "0x144BFD4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600394F")]
			[global::Cpp2ILInjected.Address(RVA = "0x144BFEC", Offset = "0x144BFEC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x0002B469 File Offset: 0x00029669
		// (set) Token: 0x060033F7 RID: 13303 RVA: 0x0002B46C File Offset: 0x0002966C
		[global::Cpp2ILInjected.Token(Token = "0x170006E3")]
		private static int _lifeTimeCounter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003950")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C008", Offset = "0x144C008", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003951")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C020", Offset = "0x144C020", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x0002B46F File Offset: 0x0002966F
		// (set) Token: 0x060033F9 RID: 13305 RVA: 0x0002B472 File Offset: 0x00029672
		[global::Cpp2ILInjected.Token(Token = "0x170006E4")]
		private static int _lifeTimeArrowDisplay
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003952")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C03C", Offset = "0x144C03C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003953")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C054", Offset = "0x144C054", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x060033FA RID: 13306 RVA: 0x0002B475 File Offset: 0x00029675
		// (set) Token: 0x060033FB RID: 13307 RVA: 0x0002B478 File Offset: 0x00029678
		[global::Cpp2ILInjected.Token(Token = "0x170006E5")]
		private static int _threeDSTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003954")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C070", Offset = "0x144C070", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003955")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C088", Offset = "0x144C088", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x0002B47B File Offset: 0x0002967B
		// (set) Token: 0x060033FD RID: 13309 RVA: 0x0002B47E File Offset: 0x0002967E
		[global::Cpp2ILInjected.Token(Token = "0x170006E6")]
		private static int _targetClosestTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003956")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C0A4", Offset = "0x144C0A4", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003957")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C0BC", Offset = "0x144C0BC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x0002B481 File Offset: 0x00029681
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x0002B484 File Offset: 0x00029684
		[global::Cpp2ILInjected.Token(Token = "0x170006E7")]
		public static bool ForceUsability
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003958")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C0D8", Offset = "0x144C0D8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003959")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C0F0", Offset = "0x144C0F0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x0002B487 File Offset: 0x00029687
		// (set) Token: 0x06003401 RID: 13313 RVA: 0x0002B48A File Offset: 0x0002968A
		[global::Cpp2ILInjected.Token(Token = "0x170006E8")]
		public static bool LockOnAvailable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600395A")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C10C", Offset = "0x144C10C", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControlStringNotifications", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600395B")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C124", Offset = "0x144C124", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06003402 RID: 13314 RVA: 0x0002B48D File Offset: 0x0002968D
		// (set) Token: 0x06003403 RID: 13315 RVA: 0x0002B490 File Offset: 0x00029690
		[global::Cpp2ILInjected.Token(Token = "0x170006E9")]
		private static int _lastFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x600395C")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C140", Offset = "0x144C140", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600395D")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C158", Offset = "0x144C158", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06003404 RID: 13316 RVA: 0x0002B493 File Offset: 0x00029693
		// (set) Token: 0x06003405 RID: 13317 RVA: 0x0002B496 File Offset: 0x00029696
		[global::Cpp2ILInjected.Token(Token = "0x170006EA")]
		private static float[,] _drawProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x600395E")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C174", Offset = "0x144C174", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600395F")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C18C", Offset = "0x144C18C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x0002B499 File Offset: 0x00029699
		[global::Cpp2ILInjected.Token(Token = "0x6003960")]
		[global::Cpp2ILInjected.Address(RVA = "0x144C1A8", Offset = "0x144C1A8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CycleUseModes()
		{
			throw null;
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x0002B49C File Offset: 0x0002969C
		[global::Cpp2ILInjected.Token(Token = "0x170006EB")]
		public static NPC AimedTarget
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003961")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C24C", Offset = "0x144C24C", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(NPC),
				typeof(bool),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(NPC),
				typeof(bool),
				typeof(Vector2),
				typeof(LightMap),
				typeof(ref Rectangle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "get_PredictedPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetUP", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06003408 RID: 13320 RVA: 0x0002B49F File Offset: 0x0002969F
		[global::Cpp2ILInjected.Token(Token = "0x170006EC")]
		public static Vector2 PredictedPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003962")]
			[global::Cpp2ILInjected.Address(RVA = "0x144C36C", Offset = "0x144C36C", Length = "0x5B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetUP", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_AimedTarget", ReturnType = typeof(NPC))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetNPCLocation", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(ref int),
				typeof(ref Vector2)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(float),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SafeNormalize", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new object[]
			{
				typeof(double),
				typeof(double)
			}, ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float?), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x0002B4A2 File Offset: 0x000296A2
		[global::Cpp2ILInjected.Token(Token = "0x6003963")]
		[global::Cpp2ILInjected.Address(RVA = "0x144C924", Offset = "0x144C924", Length = "0x5F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "FindMostViableTarget", MemberParameters = new object[]
		{
			typeof(LockOnHelper.LockOnMode),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "HandlePressing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_AimedTarget", ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "ValidTarget", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "CanEnable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_PredictedPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CanHit", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Collision), Member = "CanHitLine", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x0002B4A5 File Offset: 0x000296A5
		[global::Cpp2ILInjected.Token(Token = "0x6003964")]
		[global::Cpp2ILInjected.Address(RVA = "0x144CF1C", Offset = "0x144CF1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool CanUseLockonSystem()
		{
			throw null;
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x0002B4A8 File Offset: 0x000296A8
		[global::Cpp2ILInjected.Token(Token = "0x6003965")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D448", Offset = "0x144D448", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheckWrapped", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_AimedTarget", ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_PredictedPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReverseGravitySupport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetUP()
		{
			throw null;
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x0002B4AB File Offset: 0x000296AB
		[global::Cpp2ILInjected.Token(Token = "0x6003966")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D638", Offset = "0x144D638", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdateInWorld", MemberParameters = new object[] { typeof(Stopwatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheckWrapped", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void SetDOWN()
		{
			throw null;
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x0002B4AE File Offset: 0x000296AE
		[global::Cpp2ILInjected.Token(Token = "0x6003967")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D428", Offset = "0x144D428", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool ShouldLockOn(Player p)
		{
			throw null;
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x0002B4B1 File Offset: 0x000296B1
		[global::Cpp2ILInjected.Token(Token = "0x6003968")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D744", Offset = "0x144D744", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "HandlePressing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Toggle(bool forceOff = false)
		{
			throw null;
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x0002B4B4 File Offset: 0x000296B4
		[global::Cpp2ILInjected.Token(Token = "0x170006ED")]
		public static bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003969")]
			[global::Cpp2ILInjected.Address(RVA = "0x144D7D8", Offset = "0x144D7D8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIQuickActionButton), Member = "Draw", MemberParameters = new object[]
			{
				typeof(QuickActionButton_Layout.QuickActionControl),
				typeof(QuickActionButton_Layout),
				typeof(bool),
				typeof(ref float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsStatusIndicators), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "DrawControlStringNotifications", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06003410 RID: 13328 RVA: 0x0002B4B7 File Offset: 0x000296B7
		[global::Cpp2ILInjected.Token(Token = "0x170006EE")]
		public static Vector2 MouseWorld
		{
			[global::Cpp2ILInjected.Token(Token = "0x600396A")]
			[global::Cpp2ILInjected.Address(RVA = "0x144D830", Offset = "0x144D830", Length = "0x14C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "FindMostViableTarget", MemberParameters = new object[]
			{
				typeof(LockOnHelper.LockOnMode),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetFocus", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetThreeDS", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x0002B4BA File Offset: 0x000296BA
		[global::Cpp2ILInjected.Token(Token = "0x600396B")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D070", Offset = "0x144D070", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_MouseWorld", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void FindMostViableTarget(LockOnHelper.LockOnMode context, ref int targetVar)
		{
			throw null;
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x0002B4BD File Offset: 0x000296BD
		[global::Cpp2ILInjected.Token(Token = "0x600396C")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D24C", Offset = "0x144D24C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Toggle", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "CycleTargetThreeDS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "CycleTargetFocus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void HandlePressing()
		{
			throw null;
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x0002B4C0 File Offset: 0x000296C0
		[global::Cpp2ILInjected.Token(Token = "0x600396D")]
		[global::Cpp2ILInjected.Address(RVA = "0x144E45C", Offset = "0x144E45C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "HandlePressing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_MouseWorld", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void CycleTargetFocus()
		{
			throw null;
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x0002B4C3 File Offset: 0x000296C3
		[global::Cpp2ILInjected.Token(Token = "0x600396E")]
		[global::Cpp2ILInjected.Address(RVA = "0x144E2D8", Offset = "0x144E2D8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "HandlePressing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_MouseWorld", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void CycleTargetThreeDS()
		{
			throw null;
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x0002B4C6 File Offset: 0x000296C6
		[global::Cpp2ILInjected.Token(Token = "0x600396F")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D3B4", Offset = "0x144D3B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool CanEnable()
		{
			throw null;
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x0002B4C9 File Offset: 0x000296C9
		[global::Cpp2ILInjected.Token(Token = "0x6003970")]
		[global::Cpp2ILInjected.Address(RVA = "0x144CF24", Offset = "0x144CF24", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "HandlePressing", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetFocus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetThreeDS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "CanEnable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_MouseWorld", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void SetActive(bool on)
		{
			throw null;
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x0002B4CC File Offset: 0x000296CC
		[global::Cpp2ILInjected.Token(Token = "0x6003971")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D97C", Offset = "0x144D97C", Length = "0x5B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "FindMostViableTarget", MemberParameters = new object[]
		{
			typeof(LockOnHelper.LockOnMode),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetFocus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetThreeDS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_MouseWorld", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "DirectionTo", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "ValidTarget", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private static void RefreshTargets(Vector2 position, float radius)
		{
			throw null;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x0002B4CF File Offset: 0x000296CF
		[global::Cpp2ILInjected.Token(Token = "0x6003972")]
		[global::Cpp2ILInjected.Address(RVA = "0x144DF2C", Offset = "0x144DF2C", Length = "0x3AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "FindMostViableTarget", MemberParameters = new object[]
		{
			typeof(LockOnHelper.LockOnMode),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "CycleTargetThreeDS", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "get_MouseWorld", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "DirectionTo", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "DirectionFrom", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Dot", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelper), Member = "ValidTarget", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void GetClosestTarget(Vector2 position)
		{
			throw null;
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x0002B4D2 File Offset: 0x000296D2
		[global::Cpp2ILInjected.Token(Token = "0x6003973")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D33C", Offset = "0x144D33C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "GetClosestTarget", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "get_isLikeATownNPC", ReturnType = typeof(bool))]
		private static bool ValidTarget(NPC n)
		{
			throw null;
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x0002B4D5 File Offset: 0x000296D5
		[global::Cpp2ILInjected.Token(Token = "0x6003974")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D564", Offset = "0x144D564", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "LockOnCachePosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void SetLockPosition(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x0002B4D8 File Offset: 0x000296D8
		[global::Cpp2ILInjected.Token(Token = "0x6003975")]
		[global::Cpp2ILInjected.Address(RVA = "0x144D6B0", Offset = "0x144D6B0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "LockOnUnCachePosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ResetLockPosition()
		{
			throw null;
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x0002B4DB File Offset: 0x000296DB
		[global::Cpp2ILInjected.Token(Token = "0x6003976")]
		[global::Cpp2ILInjected.Address(RVA = "0x144E820", Offset = "0x144E820", Length = "0x106C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_5_GamepadLockOn", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(Color) }, MemberParameters = new object[]
		{
			typeof(ref Color),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = "get_Instance", ReturnType = typeof(LockOnHelperStaticData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Top", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustWorldPositionForUI", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReverseGravitySupport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPC), Member = "GetNPCLocation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(ref int),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(double),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		public static void Draw(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x0002B4DE File Offset: 0x000296DE
		[global::Cpp2ILInjected.Token(Token = "0x6003977")]
		[global::Cpp2ILInjected.Address(RVA = "0x144F88C", Offset = "0x144F88C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LockOnHelper()
		{
			throw null;
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0002B4E1 File Offset: 0x000296E1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003978")]
		[global::Cpp2ILInjected.Address(RVA = "0x144F894", Offset = "0x144F894", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static LockOnHelper()
		{
			throw null;
		}

		// Token: 0x040065C8 RID: 26056
		[global::Cpp2ILInjected.Token(Token = "0x40079D9")]
		private const float LOCKON_RANGE = 2000f;

		// Token: 0x040065C9 RID: 26057
		[global::Cpp2ILInjected.Token(Token = "0x40079DA")]
		private const int LOCKON_HOLD_LIFETIME = 40;

		// Token: 0x040065CA RID: 26058
		[global::Cpp2ILInjected.Token(Token = "0x40079DB")]
		private static List<int> tempTargets;

		// Token: 0x02000949 RID: 2377
		[global::Cpp2ILInjected.Token(Token = "0x20006C4")]
		public enum LockOnMode
		{
			// Token: 0x04008AF1 RID: 35569
			[global::Cpp2ILInjected.Token(Token = "0x40079DD")]
			FocusTarget,
			// Token: 0x04008AF2 RID: 35570
			[global::Cpp2ILInjected.Token(Token = "0x40079DE")]
			TargetClosest,
			// Token: 0x04008AF3 RID: 35571
			[global::Cpp2ILInjected.Token(Token = "0x40079DF")]
			ThreeDS
		}
	}
}
