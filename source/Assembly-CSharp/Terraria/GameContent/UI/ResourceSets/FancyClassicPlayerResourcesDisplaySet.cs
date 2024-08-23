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
	// Token: 0x020006AA RID: 1706
	[global::Cpp2ILInjected.Token(Token = "0x2000A80")]
	public class FancyClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06004341 RID: 17217 RVA: 0x0002E076 File Offset: 0x0002C276
		// (set) Token: 0x06004342 RID: 17218 RVA: 0x0002E079 File Offset: 0x0002C279
		[global::Cpp2ILInjected.Token(Token = "0x170008AF")]
		public string NameKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F6E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FB15C", Offset = "0x8FB15C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F6F")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FB164", Offset = "0x8FB164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06004343 RID: 17219 RVA: 0x0002E07C File Offset: 0x0002C27C
		// (set) Token: 0x06004344 RID: 17220 RVA: 0x0002E07F File Offset: 0x0002C27F
		[global::Cpp2ILInjected.Token(Token = "0x170008B0")]
		public string ConfigKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F70")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FB16C", Offset = "0x8FB16C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F71")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FB174", Offset = "0x8FB174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x0002E082 File Offset: 0x0002C282
		[global::Cpp2ILInjected.Token(Token = "0x6004F72")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FB17C", Offset = "0x8FB17C", Length = "0x944")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadPlayerResourceSets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager2), Member = "PopulateOptionsAndLoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "LoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 41)]
		public FancyClassicPlayerResourcesDisplaySet(string nameKey, string configKey, string resourceFolderName, AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x0002E085 File Offset: 0x0002C285
		[global::Cpp2ILInjected.Token(Token = "0x6004F73")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FBAC0", Offset = "0x8FBAC0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "PrepareFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "DrawLifeBar", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "DrawManaBar", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Draw()
		{
			throw null;
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x0002E088 File Offset: 0x0002C288
		[global::Cpp2ILInjected.Token(Token = "0x6004F74")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FBCD8", Offset = "0x8FBCD8", Length = "0x728")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "DrawLifeBarText", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		private void DrawLifeBar(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x0002E08B File Offset: 0x0002C28B
		[global::Cpp2ILInjected.Token(Token = "0x6004F75")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FC7C0", Offset = "0x8FC7C0", Length = "0x46C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "DrawLifeBar", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
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

		// Token: 0x06004349 RID: 17225 RVA: 0x0002E08E File Offset: 0x0002C28E
		[global::Cpp2ILInjected.Token(Token = "0x6004F76")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FC400", Offset = "0x8FC400", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private void DrawManaBar(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0002E091 File Offset: 0x0002C291
		[global::Cpp2ILInjected.Token(Token = "0x6004F77")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FCC2C", Offset = "0x8FCC2C", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void DrawManaText(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x0002E094 File Offset: 0x0002C294
		[global::Cpp2ILInjected.Token(Token = "0x6004F78")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FCE30", Offset = "0x8FCE30", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void HeartPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x0002E097 File Offset: 0x0002C297
		[global::Cpp2ILInjected.Token(Token = "0x6004F79")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FCF88", Offset = "0x8FCF88", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void HeartFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x0002E09A File Offset: 0x0002C29A
		[global::Cpp2ILInjected.Token(Token = "0x6004F7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FD11C", Offset = "0x8FD11C", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void StarPanelDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x0002E09D File Offset: 0x0002C29D
		[global::Cpp2ILInjected.Token(Token = "0x6004F7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FD254", Offset = "0x8FD254", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void StarFillingDrawer(int elementIndex, int firstElementIndex, int lastElementIndex, out Asset<Texture2D> sprite, out Vector2 offset, out float drawScale, out Rectangle? sourceRect)
		{
			throw null;
		}

		// Token: 0x0600434F RID: 17231 RVA: 0x0002E0A0 File Offset: 0x0002C2A0
		[global::Cpp2ILInjected.Token(Token = "0x6004F7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FBB44", Offset = "0x8FBB44", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerStatsSnapshot), Member = ".ctor", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void PrepareFields(Player player)
		{
			throw null;
		}

		// Token: 0x06004350 RID: 17232 RVA: 0x0002E0A3 File Offset: 0x0002C2A3
		[global::Cpp2ILInjected.Token(Token = "0x6004F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FD3CC", Offset = "0x8FD3CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawLifeMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawManaMouseOver", ReturnType = typeof(void))]
		public void TryToHover()
		{
			throw null;
		}

		// Token: 0x04006F31 RID: 28465
		[global::Cpp2ILInjected.Token(Token = "0x4008852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float _currentPlayerLife;

		// Token: 0x04006F32 RID: 28466
		[global::Cpp2ILInjected.Token(Token = "0x4008853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float _lifePerHeart;

		// Token: 0x04006F33 RID: 28467
		[global::Cpp2ILInjected.Token(Token = "0x4008854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _playerLifeFruitCount;

		// Token: 0x04006F34 RID: 28468
		[global::Cpp2ILInjected.Token(Token = "0x4008855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _lastHeartFillingIndex;

		// Token: 0x04006F35 RID: 28469
		[global::Cpp2ILInjected.Token(Token = "0x4008856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _lastHeartPanelIndex;

		// Token: 0x04006F36 RID: 28470
		[global::Cpp2ILInjected.Token(Token = "0x4008857")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _heartCountRow1;

		// Token: 0x04006F37 RID: 28471
		[global::Cpp2ILInjected.Token(Token = "0x4008858")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _heartCountRow2;

		// Token: 0x04006F38 RID: 28472
		[global::Cpp2ILInjected.Token(Token = "0x4008859")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _starCount;

		// Token: 0x04006F39 RID: 28473
		[global::Cpp2ILInjected.Token(Token = "0x400885A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _lastStarFillingIndex;

		// Token: 0x04006F3A RID: 28474
		[global::Cpp2ILInjected.Token(Token = "0x400885B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float _manaPerStar;

		// Token: 0x04006F3B RID: 28475
		[global::Cpp2ILInjected.Token(Token = "0x400885C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float _currentPlayerMana;

		// Token: 0x04006F3C RID: 28476
		[global::Cpp2ILInjected.Token(Token = "0x400885D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _heartLeft;

		// Token: 0x04006F3D RID: 28477
		[global::Cpp2ILInjected.Token(Token = "0x400885E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _heartMiddle;

		// Token: 0x04006F3E RID: 28478
		[global::Cpp2ILInjected.Token(Token = "0x400885F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Asset<Texture2D> _heartRight;

		// Token: 0x04006F3F RID: 28479
		[global::Cpp2ILInjected.Token(Token = "0x4008860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Asset<Texture2D> _heartRightFancy;

		// Token: 0x04006F40 RID: 28480
		[global::Cpp2ILInjected.Token(Token = "0x4008861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Asset<Texture2D> _heartFill;

		// Token: 0x04006F41 RID: 28481
		[global::Cpp2ILInjected.Token(Token = "0x4008862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Asset<Texture2D> _heartFillHoney;

		// Token: 0x04006F42 RID: 28482
		[global::Cpp2ILInjected.Token(Token = "0x4008863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Asset<Texture2D> _heartSingleFancy;

		// Token: 0x04006F43 RID: 28483
		[global::Cpp2ILInjected.Token(Token = "0x4008864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Asset<Texture2D> _starTop;

		// Token: 0x04006F44 RID: 28484
		[global::Cpp2ILInjected.Token(Token = "0x4008865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Asset<Texture2D> _starMiddle;

		// Token: 0x04006F45 RID: 28485
		[global::Cpp2ILInjected.Token(Token = "0x4008866")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Asset<Texture2D> _starBottom;

		// Token: 0x04006F46 RID: 28486
		[global::Cpp2ILInjected.Token(Token = "0x4008867")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Asset<Texture2D> _starSingle;

		// Token: 0x04006F47 RID: 28487
		[global::Cpp2ILInjected.Token(Token = "0x4008868")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Asset<Texture2D> _starFill;

		// Token: 0x04006F48 RID: 28488
		[global::Cpp2ILInjected.Token(Token = "0x4008869")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool _hoverLife;

		// Token: 0x04006F49 RID: 28489
		[global::Cpp2ILInjected.Token(Token = "0x400886A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
		private bool _hoverMana;

		// Token: 0x04006F4A RID: 28490
		[global::Cpp2ILInjected.Token(Token = "0x400886B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
		private bool _drawText;

		// Token: 0x04006F4B RID: 28491
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400886C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string <NameKey>k__BackingField;

		// Token: 0x04006F4C RID: 28492
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400886D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string <ConfigKey>k__BackingField;
	}
}
