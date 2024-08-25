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
	[global::Cpp2ILInjected.Token(Token = "0x2000A80")]
	public class FancyClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6004F7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FD3CC", Offset = "0x8FD3CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawLifeMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawManaMouseOver", ReturnType = typeof(void))]
		public void TryToHover()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008852")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float _currentPlayerLife;

		[global::Cpp2ILInjected.Token(Token = "0x4008853")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float _lifePerHeart;

		[global::Cpp2ILInjected.Token(Token = "0x4008854")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _playerLifeFruitCount;

		[global::Cpp2ILInjected.Token(Token = "0x4008855")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _lastHeartFillingIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4008856")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _lastHeartPanelIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4008857")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _heartCountRow1;

		[global::Cpp2ILInjected.Token(Token = "0x4008858")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int _heartCountRow2;

		[global::Cpp2ILInjected.Token(Token = "0x4008859")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int _starCount;

		[global::Cpp2ILInjected.Token(Token = "0x400885A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _lastStarFillingIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400885B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float _manaPerStar;

		[global::Cpp2ILInjected.Token(Token = "0x400885C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float _currentPlayerMana;

		[global::Cpp2ILInjected.Token(Token = "0x400885D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Asset<Texture2D> _heartLeft;

		[global::Cpp2ILInjected.Token(Token = "0x400885E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Asset<Texture2D> _heartMiddle;

		[global::Cpp2ILInjected.Token(Token = "0x400885F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Asset<Texture2D> _heartRight;

		[global::Cpp2ILInjected.Token(Token = "0x4008860")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Asset<Texture2D> _heartRightFancy;

		[global::Cpp2ILInjected.Token(Token = "0x4008861")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Asset<Texture2D> _heartFill;

		[global::Cpp2ILInjected.Token(Token = "0x4008862")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Asset<Texture2D> _heartFillHoney;

		[global::Cpp2ILInjected.Token(Token = "0x4008863")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private Asset<Texture2D> _heartSingleFancy;

		[global::Cpp2ILInjected.Token(Token = "0x4008864")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Asset<Texture2D> _starTop;

		[global::Cpp2ILInjected.Token(Token = "0x4008865")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Asset<Texture2D> _starMiddle;

		[global::Cpp2ILInjected.Token(Token = "0x4008866")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Asset<Texture2D> _starBottom;

		[global::Cpp2ILInjected.Token(Token = "0x4008867")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Asset<Texture2D> _starSingle;

		[global::Cpp2ILInjected.Token(Token = "0x4008868")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Asset<Texture2D> _starFill;

		[global::Cpp2ILInjected.Token(Token = "0x4008869")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool _hoverLife;

		[global::Cpp2ILInjected.Token(Token = "0x400886A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
		private bool _hoverMana;

		[global::Cpp2ILInjected.Token(Token = "0x400886B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA2")]
		private bool _drawText;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400886C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string <NameKey>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400886D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string <ConfigKey>k__BackingField;
	}
}
