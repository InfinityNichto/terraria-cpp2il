using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.DataStructures;
using Terraria.Initializers;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x020006AB RID: 1707
	[global::Cpp2ILInjected.Token(Token = "0x2000A81")]
	public class HorizontalBarsPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x0002E0A6 File Offset: 0x0002C2A6
		// (set) Token: 0x06004352 RID: 17234 RVA: 0x0002E0A9 File Offset: 0x0002C2A9
		[global::Cpp2ILInjected.Token(Token = "0x170008B1")]
		public string NameKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FD3F8", Offset = "0x8FD3F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FD400", Offset = "0x8FD400", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x0002E0AC File Offset: 0x0002C2AC
		// (set) Token: 0x06004354 RID: 17236 RVA: 0x0002E0AF File Offset: 0x0002C2AF
		[global::Cpp2ILInjected.Token(Token = "0x170008B2")]
		public string ConfigKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F80")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FD408", Offset = "0x8FD408", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F81")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FD410", Offset = "0x8FD410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x0002E0B2 File Offset: 0x0002C2B2
		[global::Cpp2ILInjected.Token(Token = "0x6004F82")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FD418", Offset = "0x8FD418", Length = "0x6C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadPlayerResourceSets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager2), Member = "PopulateOptionsAndLoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "LoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public HorizontalBarsPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x0002E0B5 File Offset: 0x0002C2B5
		[global::Cpp2ILInjected.Token(Token = "0x6004F83")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FDAD8", Offset = "0x8FDAD8", Length = "0x80C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "PrepareFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "DrawLifeBarText", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "DrawManaText", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceDrawSettings.TextureGetter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceDrawSettings), Member = "Draw", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		public void Draw()
		{
			throw null;
		}

		// Token: 0x06004357 RID: 17239 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
		[global::Cpp2ILInjected.Token(Token = "0x6004F84")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FE7F8", Offset = "0x8FE7F8", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void DrawManaText(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004358 RID: 17240 RVA: 0x0002E0BB File Offset: 0x0002C2BB
		[global::Cpp2ILInjected.Token(Token = "0x6004F85")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FE38C", Offset = "0x8FE38C", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private static void DrawLifeBarText(SpriteBatch spriteBatch, Vector2 topLeftAnchor)
		{
			throw null;
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0002E0BE File Offset: 0x0002C2BE
		[global::Cpp2ILInjected.Token(Token = "0x6004F86")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FE2E4", Offset = "0x8FE2E4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerStatsSnapshot), Member = ".ctor", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		private void PrepareFields(Player player)
		{
			throw null;
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x0002E0C1 File Offset: 0x0002C2C1
		[global::Cpp2ILInjected.Token(Token = "0x6004F87")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FEB4C", Offset = "0x8FEB4C", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void LifePanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0002E0C4 File Offset: 0x0002C2C4
		[global::Cpp2ILInjected.Token(Token = "0x6004F88")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FEC74", Offset = "0x8FEC74", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ManaPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600435C RID: 17244 RVA: 0x0002E0C7 File Offset: 0x0002C2C7
		[global::Cpp2ILInjected.Token(Token = "0x6004F89")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FED9C", Offset = "0x8FED9C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void LifeFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600435D RID: 17245 RVA: 0x0002E0CA File Offset: 0x0002C2CA
		[global::Cpp2ILInjected.Token(Token = "0x6004F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FEDDC", Offset = "0x8FEDDC", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "ManaFillingDrawer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref Asset<Texture2D>),
			typeof(ref Vector2),
			typeof(ref float),
			typeof(ref Rectangle?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void FillBarByValues(int elementIndex, Asset<Texture2D> sprite, int segmentsCount, float fillPercent, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600435E RID: 17246 RVA: 0x0002E0CD File Offset: 0x0002C2CD
		[global::Cpp2ILInjected.Token(Token = "0x6004F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FEFD0", Offset = "0x8FEFD0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "FillBarByValues", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(float),
			typeof(ref Vector2),
			typeof(ref float),
			typeof(ref Rectangle?)
		}, ReturnType = typeof(void))]
		private void ManaFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x0002E0D0 File Offset: 0x0002C2D0
		[global::Cpp2ILInjected.Token(Token = "0x6004F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FEFF8", Offset = "0x8FEFF8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawLifeMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawManaMouseOver", ReturnType = typeof(void))]
		public void TryToHover()
		{
			throw null;
		}

		// Token: 0x04006F4D RID: 28493
		[global::Cpp2ILInjected.Token(Token = "0x400886E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _maxSegmentCount;

		// Token: 0x04006F4E RID: 28494
		[global::Cpp2ILInjected.Token(Token = "0x400886F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _hpSegmentsCount;

		// Token: 0x04006F4F RID: 28495
		[global::Cpp2ILInjected.Token(Token = "0x4008870")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _mpSegmentsCount;

		// Token: 0x04006F50 RID: 28496
		[global::Cpp2ILInjected.Token(Token = "0x4008871")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _hpFruitCount;

		// Token: 0x04006F51 RID: 28497
		[global::Cpp2ILInjected.Token(Token = "0x4008872")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private float _hpPercent;

		// Token: 0x04006F52 RID: 28498
		[global::Cpp2ILInjected.Token(Token = "0x4008873")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private float _mpPercent;

		// Token: 0x04006F53 RID: 28499
		[global::Cpp2ILInjected.Token(Token = "0x4008874")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte _drawTextStyle;

		// Token: 0x04006F54 RID: 28500
		[global::Cpp2ILInjected.Token(Token = "0x4008875")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _hpHovered;

		// Token: 0x04006F55 RID: 28501
		[global::Cpp2ILInjected.Token(Token = "0x4008876")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		private bool _mpHovered;

		// Token: 0x04006F56 RID: 28502
		[global::Cpp2ILInjected.Token(Token = "0x4008877")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Asset<Texture2D> _hpFill;

		// Token: 0x04006F57 RID: 28503
		[global::Cpp2ILInjected.Token(Token = "0x4008878")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Asset<Texture2D> _hpFillHoney;

		// Token: 0x04006F58 RID: 28504
		[global::Cpp2ILInjected.Token(Token = "0x4008879")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _mpFill;

		// Token: 0x04006F59 RID: 28505
		[global::Cpp2ILInjected.Token(Token = "0x400887A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _panelLeft;

		// Token: 0x04006F5A RID: 28506
		[global::Cpp2ILInjected.Token(Token = "0x400887B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Asset<Texture2D> _panelMiddleHP;

		// Token: 0x04006F5B RID: 28507
		[global::Cpp2ILInjected.Token(Token = "0x400887C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Asset<Texture2D> _panelRightHP;

		// Token: 0x04006F5C RID: 28508
		[global::Cpp2ILInjected.Token(Token = "0x400887D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Asset<Texture2D> _panelMiddleMP;

		// Token: 0x04006F5D RID: 28509
		[global::Cpp2ILInjected.Token(Token = "0x400887E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Asset<Texture2D> _panelRightMP;

		// Token: 0x04006F5E RID: 28510
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400887F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string <NameKey>k__BackingField;

		// Token: 0x04006F5F RID: 28511
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008880")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private string <ConfigKey>k__BackingField;
	}
}
