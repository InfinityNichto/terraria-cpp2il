using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005A4 RID: 1444
	[global::Cpp2ILInjected.Token(Token = "0x2000842")]
	public abstract class AHoverInteractionChecker
	{
		// Token: 0x06003BEC RID: 15340 RVA: 0x0002CB55 File Offset: 0x0002AD55
		[global::Cpp2ILInjected.Token(Token = "0x600430F")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E080", Offset = "0x79E080", Length = "0x4D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReturnGatePlayerRenderer), Member = "DrawReturnGateInWorld", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ClosestPointInRect", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileReachCheckSettings), Member = "get_Simple", ReturnType = typeof(TileReachCheckSettings))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "IsInTileInteractionRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileReachCheckSettings)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteViewMatrix), Member = "get_ZoomMatrix", ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix), Member = "Invert", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "ReverseGravitySupport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Transform", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Matrix)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SmartCursorIsUsed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "get_UsingGamepad", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "GamepadEnableGrappleCooldown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRight", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_mouseRightRelease", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mouseRightRelease", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal AHoverInteractionChecker.HoverStatus AttemptInteraction(Player player, Rectangle Hitbox)
		{
			throw null;
		}

		// Token: 0x06003BED RID: 15341
		[global::Cpp2ILInjected.Token(Token = "0x6004310")]
		internal abstract bool? AttemptOverridingHoverStatus(Player player, Rectangle rectangle);

		// Token: 0x06003BEE RID: 15342
		[global::Cpp2ILInjected.Token(Token = "0x6004311")]
		internal abstract void DoHoverEffect(Player player, Rectangle hitbox);

		// Token: 0x06003BEF RID: 15343
		[global::Cpp2ILInjected.Token(Token = "0x6004312")]
		internal abstract bool ShouldBlockInteraction(Player player, Rectangle hitbox);

		// Token: 0x06003BF0 RID: 15344
		[global::Cpp2ILInjected.Token(Token = "0x6004313")]
		internal abstract void PerformInteraction(Player player, Rectangle hitbox);

		// Token: 0x06003BF1 RID: 15345 RVA: 0x0002CB58 File Offset: 0x0002AD58
		[global::Cpp2ILInjected.Token(Token = "0x6004314")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E554", Offset = "0x79E554", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AHoverInteractionChecker()
		{
			throw null;
		}

		// Token: 0x020009A9 RID: 2473
		[global::Cpp2ILInjected.Token(Token = "0x2000843")]
		internal enum HoverStatus
		{
			// Token: 0x04008CB3 RID: 36019
			[global::Cpp2ILInjected.Token(Token = "0x4008140")]
			NotSelectable,
			// Token: 0x04008CB4 RID: 36020
			[global::Cpp2ILInjected.Token(Token = "0x4008141")]
			SelectableButNotSelected,
			// Token: 0x04008CB5 RID: 36021
			[global::Cpp2ILInjected.Token(Token = "0x4008142")]
			Selected
		}
	}
}
