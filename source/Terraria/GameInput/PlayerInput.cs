using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.GameContent.UI.Chat;
using Terraria.GameContent.UI.Elements;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.States;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.IO;
using Terraria.UI;

namespace Terraria.GameInput
{
	// Token: 0x020004B0 RID: 1200
	[global::Cpp2ILInjected.Token(Token = "0x20006C5")]
	public class PlayerInput
	{
		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x0002B4E4 File Offset: 0x000296E4
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x0002B4E7 File Offset: 0x000296E7
		[global::Cpp2ILInjected.Token(Token = "0x170006EF")]
		public static TriggersPack Triggers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003979")]
			[global::Cpp2ILInjected.Address(RVA = "0x144F920", Offset = "0x144F920", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 90)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600397A")]
			[global::Cpp2ILInjected.Address(RVA = "0x144F96C", Offset = "0x144F96C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x0002B4EA File Offset: 0x000296EA
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x0002B4ED File Offset: 0x000296ED
		[global::Cpp2ILInjected.Token(Token = "0x170006F0")]
		public static MouseState MouseInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600397B")]
			[global::Cpp2ILInjected.Address(RVA = "0x144F9BC", Offset = "0x144F9BC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600397C")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FA1C", Offset = "0x144FA1C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "ResetInputsOnActiveStateChange", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x0002B4F0 File Offset: 0x000296F0
		// (set) Token: 0x06003424 RID: 13348 RVA: 0x0002B4F3 File Offset: 0x000296F3
		[global::Cpp2ILInjected.Token(Token = "0x170006F1")]
		public static MouseState MouseInfoOld
		{
			[global::Cpp2ILInjected.Token(Token = "0x600397D")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FA7C", Offset = "0x144FA7C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600397E")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FADC", Offset = "0x144FADC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "ResetInputsOnActiveStateChange", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x0002B4F6 File Offset: 0x000296F6
		// (set) Token: 0x06003426 RID: 13350 RVA: 0x0002B4F9 File Offset: 0x000296F9
		[global::Cpp2ILInjected.Token(Token = "0x170006F2")]
		public static int MouseX
		{
			[global::Cpp2ILInjected.Token(Token = "0x600397F")]
			[global::Cpp2ILInjected.Address(RVA = "0x144E788", Offset = "0x144E788", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceForwardCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceSmartSelectCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "ResetLockPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateMainMouse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003980")]
			[global::Cpp2ILInjected.Address(RVA = "0x144E690", Offset = "0x144E690", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceForwardCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceSmartSelectCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetLockPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnUnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x0002B4FC File Offset: 0x000296FC
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x0002B4FF File Offset: 0x000296FF
		[global::Cpp2ILInjected.Token(Token = "0x170006F3")]
		public static int MouseY
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003981")]
			[global::Cpp2ILInjected.Address(RVA = "0x144E7D4", Offset = "0x144E7D4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceForwardCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceSmartSelectCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "ResetLockPosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateMainMouse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003982")]
			[global::Cpp2ILInjected.Address(RVA = "0x144E6E0", Offset = "0x144E6E0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceForwardCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ForceSmartSelectCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetLockPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "HandleDpadSnap", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnUnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x0002B502 File Offset: 0x00029702
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x0002B505 File Offset: 0x00029705
		[global::Cpp2ILInjected.Token(Token = "0x170006F4")]
		public static bool LockGamepadTileUseButton
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003983")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FB3C", Offset = "0x144FB3C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersSet), Member = "ShouldLockTileUsage", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WiresUI.WiresRadial), Member = "FlowerUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003984")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FB88", Offset = "0x144FB88", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LockGamepadTileInteractions", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersSet), Member = "CopyIntoDuringChat", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x0002B508 File Offset: 0x00029708
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x0002B50B File Offset: 0x0002970B
		[global::Cpp2ILInjected.Token(Token = "0x170006F5")]
		public static int PreUIX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003985")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FBD8", Offset = "0x144FBD8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003986")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FC24", Offset = "0x144FC24", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x0002B50E File Offset: 0x0002970E
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x0002B511 File Offset: 0x00029711
		[global::Cpp2ILInjected.Token(Token = "0x170006F6")]
		public static int PreUIY
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003987")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FC74", Offset = "0x144FC74", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003988")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FCC0", Offset = "0x144FCC0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x0002B514 File Offset: 0x00029714
		// (set) Token: 0x06003430 RID: 13360 RVA: 0x0002B517 File Offset: 0x00029717
		[global::Cpp2ILInjected.Token(Token = "0x170006F7")]
		public static int PreLockOnX
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003989")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FD10", Offset = "0x144FD10", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnUnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600398A")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FD5C", Offset = "0x144FD5C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x0002B51A File Offset: 0x0002971A
		// (set) Token: 0x06003432 RID: 13362 RVA: 0x0002B51D File Offset: 0x0002971D
		[global::Cpp2ILInjected.Token(Token = "0x170006F8")]
		public static int PreLockOnY
		{
			[global::Cpp2ILInjected.Token(Token = "0x600398B")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FDAC", Offset = "0x144FDAC", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnUnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600398C")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FDF8", Offset = "0x144FDF8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "LockOnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x0002B520 File Offset: 0x00029720
		// (set) Token: 0x06003434 RID: 13364 RVA: 0x0002B523 File Offset: 0x00029723
		[global::Cpp2ILInjected.Token(Token = "0x170006F9")]
		public static int ScrollWheelValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600398D")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FE48", Offset = "0x144FE48", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "GamePadInput", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600398E")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FE94", Offset = "0x144FE94", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "GamePadInput", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06003435 RID: 13365 RVA: 0x0002B526 File Offset: 0x00029726
		// (set) Token: 0x06003436 RID: 13366 RVA: 0x0002B529 File Offset: 0x00029729
		[global::Cpp2ILInjected.Token(Token = "0x170006FA")]
		public static int ScrollWheelValueOld
		{
			[global::Cpp2ILInjected.Token(Token = "0x600398F")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FEE4", Offset = "0x144FEE4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003990")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FF30", Offset = "0x144FF30", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x0002B52C File Offset: 0x0002972C
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x0002B52F File Offset: 0x0002972F
		[global::Cpp2ILInjected.Token(Token = "0x170006FB")]
		public static int ScrollWheelDelta
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003991")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FF80", Offset = "0x144FF80", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TryInterruptingItemUsage", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Update", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetMouseScrollDelta", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HandleHotbar", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Scrolling", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6003992")]
			[global::Cpp2ILInjected.Address(RVA = "0x144FFCC", Offset = "0x144FFCC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06003439 RID: 13369 RVA: 0x0002B532 File Offset: 0x00029732
		// (remove) Token: 0x0600343A RID: 13370 RVA: 0x0002B535 File Offset: 0x00029735
		[global::Cpp2ILInjected.Token(Token = "0x14000044")]
		public static event Action OnBindingChange
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003993")]
			[global::Cpp2ILInjected.Address(RVA = "0x145001C", Offset = "0x145001C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003994")]
			[global::Cpp2ILInjected.Address(RVA = "0x14500F8", Offset = "0x14500F8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x0600343B RID: 13371 RVA: 0x0002B538 File Offset: 0x00029738
		// (remove) Token: 0x0600343C RID: 13372 RVA: 0x0002B53B File Offset: 0x0002973B
		[global::Cpp2ILInjected.Token(Token = "0x14000045")]
		public static event Action OnActionableInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003995")]
			[global::Cpp2ILInjected.Address(RVA = "0x14501D4", Offset = "0x14501D4", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003996")]
			[global::Cpp2ILInjected.Address(RVA = "0x14502B0", Offset = "0x14502B0", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x0002B53E File Offset: 0x0002973E
		[global::Cpp2ILInjected.Token(Token = "0x6003997")]
		[global::Cpp2ILInjected.Address(RVA = "0x145038C", Offset = "0x145038C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void ListenFor(string triggerName, InputMode inputmode)
		{
			throw null;
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x0002B541 File Offset: 0x00029741
		[global::Cpp2ILInjected.Token(Token = "0x170006FC")]
		public static string ListeningTrigger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003998")]
			[global::Cpp2ILInjected.Address(RVA = "0x14503F8", Offset = "0x14503F8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x0002B544 File Offset: 0x00029744
		[global::Cpp2ILInjected.Token(Token = "0x170006FD")]
		public static bool CurrentlyRebinding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003999")]
			[global::Cpp2ILInjected.Address(RVA = "0x1450450", Offset = "0x1450450", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x0002B547 File Offset: 0x00029747
		[global::Cpp2ILInjected.Token(Token = "0x170006FE")]
		public static bool InvisibleGamepadInMenus
		{
			[global::Cpp2ILInjected.Token(Token = "0x600399A")]
			[global::Cpp2ILInjected.Address(RVA = "0x14504B0", Offset = "0x14504B0", Length = "0x1C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCursor", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawThickCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ingameOptionsWindow", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_playerInventory", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_CursorIsBusy", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x0002B54A File Offset: 0x0002974A
		[global::Cpp2ILInjected.Token(Token = "0x170006FF")]
		public static PlayerInputProfile CurrentProfile
		{
			[global::Cpp2ILInjected.Token(Token = "0x600399B")]
			[global::Cpp2ILInjected.Address(RVA = "0x14506FC", Offset = "0x14506FC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x0002B54D File Offset: 0x0002974D
		[global::Cpp2ILInjected.Token(Token = "0x17000700")]
		public static KeyConfiguration ProfileGamepadUI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600399C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1450754", Offset = "0x1450754", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x0002B550 File Offset: 0x00029750
		[global::Cpp2ILInjected.Token(Token = "0x17000701")]
		public static bool UsingGamepad
		{
			[global::Cpp2ILInjected.Token(Token = "0x600399D")]
			[global::Cpp2ILInjected.Address(RVA = "0x14507FC", Offset = "0x14507FC", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 67)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x0002B553 File Offset: 0x00029753
		[global::Cpp2ILInjected.Token(Token = "0x17000702")]
		public static bool UsingGamepadUI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600399E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1450884", Offset = "0x1450884", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput.SettingsForUI), Member = "get_HighlightThingsForMouse", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x0002B556 File Offset: 0x00029756
		[global::Cpp2ILInjected.Token(Token = "0x17000703")]
		public static bool IgnoreMouseInterface
		{
			[global::Cpp2ILInjected.Token(Token = "0x600399F")]
			[global::Cpp2ILInjected.Address(RVA = "0x14508E4", Offset = "0x14508E4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GUIHotbarDrawInner", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawButton", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawSlots", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.AchievementUnlockedPopup), Member = "OnMouseOver", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEDisplayDoll), Member = "DrawSlotPairSet", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SpriteBatch),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TEHatRack), Member = "DrawSlotPairSet", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(SpriteBatch),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MinimapFrame), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIDynamicItemCollection), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x0002B559 File Offset: 0x00029759
		[global::Cpp2ILInjected.Token(Token = "0x17000704")]
		public static bool SteamDeckIsUsed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x145097C", Offset = "0x145097C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x0002B55C File Offset: 0x0002975C
		[global::Cpp2ILInjected.Token(Token = "0x60039A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14509D4", Offset = "0x14509D4", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "GetPressedKeys", ReturnType = typeof(Keys[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static bool InvalidateKeyboardSwap()
		{
			throw null;
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x0002B55F File Offset: 0x0002975F
		[global::Cpp2ILInjected.Token(Token = "0x60039A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1450BA4", Offset = "0x1450BA4", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseInfo", MemberParameters = new object[] { typeof(MouseState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseInfoOld", MemberParameters = new object[] { typeof(MouseState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Keyboard), Member = "GetState", ReturnType = typeof(KeyboardState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Clear", ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "GetPressedKeys", ReturnType = typeof(Keys[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void ResetInputsOnActiveStateChange()
		{
			throw null;
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x0002B562 File Offset: 0x00029762
		[global::Cpp2ILInjected.Token(Token = "0x60039A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1450E84", Offset = "0x1450E84", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.FastUseItemMemory), Member = "TryStartForItemSlot", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TryEnteringFastUseModeForInventorySlot(int inventorySlot)
		{
			throw null;
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x0002B565 File Offset: 0x00029765
		[global::Cpp2ILInjected.Token(Token = "0x60039A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1450F1C", Offset = "0x1450F1C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.FastUseItemMemory), Member = "TryStartForMouse", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void TryEnteringFastUseModeForMouseItem()
		{
			throw null;
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x0002B568 File Offset: 0x00029768
		[global::Cpp2ILInjected.Token(Token = "0x17000705")]
		public static bool ShouldFastUseItem
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1450FAC", Offset = "0x1450FAC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.FastUseItemMemory), Member = "CanFastUse", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x0002B56B File Offset: 0x0002976B
		[global::Cpp2ILInjected.Token(Token = "0x60039A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1451008", Offset = "0x1451008", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.FastUseItemMemory), Member = "EndFastUse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void TryEndingFastUse()
		{
			throw null;
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x0002B56E File Offset: 0x0002976E
		[global::Cpp2ILInjected.Token(Token = "0x17000706")]
		public static bool InBuildingMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1451064", Offset = "0x1451064", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x0002B571 File Offset: 0x00029771
		[global::Cpp2ILInjected.Token(Token = "0x17000707")]
		public static int RealScreenWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x14510BC", Offset = "0x14510BC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x0002B574 File Offset: 0x00029774
		[global::Cpp2ILInjected.Token(Token = "0x17000708")]
		public static int RealScreenHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1451114", Offset = "0x1451114", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x0002B577 File Offset: 0x00029777
		[global::Cpp2ILInjected.Token(Token = "0x60039AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x145116C", Offset = "0x145116C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SetSelectedProfile(string name)
		{
			throw null;
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x0002B57A File Offset: 0x0002977A
		[global::Cpp2ILInjected.Token(Token = "0x60039AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1451238", Offset = "0x1451238", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_InputProfiles", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences.TextProcessAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnProcessText", MemberParameters = new object[] { typeof(Preferences.TextProcessAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "Initialize", MemberParameters = new object[] { typeof(PresetProfiles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "SetSelectedProfile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x0002B57D File Offset: 0x0002977D
		[global::Cpp2ILInjected.Token(Token = "0x17000709")]
		public static bool CursorIsBusy
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1450674", Offset = "0x1450674", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawTileGridOption", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "get_InvisibleGamepadInMenus", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersSet), Member = "CopyInto", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x0002B580 File Offset: 0x00029780
		[global::Cpp2ILInjected.Token(Token = "0x60039AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x145162C", Offset = "0x145162C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static bool IsGamepadButtonLockedFromUse(string keyName)
		{
			throw null;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x0002B583 File Offset: 0x00029783
		[global::Cpp2ILInjected.Token(Token = "0x60039AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14516A4", Offset = "0x14516A4", Length = "0x578")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_HandleInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "UpdateCounters", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_ScrollWheelValue", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_ScrollWheelValueOld", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_ScrollWheelValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyConfiguration), Member = "get_DoGrappleAndInteractShareTheSameKey", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "MouseInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "KeyboardInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "GamePadInput", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "PostInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_ScrollWheelValueOld", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_ScrollWheelDelta", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_ScrollWheelDelta", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "UpdateMainMouse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeftRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRightRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_MouseLeft", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseLeft", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_MouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRight", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUIInputLayer), Member = "GetWorldCursor", ReturnType = typeof(Cursor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "CacheZoomableValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public static void UpdateInput()
		{
			throw null;
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x0002B586 File Offset: 0x00029786
		[global::Cpp2ILInjected.Token(Token = "0x60039AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452C24", Offset = "0x1452C24", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lastMouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lastMouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_worldMouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void UpdateMainMouse()
		{
			throw null;
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x0002B589 File Offset: 0x00029789
		[global::Cpp2ILInjected.Token(Token = "0x60039B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452CE8", Offset = "0x1452CE8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "CacheOriginalInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "CacheOriginalScreenDimensions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void CacheZoomableValues()
		{
			throw null;
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x0002B58C File Offset: 0x0002978C
		[global::Cpp2ILInjected.Token(Token = "0x60039B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452EA0", Offset = "0x1452EA0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_HandleInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CacheMousePositionForZoom()
		{
			throw null;
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x0002B58F File Offset: 0x0002978F
		[global::Cpp2ILInjected.Token(Token = "0x60039B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452D38", Offset = "0x1452D38", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "CacheZoomableValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_lastMouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_lastMouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void CacheOriginalInput()
		{
			throw null;
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x0002B592 File Offset: 0x00029792
		[global::Cpp2ILInjected.Token(Token = "0x60039B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452E00", Offset = "0x1452E00", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "ClientInitialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "CacheZoomableValues", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CacheOriginalScreenDimensions()
		{
			throw null;
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x0002B595 File Offset: 0x00029795
		[global::Cpp2ILInjected.Token(Token = "0x1700070A")]
		public static Vector2 OriginalScreenSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60039B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1452F50", Offset = "0x1452F50", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserInterface), Member = "GetDimensions", ReturnType = typeof(CalculatedStyle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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

		// Token: 0x0600345B RID: 13403 RVA: 0x0002B598 File Offset: 0x00029798
		[global::Cpp2ILInjected.Token(Token = "0x60039B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452930", Offset = "0x1452930", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_ScrollWheelValue", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_ScrollWheelValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SettingBlockGamepadsEntirely", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static bool GamePadInput()
		{
			throw null;
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x0002B59B File Offset: 0x0002979B
		[global::Cpp2ILInjected.Token(Token = "0x60039B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1451C1C", Offset = "0x1451C1C", Length = "0x5E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseInfo", ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseInfoOld", MemberParameters = new object[] { typeof(MouseState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mouse), Member = "GetState", ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseInfo", MemberParameters = new object[] { typeof(MouseState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_ScrollWheelValue", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_ScrollWheelValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseInfoOld", ReturnType = typeof(MouseState))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private static void MouseInput()
		{
			throw null;
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x0002B59E File Offset: 0x0002979E
		[global::Cpp2ILInjected.Token(Token = "0x60039B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452204", Offset = "0x1452204", Length = "0x72C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "GetPressedKeys", ReturnType = typeof(Keys[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_blockKey", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_blockKey", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyboardState), Member = "IsKeyDown", MemberParameters = new object[] { typeof(Keys) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyConfiguration), Member = "CopyKeyState", MemberParameters = new object[]
		{
			typeof(TriggersSet),
			typeof(TriggersSet),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyConfiguration), Member = "Processkey", MemberParameters = new object[]
		{
			typeof(TriggersSet),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private static bool KeyboardInput()
		{
			throw null;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x0002B5A1 File Offset: 0x000297A1
		[global::Cpp2ILInjected.Token(Token = "0x60039B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453744", Offset = "0x1453744", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void DebugKeys(List<Keys> keys)
		{
			throw null;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x0002B5A4 File Offset: 0x000297A4
		[global::Cpp2ILInjected.Token(Token = "0x60039B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453748", Offset = "0x1453748", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void FixDerpedRebinds()
		{
			throw null;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x0002B5A7 File Offset: 0x000297A7
		[global::Cpp2ILInjected.Token(Token = "0x60039BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452FC4", Offset = "0x1452FC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool CheckRebindingProcessGamepad(string newKey)
		{
			throw null;
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x0002B5AA File Offset: 0x000297AA
		[global::Cpp2ILInjected.Token(Token = "0x60039BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x145373C", Offset = "0x145373C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool CheckRebindingProcessKeyboard(string newKey)
		{
			throw null;
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x0002B5AD File Offset: 0x000297AD
		[global::Cpp2ILInjected.Token(Token = "0x60039BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452A30", Offset = "0x1452A30", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInputProfile), Member = "get_HotbarAllowsRadial", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_HotbarPlus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_HotbarMinus", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "set_RadialHotbar", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "set_RadialQuickbar", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void PostInput()
		{
			throw null;
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x0002B5B0 File Offset: 0x000297B0
		[global::Cpp2ILInjected.Token(Token = "0x60039BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1452FCC", Offset = "0x1452FCC", Length = "0x770")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_DpadMouseSnap1", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_DpadMouseSnap2", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_DpadMouseSnap3", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "get_DpadMouseSnap4", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "IsABuildingItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_ZoomMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToWorldCoordinates", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private static void HandleDpadSnap()
		{
			throw null;
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x0002B5B3 File Offset: 0x000297B3
		[global::Cpp2ILInjected.Token(Token = "0x60039BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x145374C", Offset = "0x145374C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "GenerateGlyphList", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string BuildCommand(string CommandText, bool Last, params List<string>[] Bindings)
		{
			throw null;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x0002B5B6 File Offset: 0x000297B6
		[global::Cpp2ILInjected.Token(Token = "0x60039BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14538EC", Offset = "0x14538EC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "BuildCommand", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(List<string>[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlyphTagHandler), Member = "GenerateTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static string GenerateGlyphList(List<string> list)
		{
			throw null;
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x0002B5B9 File Offset: 0x000297B9
		[global::Cpp2ILInjected.Token(Token = "0x60039C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453A3C", Offset = "0x1453A3C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static string GenerateRawInputList(List<string> list)
		{
			throw null;
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x0002B5BC File Offset: 0x000297BC
		[global::Cpp2ILInjected.Token(Token = "0x60039C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453B28", Offset = "0x1453B28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void NavigatorCachePosition()
		{
			throw null;
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x0002B5BF File Offset: 0x000297BF
		[global::Cpp2ILInjected.Token(Token = "0x60039C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453B2C", Offset = "0x1453B2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ToggleInv", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput.SettingsForUI), Member = "TryRevertingToMouseMode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static void NavigatorUnCachePosition()
		{
			throw null;
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x0002B5C2 File Offset: 0x000297C2
		[global::Cpp2ILInjected.Token(Token = "0x60039C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x144E638", Offset = "0x144E638", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "SetLockPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_PreLockOnX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_MouseY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_PreLockOnY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LockOnCachePosition()
		{
			throw null;
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x0002B5C5 File Offset: 0x000297C5
		[global::Cpp2ILInjected.Token(Token = "0x60039C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x144E730", Offset = "0x144E730", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "ResetLockPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_PreLockOnX", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_PreLockOnY", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "set_MouseY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void LockOnUnCachePosition()
		{
			throw null;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x0002B5C8 File Offset: 0x000297C8
		[global::Cpp2ILInjected.Token(Token = "0x60039C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453B30", Offset = "0x1453B30", Length = "0x340")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Split", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(StringSplitOptions)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static void PrettyPrintProfiles(ref string text)
		{
			throw null;
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x0002B5CB File Offset: 0x000297CB
		[global::Cpp2ILInjected.Token(Token = "0x60039C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453E70", Offset = "0x1453E70", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void PrettyPrintProfilesOld(ref string text)
		{
			throw null;
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x0002B5CE File Offset: 0x000297CE
		[global::Cpp2ILInjected.Token(Token = "0x60039C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1453FEC", Offset = "0x1453FEC", Length = "0x60A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInputProfile), Member = "Initialize", MemberParameters = new object[] { typeof(PresetProfiles) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Int32Enum, object>), Member = "get_Item", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 53)]
		public static void Reset(KeyConfiguration c, PresetProfiles style, InputMode mode)
		{
			throw null;
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x0002B5D1 File Offset: 0x000297D1
		[global::Cpp2ILInjected.Token(Token = "0x60039C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A094", Offset = "0x145A094", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCChatBubble", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PreDrawMenu", MemberParameters = new object[]
		{
			typeof(ref Point),
			typeof(ref Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameInterfaceLayer), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		public static void SetZoom_UI()
		{
			throw null;
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x0002B5D4 File Offset: 0x000297D4
		[global::Cpp2ILInjected.Token(Token = "0x60039C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A098", Offset = "0x145A098", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameInterfaceLayer), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static void SetZoom_World()
		{
			throw null;
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x0002B5D7 File Offset: 0x000297D7
		[global::Cpp2ILInjected.Token(Token = "0x60039CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A09C", Offset = "0x145A09C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_HandleInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameInterfaceLayer), Member = "Draw", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaptureInterface), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		public static void SetZoom_Unscaled()
		{
			throw null;
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x0002B5DA File Offset: 0x000297DA
		[global::Cpp2ILInjected.Token(Token = "0x60039CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0A0", Offset = "0x145A0A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void SetZoom_Test()
		{
			throw null;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x0002B5DD File Offset: 0x000297DD
		[global::Cpp2ILInjected.Token(Token = "0x60039CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0A4", Offset = "0x145A0A4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate_HandleInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjectiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HoverOverNPCs", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_38_MouseCarriedObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public static void SetZoom_MouseInWorld()
		{
			throw null;
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x0002B5E0 File Offset: 0x000297E0
		[global::Cpp2ILInjected.Token(Token = "0x60039CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0A8", Offset = "0x145A0A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static void SetDesiredZoomContext(ZoomContext context)
		{
			throw null;
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x0002B5E3 File Offset: 0x000297E3
		[global::Cpp2ILInjected.Token(Token = "0x60039CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0AC", Offset = "0x145A0AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeChangeSettings", Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static void SetZoom_Context()
		{
			throw null;
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x0002B5E6 File Offset: 0x000297E6
		[global::Cpp2ILInjected.Token(Token = "0x60039CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0B0", Offset = "0x145A0B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void SetZoom_Scaled(float scale)
		{
			throw null;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x0002B5E9 File Offset: 0x000297E9
		[global::Cpp2ILInjected.Token(Token = "0x60039D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0B4", Offset = "0x145A0B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerInput()
		{
			throw null;
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x0002B5EC File Offset: 0x000297EC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60039D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x145A0BC", Offset = "0x145A0BC", Length = "0x13F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmartSelectGamepadPointer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetValues", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		static PlayerInput()
		{
			throw null;
		}

		// Token: 0x040065CB RID: 26059
		[global::Cpp2ILInjected.Token(Token = "0x40079E0")]
		public static Vector2 RawMouseScale;

		// Token: 0x040065CC RID: 26060
		[global::Cpp2ILInjected.Token(Token = "0x40079E1")]
		public static bool GrappleAndInteractAreShared;

		// Token: 0x040065CD RID: 26061
		[global::Cpp2ILInjected.Token(Token = "0x40079E2")]
		public static SmartSelectGamepadPointer smartSelectPointer;

		// Token: 0x040065CE RID: 26062
		[global::Cpp2ILInjected.Token(Token = "0x40079E3")]
		private static StringBuilder _invalidatorCheck;

		// Token: 0x040065CF RID: 26063
		[global::Cpp2ILInjected.Token(Token = "0x40079E4")]
		private static StringBuilder ff;

		// Token: 0x040065D0 RID: 26064
		[global::Cpp2ILInjected.Token(Token = "0x40079E5")]
		private static bool _lastActivityState;

		// Token: 0x040065D1 RID: 26065
		[global::Cpp2ILInjected.Token(Token = "0x40079E6")]
		public static int ScrollWheelDeltaForUI;

		// Token: 0x040065D2 RID: 26066
		[global::Cpp2ILInjected.Token(Token = "0x40079E7")]
		public static bool GamepadAllowScrolling;

		// Token: 0x040065D3 RID: 26067
		[global::Cpp2ILInjected.Token(Token = "0x40079E8")]
		public static int GamepadScrollValue;

		// Token: 0x040065D4 RID: 26068
		[global::Cpp2ILInjected.Token(Token = "0x40079E9")]
		public static Vector2 GamepadThumbstickLeft;

		// Token: 0x040065D5 RID: 26069
		[global::Cpp2ILInjected.Token(Token = "0x40079EA")]
		public static Vector2 GamepadThumbstickRight;

		// Token: 0x040065D6 RID: 26070
		[global::Cpp2ILInjected.Token(Token = "0x40079EB")]
		private static PlayerInput.FastUseItemMemory _fastUseMemory;

		// Token: 0x040065D7 RID: 26071
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40079EC")]
		private static Action OnBindingChange;

		// Token: 0x040065D8 RID: 26072
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40079ED")]
		private static Action OnActionableInput;

		// Token: 0x040065D9 RID: 26073
		[global::Cpp2ILInjected.Token(Token = "0x40079EE")]
		private static string _listeningTrigger;

		// Token: 0x040065DA RID: 26074
		[global::Cpp2ILInjected.Token(Token = "0x40079EF")]
		private static InputMode _listeningInputMode;

		// Token: 0x040065DB RID: 26075
		[global::Cpp2ILInjected.Token(Token = "0x40079F0")]
		private static bool _canReleaseRebindingLock;

		// Token: 0x040065DC RID: 26076
		[global::Cpp2ILInjected.Token(Token = "0x40079F1")]
		private static int _memoOfLastPoint;

		// Token: 0x040065DD RID: 26077
		[global::Cpp2ILInjected.Token(Token = "0x40079F2")]
		public static int NavigatorRebindingLock;

		// Token: 0x040065DE RID: 26078
		[global::Cpp2ILInjected.Token(Token = "0x40079F3")]
		public static string BlockedKey;

		// Token: 0x040065DF RID: 26079
		[global::Cpp2ILInjected.Token(Token = "0x40079F4")]
		public static Dictionary<string, PlayerInputProfile> Profiles;

		// Token: 0x040065E0 RID: 26080
		[global::Cpp2ILInjected.Token(Token = "0x40079F5")]
		public static Dictionary<string, PlayerInputProfile> OriginalProfiles;

		// Token: 0x040065E1 RID: 26081
		[global::Cpp2ILInjected.Token(Token = "0x40079F6")]
		private static string _selectedProfile;

		// Token: 0x040065E2 RID: 26082
		[global::Cpp2ILInjected.Token(Token = "0x40079F7")]
		private static PlayerInputProfile _currentProfile;

		// Token: 0x040065E3 RID: 26083
		[global::Cpp2ILInjected.Token(Token = "0x40079F8")]
		public static InputMode CurrentInputMode;

		// Token: 0x040065E4 RID: 26084
		[global::Cpp2ILInjected.Token(Token = "0x40079F9")]
		private static Microsoft.Xna.Framework.Input.Buttons[] ButtonsGamepad;

		// Token: 0x040065E5 RID: 26085
		[global::Cpp2ILInjected.Token(Token = "0x40079FA")]
		public static bool UseSteamDeckIfPossible;

		// Token: 0x040065E6 RID: 26086
		[global::Cpp2ILInjected.Token(Token = "0x40079FB")]
		public static List<string> MouseKeys;

		// Token: 0x040065E7 RID: 26087
		[global::Cpp2ILInjected.Token(Token = "0x40079FC")]
		private static bool _InBuildingMode;

		// Token: 0x040065E8 RID: 26088
		[global::Cpp2ILInjected.Token(Token = "0x40079FD")]
		private static int _UIPointForBuildingMode;

		// Token: 0x040065E9 RID: 26089
		[global::Cpp2ILInjected.Token(Token = "0x40079FE")]
		public static bool WritingText;

		// Token: 0x040065EA RID: 26090
		[global::Cpp2ILInjected.Token(Token = "0x40079FF")]
		private static int _originalMouseX;

		// Token: 0x040065EB RID: 26091
		[global::Cpp2ILInjected.Token(Token = "0x4007A00")]
		private static int _originalMouseY;

		// Token: 0x040065EC RID: 26092
		[global::Cpp2ILInjected.Token(Token = "0x4007A01")]
		private static int _originalLastMouseX;

		// Token: 0x040065ED RID: 26093
		[global::Cpp2ILInjected.Token(Token = "0x4007A02")]
		private static int _originalLastMouseY;

		// Token: 0x040065EE RID: 26094
		[global::Cpp2ILInjected.Token(Token = "0x4007A03")]
		private static int _originalScreenWidth;

		// Token: 0x040065EF RID: 26095
		[global::Cpp2ILInjected.Token(Token = "0x4007A04")]
		private static int _originalScreenHeight;

		// Token: 0x040065F0 RID: 26096
		[global::Cpp2ILInjected.Token(Token = "0x4007A05")]
		private static ZoomContext _currentWantedZoom;

		// Token: 0x040065F1 RID: 26097
		[global::Cpp2ILInjected.Token(Token = "0x4007A06")]
		private static List<string> _buttonsLocked;

		// Token: 0x040065F2 RID: 26098
		[global::Cpp2ILInjected.Token(Token = "0x4007A07")]
		private static int[] DpadSnapCooldown;

		// Token: 0x0200094A RID: 2378
		[global::Cpp2ILInjected.Token(Token = "0x20006C6")]
		public class MiscSettingsTEMP
		{
			// Token: 0x06004CCF RID: 19663 RVA: 0x0002F942 File Offset: 0x0002DB42
			[global::Cpp2ILInjected.Token(Token = "0x60039D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x146D950", Offset = "0x146D950", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public MiscSettingsTEMP()
			{
				throw null;
			}

			// Token: 0x06004CD0 RID: 19664 RVA: 0x0002F945 File Offset: 0x0002DB45
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60039D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x146D958", Offset = "0x146D958", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static MiscSettingsTEMP()
			{
				throw null;
			}

			// Token: 0x04008AF4 RID: 35572
			[global::Cpp2ILInjected.Token(Token = "0x4007A08")]
			public static bool HotbarRadialShouldBeUsed;
		}

		// Token: 0x0200094B RID: 2379
		[global::Cpp2ILInjected.Token(Token = "0x20006C7")]
		public static class SettingsForUI
		{
			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06004CD1 RID: 19665 RVA: 0x0002F948 File Offset: 0x0002DB48
			// (set) Token: 0x06004CD2 RID: 19666 RVA: 0x0002F94B File Offset: 0x0002DB4B
			[global::Cpp2ILInjected.Token(Token = "0x1700070B")]
			public static CursorMode CurrentCursorMode
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60039D4")]
				[global::Cpp2ILInjected.Address(RVA = "0x146D9A4", Offset = "0x146D9A4", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60039D5")]
				[global::Cpp2ILInjected.Address(RVA = "0x146D9EC", Offset = "0x146D9EC", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06004CD3 RID: 19667 RVA: 0x0002F94E File Offset: 0x0002DB4E
			[global::Cpp2ILInjected.Token(Token = "0x60039D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x146DA38", Offset = "0x146DA38", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput.SettingsForUI), Member = "TryRevertingToMouseMode", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static void SetCursorMode(CursorMode cursorMode)
			{
				throw null;
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06004CD4 RID: 19668 RVA: 0x0002F951 File Offset: 0x0002DB51
			[global::Cpp2ILInjected.Token(Token = "0x1700070C")]
			public static bool ShowGamepadHints
			{
				[global::Cpp2ILInjected.Token(Token = "0x60039D7")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DAE0", Offset = "0x146DAE0", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "HackForGamepadInputHell", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "ShouldShowKeyboard", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "Update", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "NeedsVirtualkeyboard", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06004CD5 RID: 19669 RVA: 0x0002F954 File Offset: 0x0002DB54
			[global::Cpp2ILInjected.Token(Token = "0x1700070D")]
			public static bool AllowSecondaryGamepadAim
			{
				[global::Cpp2ILInjected.Token(Token = "0x60039D8")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DB94", Offset = "0x146DB94", Length = "0xD4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06004CD6 RID: 19670 RVA: 0x0002F957 File Offset: 0x0002DB57
			[global::Cpp2ILInjected.Token(Token = "0x1700070E")]
			public static bool PushEquipmentAreaUp
			{
				[global::Cpp2ILInjected.Token(Token = "0x60039D9")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DC68", Offset = "0x146DC68", Length = "0xB4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_RecommendedEquipmentAreaPushUp", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x0002F95A File Offset: 0x0002DB5A
			[global::Cpp2ILInjected.Token(Token = "0x1700070F")]
			public static bool ShowGamepadCursor
			{
				[global::Cpp2ILInjected.Token(Token = "0x60039DA")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DD1C", Offset = "0x146DD1C", Length = "0xE4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawThickCursor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector2))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x0002F95D File Offset: 0x0002DB5D
			[global::Cpp2ILInjected.Token(Token = "0x17000710")]
			public static bool HighlightThingsForMouse
			{
				[global::Cpp2ILInjected.Token(Token = "0x60039DB")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DE00", Offset = "0x146DE00", Length = "0x9C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemSlot), Member = "Draw", MemberParameters = new object[]
				{
					typeof(SpriteBatch),
					typeof(Item[]),
					typeof(int),
					typeof(int),
					typeof(Vector2),
					typeof(Color),
					typeof(Color)
				}, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepadUI", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06004CD9 RID: 19673 RVA: 0x0002F960 File Offset: 0x0002DB60
			// (set) Token: 0x06004CDA RID: 19674 RVA: 0x0002F963 File Offset: 0x0002DB63
			[global::Cpp2ILInjected.Token(Token = "0x17000711")]
			public static int FramesSinceLastTimeInMouseMode
			{
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60039DC")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DE9C", Offset = "0x146DE9C", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[global::Cpp2ILInjected.Token(Token = "0x60039DD")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DEE4", Offset = "0x146DEE4", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06004CDB RID: 19675 RVA: 0x0002F966 File Offset: 0x0002DB66
			[global::Cpp2ILInjected.Token(Token = "0x17000712")]
			public static bool PreventHighlightsForGamepad
			{
				[global::Cpp2ILInjected.Token(Token = "0x60039DE")]
				[global::Cpp2ILInjected.Address(RVA = "0x146DF30", Offset = "0x146DF30", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004CDC RID: 19676 RVA: 0x0002F969 File Offset: 0x0002DB69
			[global::Cpp2ILInjected.Token(Token = "0x60039DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x146DF78", Offset = "0x146DF78", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static void UpdateCounters()
			{
				throw null;
			}

			// Token: 0x06004CDD RID: 19677 RVA: 0x0002F96C File Offset: 0x0002DB6C
			[global::Cpp2ILInjected.Token(Token = "0x60039E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E018", Offset = "0x146E018", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "SetCursorMode", MemberParameters = new object[] { typeof(CursorMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_Triggers", ReturnType = typeof(TriggersPack))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "NavigatorUnCachePosition", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static void TryRevertingToMouseMode()
			{
				throw null;
			}

			// Token: 0x04008AF5 RID: 35573
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007A09")]
			private static CursorMode <CurrentCursorMode>k__BackingField;

			// Token: 0x04008AF6 RID: 35574
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x4007A0A")]
			private static int <FramesSinceLastTimeInMouseMode>k__BackingField;
		}

		// Token: 0x0200094C RID: 2380
		[global::Cpp2ILInjected.Token(Token = "0x20006C8")]
		private struct FastUseItemMemory
		{
			// Token: 0x06004CDE RID: 19678 RVA: 0x0002F96F File Offset: 0x0002DB6F
			[global::Cpp2ILInjected.Token(Token = "0x60039E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E0CC", Offset = "0x146E0CC", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "TryEnteringFastUseModeForInventorySlot", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemSlot), Member = "PickupItemIntoMouse", MemberParameters = new object[]
			{
				typeof(Item[]),
				typeof(int),
				typeof(int),
				typeof(Player)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool TryStartForItemSlot(Player player, int itemSlot)
			{
				throw null;
			}

			// Token: 0x06004CDF RID: 19679 RVA: 0x0002F972 File Offset: 0x0002DB72
			[global::Cpp2ILInjected.Token(Token = "0x60039E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E188", Offset = "0x146E188", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "TryEnteringFastUseModeForMouseItem", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool TryStartForMouse(Player player)
			{
				throw null;
			}

			// Token: 0x06004CE0 RID: 19680 RVA: 0x0002F975 File Offset: 0x0002DB75
			[global::Cpp2ILInjected.Token(Token = "0x60039E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E180", Offset = "0x146E180", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x06004CE1 RID: 19681 RVA: 0x0002F978 File Offset: 0x0002DB78
			[global::Cpp2ILInjected.Token(Token = "0x60039E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E20C", Offset = "0x146E20C", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "get_ShouldFastUseItem", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public bool CanFastUse()
			{
				throw null;
			}

			// Token: 0x06004CE2 RID: 19682 RVA: 0x0002F97B File Offset: 0x0002DB7B
			[global::Cpp2ILInjected.Token(Token = "0x60039E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x146E2A4", Offset = "0x146E2A4", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "TryEndingFastUse", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "get_IsAir", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseItem", ReturnType = typeof(Item))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseItem", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void EndFastUse()
			{
				throw null;
			}

			// Token: 0x04008AF7 RID: 35575
			[global::Cpp2ILInjected.Token(Token = "0x4007A0B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int _slot;

			// Token: 0x04008AF8 RID: 35576
			[global::Cpp2ILInjected.Token(Token = "0x4007A0C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
			private int _itemType;

			// Token: 0x04008AF9 RID: 35577
			[global::Cpp2ILInjected.Token(Token = "0x4007A0D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private bool _shouldFastUse;

			// Token: 0x04008AFA RID: 35578
			[global::Cpp2ILInjected.Token(Token = "0x4007A0E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
			private bool _isMouseItem;

			// Token: 0x04008AFB RID: 35579
			[global::Cpp2ILInjected.Token(Token = "0x4007A0F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Player _player;
		}
	}
}
