using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Events;
using Terraria.Graphics.Light;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200026D RID: 621
	[global::Cpp2ILInjected.Token(Token = "0x200032E")]
	public struct Rectangle
	{
		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000250D6 File Offset: 0x000232D6
		[global::Cpp2ILInjected.Token(Token = "0x170001E1")]
		public Point Center
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001360")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F240", Offset = "0xA8F240", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 66)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000250D9 File Offset: 0x000232D9
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000250DC File Offset: 0x000232DC
		[global::Cpp2ILInjected.Token(Token = "0x170001E2")]
		public Point Location
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001361")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F268", Offset = "0xA8F268", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001362")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F270", Offset = "0xA8F270", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPVPIcons), Member = "PlayerDraw", MemberParameters = new object[]
			{
				typeof(ItemGrid_Layout),
				typeof(int),
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Colliding", MemberParameters = new object[]
			{
				typeof(Rectangle),
				typeof(Rectangle)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000250DF File Offset: 0x000232DF
		[global::Cpp2ILInjected.Token(Token = "0x170001E3")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001363")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F27C", Offset = "0xA8F27C", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x000250E2 File Offset: 0x000232E2
		[global::Cpp2ILInjected.Token(Token = "0x170001E4")]
		public static Rectangle Empty
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001364")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F2AC", Offset = "0xA8F2AC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000250E5 File Offset: 0x000232E5
		[global::Cpp2ILInjected.Token(Token = "0x170001E5")]
		public int Left
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001365")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F304", Offset = "0xA8F304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x000250E8 File Offset: 0x000232E8
		[global::Cpp2ILInjected.Token(Token = "0x170001E6")]
		public int Right
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001366")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F30C", Offset = "0xA8F30C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 138)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000250EB File Offset: 0x000232EB
		[global::Cpp2ILInjected.Token(Token = "0x170001E7")]
		public int Top
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001367")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F31C", Offset = "0xA8F31C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x000250EE File Offset: 0x000232EE
		[global::Cpp2ILInjected.Token(Token = "0x170001E8")]
		public int Bottom
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001368")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8F324", Offset = "0xA8F324", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 150)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000250F1 File Offset: 0x000232F1
		[global::Cpp2ILInjected.Token(Token = "0x6001369")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F334", Offset = "0xA8F334", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1335)]
		public Rectangle(int x, int y, int width, int height)
		{
			throw null;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x000250F4 File Offset: 0x000232F4
		[global::Cpp2ILInjected.Token(Token = "0x600136A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F340", Offset = "0xA8F340", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIAccessoryInfo), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControlsBanner), Member = "ItemRightDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDisplayDoll), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEquipment), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIHatRack), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIInventory), Member = "LoadPageRegion", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUITalkerList), Member = "ItemDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "ResolveCollisions", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle),
			typeof(GUIPageIconGrouping)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "TeleporterHitboxIntersects", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DoorOpeningHelper), Member = "GetPlayerInfoForOpeningDoor", MemberParameters = new object[] { typeof(Player) }, ReturnType = "Terraria.GameContent.DoorOpeningHelper.PlayerInfoForOpeningDoors")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenObstruction), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Rectangle Union(Rectangle value1, Rectangle value2)
		{
			throw null;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000250F7 File Offset: 0x000232F7
		[global::Cpp2ILInjected.Token(Token = "0x600136B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F42C", Offset = "0xA8F42C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_AttemptToFindTeleportSpot", MemberParameters = new object[]
		{
			typeof(ref Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Union(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
		{
			throw null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000250FA File Offset: 0x000232FA
		[global::Cpp2ILInjected.Token(Token = "0x600136C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F514", Offset = "0xA8F514", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "ClippedDrawItemHandler", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetFairyTreasureCoords", MemberParameters = new object[] { typeof(ref Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FindSharpTearsSpot", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyLighting), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightingEngine), Member = "ExportToMiniMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.DoorOpeningHelper.CommonDoorOpeningInfoProvider", Member = "TryCloseDoor", MemberParameters = new object[] { "Terraria.GameContent.DoorOpeningHelper.DoorOpenCloseTogglingInfo", "Terraria.GameContent.DoorOpeningHelper.PlayerInfoForClosingDoors" }, ReturnType = "Terraria.GameContent.DoorOpeningHelper.DoorCloseAttemptResult")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.DoorOpeningHelper.TallGateOpeningInfoProvider", Member = "TryCloseDoor", MemberParameters = new object[] { "Terraria.GameContent.DoorOpeningHelper.DoorOpenCloseTogglingInfo", "Terraria.GameContent.DoorOpeningHelper.PlayerInfoForClosingDoors" }, ReturnType = "Terraria.GameContent.DoorOpeningHelper.DoorCloseAttemptResult")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(ref Rectangle),
			typeof(ref Rectangle),
			typeof(ref Rectangle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Rectangle Intersect(Rectangle value1, Rectangle value2)
		{
			throw null;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x000250FD File Offset: 0x000232FD
		[global::Cpp2ILInjected.Token(Token = "0x600136D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F68C", Offset = "0xA8F68C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Intersects(ref Rectangle value, out bool result)
		{
			throw null;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00025100 File Offset: 0x00023300
		[global::Cpp2ILInjected.Token(Token = "0x600136E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F6EC", Offset = "0xA8F6EC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 143)]
		public bool Contains(Point value)
		{
			throw null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00025103 File Offset: 0x00023303
		[global::Cpp2ILInjected.Token(Token = "0x600136F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F734", Offset = "0xA8F734", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIDraggableItemGrid), Member = "ClippedDrawItemHandler", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool Contains(Rectangle value)
		{
			throw null;
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00025106 File Offset: 0x00023306
		[global::Cpp2ILInjected.Token(Token = "0x6001370")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F788", Offset = "0xA8F788", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Contains(ref Rectangle value, out bool result)
		{
			throw null;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00025109 File Offset: 0x00023309
		[global::Cpp2ILInjected.Token(Token = "0x6001371")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F7E8", Offset = "0xA8F7E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 52)]
		public bool Contains(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0002510C File Offset: 0x0002330C
		[global::Cpp2ILInjected.Token(Token = "0x6001372")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F82C", Offset = "0xA8F82C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Contains(ref Point value, out bool result)
		{
			throw null;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0002510F File Offset: 0x0002330F
		[global::Cpp2ILInjected.Token(Token = "0x6001373")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F588", Offset = "0xA8F588", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Rectangle), Member = "Intersect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteBatchItem), Member = "PushClippedImageRegion", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(SpriteBatch),
			typeof(bool),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "DrawMarkedArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "DragBounds", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "DrawMarkedArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Intersects", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Intersect(ref Rectangle value1, ref Rectangle value2, out Rectangle result)
		{
			throw null;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x00025112 File Offset: 0x00023312
		[global::Cpp2ILInjected.Token(Token = "0x6001374")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F8E8", Offset = "0xA8F8E8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "set_ScissorRectangle", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static bool operator ==(Rectangle a, Rectangle b)
		{
			throw null;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00025115 File Offset: 0x00023315
		[global::Cpp2ILInjected.Token(Token = "0x6001375")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F924", Offset = "0xA8F924", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "DrawMarkedArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(Rectangle a, Rectangle b)
		{
			throw null;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00025118 File Offset: 0x00023318
		[global::Cpp2ILInjected.Token(Token = "0x6001376")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F9C8", Offset = "0xA8F9C8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Offset(Point offset)
		{
			throw null;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0002511B File Offset: 0x0002331B
		[global::Cpp2ILInjected.Token(Token = "0x6001377")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F9E0", Offset = "0xA8F9E0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_Spear", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(ref Color),
			typeof(ref SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSunAndMoon", MemberParameters = new object[]
		{
			typeof(Main.SceneArea),
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "HorizontalMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "JumpMovement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Colliding", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Rectangle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_001", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeEdgeSelection", Member = "DrawMarkedArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "DragBounds", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Graphics.Capture.CaptureInterface.ModeDragBounds", Member = "DrawMarkedArea", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenObstruction), Member = "Draw", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		public void Offset(int offsetX, int offsetY)
		{
			throw null;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0002511E File Offset: 0x0002331E
		[global::Cpp2ILInjected.Token(Token = "0x6001378")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F9F4", Offset = "0xA8F9F4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
		public void Inflate(int horizontalValue, int verticalValue)
		{
			throw null;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x00025121 File Offset: 0x00023321
		[global::Cpp2ILInjected.Token(Token = "0x6001379")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F87C", Offset = "0xA8F87C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 174)]
		public bool Intersects(Rectangle rect)
		{
			throw null;
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x00025124 File Offset: 0x00023324
		[global::Cpp2ILInjected.Token(Token = "0x600137A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FA18", Offset = "0xA8FA18", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Rectangle other)
		{
			throw null;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x00025127 File Offset: 0x00023327
		[global::Cpp2ILInjected.Token(Token = "0x600137B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FAB4", Offset = "0xA8FAB4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0002512A File Offset: 0x0002332A
		[global::Cpp2ILInjected.Token(Token = "0x600137C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FB90", Offset = "0xA8FB90", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteFont.Glyph), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0002512D File Offset: 0x0002332D
		[global::Cpp2ILInjected.Token(Token = "0x600137D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FD04", Offset = "0xA8FD04", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x00025130 File Offset: 0x00023330
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600137E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8FD1C", Offset = "0xA8FD1C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		static Rectangle()
		{
			throw null;
		}

		// Token: 0x04001C93 RID: 7315
		[global::Cpp2ILInjected.Token(Token = "0x400226D")]
		private static Rectangle emptyRectangle;

		// Token: 0x04001C94 RID: 7316
		[global::Cpp2ILInjected.Token(Token = "0x400226E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int X;

		// Token: 0x04001C95 RID: 7317
		[global::Cpp2ILInjected.Token(Token = "0x400226F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int Y;

		// Token: 0x04001C96 RID: 7318
		[global::Cpp2ILInjected.Token(Token = "0x4002270")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int Width;

		// Token: 0x04001C97 RID: 7319
		[global::Cpp2ILInjected.Token(Token = "0x4002271")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public int Height;
	}
}
