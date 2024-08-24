using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Localization;

namespace Terraria.GameContent.UI
{
	// Token: 0x020006A0 RID: 1696
	[global::Cpp2ILInjected.Token(Token = "0x2000A64")]
	public class NewMultiplayerClosePlayersOverlay : IMultiplayerClosePlayersOverlay
	{
		// Token: 0x0600428C RID: 17036 RVA: 0x0002DE57 File Offset: 0x0002C057
		[global::Cpp2ILInjected.Token(Token = "0x6004E8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E4428", Offset = "0x8E4428", Length = "0xA20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "SetZoom_World", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput), Member = "SetZoom_UI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "GetDistance", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Vector2),
			typeof(Player),
			typeof(SpriteFont),
			typeof(Player),
			typeof(string),
			typeof(ref Vector2),
			typeof(ref float),
			typeof(ref Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "Distance", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetTextValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(Vector2),
			typeof(string),
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache), Member = "DrawPlayerName_WhenPlayerIsOnScreen", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache), Member = "DrawPlayerName", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache), Member = "DrawPlayerDistance", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache), Member = "DrawLifeBar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache), Member = "DrawPlayerHead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public void Draw()
		{
			throw null;
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x0002DE5A File Offset: 0x0002C05A
		[global::Cpp2ILInjected.Token(Token = "0x6004E8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E4E48", Offset = "0x8E4E48", Length = "0x4A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAUnityRunner), Member = "AdjustWorldPositionForUI", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void GetDistance(int testWidth, int testHeight, Vector2 testPosition, Player localPlayer, SpriteFont font, Player player, string nameToShow, out Vector2 namePlatePos, out float namePlateDist, out Vector2 measurement)
		{
			throw null;
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x0002DE5D File Offset: 0x0002C05D
		[global::Cpp2ILInjected.Token(Token = "0x6004E8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8E5F18", Offset = "0x8E5F18", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public NewMultiplayerClosePlayersOverlay()
		{
			throw null;
		}

		// Token: 0x04006ECA RID: 28362
		[global::Cpp2ILInjected.Token(Token = "0x40087A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<NewMultiplayerClosePlayersOverlay.PlayerOnScreenCache> _playerOnScreenCache;

		// Token: 0x04006ECB RID: 28363
		[global::Cpp2ILInjected.Token(Token = "0x40087A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<NewMultiplayerClosePlayersOverlay.PlayerOffScreenCache> _playerOffScreenCache;

		// Token: 0x02000AA1 RID: 2721
		[global::Cpp2ILInjected.Token(Token = "0x2000A65")]
		private struct PlayerOnScreenCache
		{
			// Token: 0x0600522B RID: 21035 RVA: 0x000307EB File Offset: 0x0002E9EB
			[global::Cpp2ILInjected.Token(Token = "0x6004E8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E53CC", Offset = "0x8E53CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public PlayerOnScreenCache(string name, Vector2 pos, Color color)
			{
				throw null;
			}

			// Token: 0x0600522C RID: 21036 RVA: 0x000307EE File Offset: 0x0002E9EE
			[global::Cpp2ILInjected.Token(Token = "0x6004E8F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E53DC", Offset = "0x8E53DC", Length = "0x2D4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void DrawPlayerName_WhenPlayerIsOnScreen(SpriteBatch spriteBatch)
			{
				throw null;
			}

			// Token: 0x04008EF1 RID: 36593
			[global::Cpp2ILInjected.Token(Token = "0x40087AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private string _name;

			// Token: 0x04008EF2 RID: 36594
			[global::Cpp2ILInjected.Token(Token = "0x40087AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private Vector2 _pos;

			// Token: 0x04008EF3 RID: 36595
			[global::Cpp2ILInjected.Token(Token = "0x40087AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Color _color;
		}

		// Token: 0x02000AA2 RID: 2722
		[global::Cpp2ILInjected.Token(Token = "0x2000A66")]
		private struct PlayerOffScreenCache
		{
			// Token: 0x0600522D RID: 21037 RVA: 0x000307F1 File Offset: 0x0002E9F1
			[global::Cpp2ILInjected.Token(Token = "0x6004E90")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E52F0", Offset = "0x8E52F0", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public PlayerOffScreenCache(string name, Vector2 pos, Color color, Vector2 npDistPos, string npDist, Player thePlayer, Vector2 theMeasurement)
			{
				throw null;
			}

			// Token: 0x0600522E RID: 21038 RVA: 0x000307F4 File Offset: 0x0002E9F4
			[global::Cpp2ILInjected.Token(Token = "0x6004E91")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E56B0", Offset = "0x8E56B0", Length = "0x304")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public void DrawPlayerName(SpriteBatch spriteBatch)
			{
				throw null;
			}

			// Token: 0x0600522F RID: 21039 RVA: 0x000307F7 File Offset: 0x0002E9F7
			[global::Cpp2ILInjected.Token(Token = "0x6004E92")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E5D58", Offset = "0x8E5D58", Length = "0x1C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetPlayerHeadBordersColor", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Floor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public void DrawPlayerHead()
			{
				throw null;
			}

			// Token: 0x06005230 RID: 21040 RVA: 0x000307FA File Offset: 0x0002E9FA
			[global::Cpp2ILInjected.Token(Token = "0x6004E93")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E5C50", Offset = "0x8E5C50", Length = "0x108")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "DrawHealthBar", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public void DrawLifeBar()
			{
				throw null;
			}

			// Token: 0x06005231 RID: 21041 RVA: 0x000307FD File Offset: 0x0002E9FD
			[global::Cpp2ILInjected.Token(Token = "0x6004E94")]
			[global::Cpp2ILInjected.Address(RVA = "0x8E59B4", Offset = "0x8E59B4", Length = "0x29C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NewMultiplayerClosePlayersOverlay), Member = "Draw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "DrawString", MemberParameters = new object[]
			{
				typeof(SpriteFont),
				typeof(string),
				typeof(Vector2),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public void DrawPlayerDistance(SpriteBatch spriteBatch)
			{
				throw null;
			}

			// Token: 0x04008EF4 RID: 36596
			[global::Cpp2ILInjected.Token(Token = "0x40087AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private Player player;

			// Token: 0x04008EF5 RID: 36597
			[global::Cpp2ILInjected.Token(Token = "0x40087AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private string nameToShow;

			// Token: 0x04008EF6 RID: 36598
			[global::Cpp2ILInjected.Token(Token = "0x40087AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Vector2 namePlatePos;

			// Token: 0x04008EF7 RID: 36599
			[global::Cpp2ILInjected.Token(Token = "0x40087B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private Color namePlateColor;

			// Token: 0x04008EF8 RID: 36600
			[global::Cpp2ILInjected.Token(Token = "0x40087B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private Vector2 distanceDrawPosition;

			// Token: 0x04008EF9 RID: 36601
			[global::Cpp2ILInjected.Token(Token = "0x40087B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string distanceString;

			// Token: 0x04008EFA RID: 36602
			[global::Cpp2ILInjected.Token(Token = "0x40087B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Vector2 measurement;
		}
	}
}
