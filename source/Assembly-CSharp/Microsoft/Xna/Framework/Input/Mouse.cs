using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;
using Terraria.GameInput;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x02000294 RID: 660
	[global::Cpp2ILInjected.Token(Token = "0x2000356")]
	public static class Mouse
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x00025826 File Offset: 0x00023A26
		[global::Cpp2ILInjected.Token(Token = "0x60015E9")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9D1AC", Offset = "0xA9D1AC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "GetState", ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "PlatformGetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static MouseState GetState(GameWindow window)
		{
			throw null;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00025829 File Offset: 0x00023A29
		[global::Cpp2ILInjected.Token(Token = "0x60015EA")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DE2C", Offset = "0xA9DE2C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner.MouseStateBackup), Member = "UpdateState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "GetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static MouseState GetState()
		{
			throw null;
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0002582C File Offset: 0x00023A2C
		[global::Cpp2ILInjected.Token(Token = "0x60015EB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DEA4", Offset = "0xA9DEA4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetPosition(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0002582F File Offset: 0x00023A2F
		[global::Cpp2ILInjected.Token(Token = "0x60015EC")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DEFC", Offset = "0xA9DEFC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void SetCursor(MouseCursor cursor)
		{
			throw null;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00025832 File Offset: 0x00023A32
		[global::Cpp2ILInjected.Token(Token = "0x60015ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DF54", Offset = "0xA9DF54", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static IntPtr PlatformGetWindowHandle()
		{
			throw null;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00025835 File Offset: 0x00023A35
		[global::Cpp2ILInjected.Token(Token = "0x60015EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DF9C", Offset = "0xA9DF9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void PlatformSetWindowHandle(IntPtr windowHandle)
		{
			throw null;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00025838 File Offset: 0x00023A38
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0002583B File Offset: 0x00023A3B
		[global::Cpp2ILInjected.Token(Token = "0x17000269")]
		private static int scrollAccum
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015EF")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9DFA0", Offset = "0xA9DFA0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015F0")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9DFEC", Offset = "0xA9DFEC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0002583E File Offset: 0x00023A3E
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x00025841 File Offset: 0x00023A41
		[global::Cpp2ILInjected.Token(Token = "0x1700026A")]
		private static float _uiX
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F1")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E03C", Offset = "0xA9E03C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015F2")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E088", Offset = "0xA9E088", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00025844 File Offset: 0x00023A44
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x00025847 File Offset: 0x00023A47
		[global::Cpp2ILInjected.Token(Token = "0x1700026B")]
		private static float _uiY
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F3")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E0E0", Offset = "0xA9E0E0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015F4")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E12C", Offset = "0xA9E12C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x0002584A File Offset: 0x00023A4A
		// (set) Token: 0x06001497 RID: 5271 RVA: 0x0002584D File Offset: 0x00023A4D
		[global::Cpp2ILInjected.Token(Token = "0x1700026C")]
		private static float _X
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F5")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E184", Offset = "0xA9E184", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015F6")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E1D0", Offset = "0xA9E1D0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00025850 File Offset: 0x00023A50
		// (set) Token: 0x06001499 RID: 5273 RVA: 0x00025853 File Offset: 0x00023A53
		[global::Cpp2ILInjected.Token(Token = "0x1700026D")]
		private static float _Y
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F7")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E228", Offset = "0xA9E228", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015F8")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E274", Offset = "0xA9E274", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00025856 File Offset: 0x00023A56
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00025859 File Offset: 0x00023A59
		[global::Cpp2ILInjected.Token(Token = "0x1700026E")]
		private static float _worldScreenOffsetY
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F9")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E2CC", Offset = "0xA9E2CC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015FA")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E318", Offset = "0xA9E318", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0002585C File Offset: 0x00023A5C
		[global::Cpp2ILInjected.Token(Token = "0x60015FB")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9E370", Offset = "0xA9E370", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void SetWorldScreenOffset(float yValue)
		{
			throw null;
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0002585F File Offset: 0x00023A5F
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x00025862 File Offset: 0x00023A62
		[global::Cpp2ILInjected.Token(Token = "0x1700026F")]
		public static int _overloadScreenWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015FC")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E510", Offset = "0xA9E510", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015FD")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E55C", Offset = "0xA9E55C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00025865 File Offset: 0x00023A65
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x00025868 File Offset: 0x00023A68
		[global::Cpp2ILInjected.Token(Token = "0x17000270")]
		public static int _overloadScreenHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015FE")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E5AC", Offset = "0xA9E5AC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60015FF")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E5F8", Offset = "0xA9E5F8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0002586B File Offset: 0x00023A6B
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0002586E File Offset: 0x00023A6E
		[global::Cpp2ILInjected.Token(Token = "0x17000271")]
		public static int _overloadScreenOffsetX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001600")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E648", Offset = "0xA9E648", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001601")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E694", Offset = "0xA9E694", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00025871 File Offset: 0x00023A71
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x00025874 File Offset: 0x00023A74
		[global::Cpp2ILInjected.Token(Token = "0x17000272")]
		public static int _overloadScreenOffsetY
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001602")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E6E4", Offset = "0xA9E6E4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001603")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E730", Offset = "0xA9E730", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "SetupRenderingUI", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00025877 File Offset: 0x00023A77
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0002587A File Offset: 0x00023A7A
		[global::Cpp2ILInjected.Token(Token = "0x17000273")]
		public static Mouse.OverrideState _virtualCursorOverride
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001604")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E780", Offset = "0xA9E780", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001605")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E7CC", Offset = "0xA9E7CC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0002587D File Offset: 0x00023A7D
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00025880 File Offset: 0x00023A80
		[global::Cpp2ILInjected.Token(Token = "0x17000274")]
		public static ButtonState _virtualCursorOverrideState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001606")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E81C", Offset = "0xA9E81C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001607")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E868", Offset = "0xA9E868", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00025883 File Offset: 0x00023A83
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x00025886 File Offset: 0x00023A86
		[global::Cpp2ILInjected.Token(Token = "0x17000275")]
		public static float _virtualCursorOverrideX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001608")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E8B8", Offset = "0xA9E8B8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001609")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E904", Offset = "0xA9E904", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00025889 File Offset: 0x00023A89
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0002588C File Offset: 0x00023A8C
		[global::Cpp2ILInjected.Token(Token = "0x17000276")]
		public static float _virtualCursorOverrideY
		{
			[global::Cpp2ILInjected.Token(Token = "0x600160A")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E95C", Offset = "0xA9E95C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600160B")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9E9A8", Offset = "0xA9E9A8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0002588F File Offset: 0x00023A8F
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x00025892 File Offset: 0x00023A92
		[global::Cpp2ILInjected.Token(Token = "0x17000277")]
		public static bool _overrideRMB
		{
			[global::Cpp2ILInjected.Token(Token = "0x600160C")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9EA00", Offset = "0xA9EA00", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600160D")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9EA4C", Offset = "0xA9EA4C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x00025895 File Offset: 0x00023A95
		// (set) Token: 0x060014B0 RID: 5296 RVA: 0x00025898 File Offset: 0x00023A98
		[global::Cpp2ILInjected.Token(Token = "0x17000278")]
		public static ButtonState _rmbOverrideState
		{
			[global::Cpp2ILInjected.Token(Token = "0x600160E")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9EA9C", Offset = "0xA9EA9C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600160F")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9EAE8", Offset = "0xA9EAE8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060014B1 RID: 5297 RVA: 0x0002589B File Offset: 0x00023A9B
		// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0002589E File Offset: 0x00023A9E
		[global::Cpp2ILInjected.Token(Token = "0x17000279")]
		private static float scrollAccumPartial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001610")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9EB38", Offset = "0xA9EB38", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001611")]
			[global::Cpp2ILInjected.Address(RVA = "0xA9EB84", Offset = "0xA9EB84", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x000258A1 File Offset: 0x00023AA1
		[global::Cpp2ILInjected.Token(Token = "0x6001612")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9EBDC", Offset = "0xA9EBDC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetRMBOverride(bool overrideRMB, ButtonState overrideState)
		{
			throw null;
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x000258A4 File Offset: 0x00023AA4
		[global::Cpp2ILInjected.Token(Token = "0x6001613")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9ECA0", Offset = "0xA9ECA0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Mouse.OverrideState GetOverrideState()
		{
			throw null;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x000258A7 File Offset: 0x00023AA7
		[global::Cpp2ILInjected.Token(Token = "0x6001614")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9ED24", Offset = "0xA9ED24", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputController), Member = "UpdateCursorMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void SetVirtualCursorOverride(Mouse.OverrideState overrideMouse, ButtonState overrideState, float x, float y)
		{
			throw null;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x000258AA File Offset: 0x00023AAA
		[global::Cpp2ILInjected.Token(Token = "0x6001615")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9EF28", Offset = "0xA9EF28", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBestiary), Member = "DropDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIChestSplitStack), Member = "WasSplit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventorySplitStack), Member = "WasSplit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWiresUI), Member = "DrawOverlay", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Rectangle),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "dropItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Vector2 GetUICursorPosition()
		{
			throw null;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000258AD File Offset: 0x00023AAD
		[global::Cpp2ILInjected.Token(Token = "0x6001616")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9F000", Offset = "0xA9F000", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateHorizontal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerDynamicGridNavigator), Member = "NavigateVertical", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(GUIControllerItem))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAmmo), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIBuffs), Member = "UpdateBuffNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUICoins), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHotbar), Member = "RefreshInvCursorPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "UpdateHotbarNavigation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "PreviousItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHousingMenu), Member = "NextItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void UpdateUICursorPoint()
		{
			throw null;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000258B0 File Offset: 0x00023AB0
		[global::Cpp2ILInjected.Token(Token = "0x6001617")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9D220", Offset = "0xA9D220", Length = "0xC0C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mouse), Member = "GetState", MemberParameters = new object[] { typeof(GameWindow) }, ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetUICursor", ReturnType = typeof(Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustRealScreenForUI", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "get_ScreenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseScrollDelta", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "GetMouseButton", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 70)]
		private static MouseState PlatformGetState(GameWindow window)
		{
			throw null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000258B3 File Offset: 0x00023AB3
		[global::Cpp2ILInjected.Token(Token = "0x6001618")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9F14C", Offset = "0xA9F14C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetNumCursors", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CursorManager), Member = "GetCursor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static Cursor ActiveCursor()
		{
			throw null;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000258B6 File Offset: 0x00023AB6
		[global::Cpp2ILInjected.Token(Token = "0x6001619")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DEF8", Offset = "0xA9DEF8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void PlatformSetPosition(int x, int y)
		{
			throw null;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000258B9 File Offset: 0x00023AB9
		[global::Cpp2ILInjected.Token(Token = "0x600161A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9DF50", Offset = "0xA9DF50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void PlatformSetCursor(MouseCursor cursor)
		{
			throw null;
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000258BC File Offset: 0x00023ABC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600161B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA9F1E0", Offset = "0xA9F1E0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static Mouse()
		{
			throw null;
		}

		// Token: 0x04001E17 RID: 7703
		[global::Cpp2ILInjected.Token(Token = "0x40023F4")]
		private static readonly MouseState _defaultState;

		// Token: 0x02000821 RID: 2081
		[global::Cpp2ILInjected.Token(Token = "0x2000357")]
		public enum OverrideState
		{
			// Token: 0x04007D9C RID: 32156
			[global::Cpp2ILInjected.Token(Token = "0x40023F6")]
			None,
			// Token: 0x04007D9D RID: 32157
			[global::Cpp2ILInjected.Token(Token = "0x40023F7")]
			Position,
			// Token: 0x04007D9E RID: 32158
			[global::Cpp2ILInjected.Token(Token = "0x40023F8")]
			Click,
			// Token: 0x04007D9F RID: 32159
			[global::Cpp2ILInjected.Token(Token = "0x40023F9")]
			PositionAndClick
		}
	}
}
