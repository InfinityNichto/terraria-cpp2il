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
	// Token: 0x020006A8 RID: 1704
	[global::Cpp2ILInjected.Token(Token = "0x2000A7E")]
	public class ClassicPlayerResourcesDisplaySet : IPlayerResourcesDisplaySet, IConfigKeyHolder
	{
		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06004335 RID: 17205 RVA: 0x0002E052 File Offset: 0x0002C252
		// (set) Token: 0x06004336 RID: 17206 RVA: 0x0002E055 File Offset: 0x0002C255
		[global::Cpp2ILInjected.Token(Token = "0x170008AD")]
		public string NameKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F62")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9B94", Offset = "0x8F9B94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F63")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9B9C", Offset = "0x8F9B9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x0002E058 File Offset: 0x0002C258
		// (set) Token: 0x06004338 RID: 17208 RVA: 0x0002E05B File Offset: 0x0002C25B
		[global::Cpp2ILInjected.Token(Token = "0x170008AE")]
		public string ConfigKey
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F64")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9BA4", Offset = "0x8F9BA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F65")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9BAC", Offset = "0x8F9BAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x0002E05E File Offset: 0x0002C25E
		[global::Cpp2ILInjected.Token(Token = "0x6004F66")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9BB4", Offset = "0x8F9BB4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadPlayerResourceSets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager2), Member = "PopulateOptionsAndLoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "LoadContent", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ClassicPlayerResourcesDisplaySet(string nameKey, string configKey)
		{
			throw null;
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x0002E061 File Offset: 0x0002C261
		[global::Cpp2ILInjected.Token(Token = "0x6004F67")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9BEC", Offset = "0x8F9BEC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = "DrawLife", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = "DrawMana", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Draw()
		{
			throw null;
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x0002E064 File Offset: 0x0002C264
		[global::Cpp2ILInjected.Token(Token = "0x6004F68")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9C58", Offset = "0x8F9C58", Length = "0xB78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private void DrawLife()
		{
			throw null;
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x0002E067 File Offset: 0x0002C267
		[global::Cpp2ILInjected.Token(Token = "0x6004F69")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FA7D0", Offset = "0x8FA7D0", Length = "0x5C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_cursorScale", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void DrawMana()
		{
			throw null;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x0002E06A File Offset: 0x0002C26A
		[global::Cpp2ILInjected.Token(Token = "0x6004F6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FAD90", Offset = "0x8FAD90", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalPlayer", ReturnType = typeof(Player))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawLifeMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CommonResourceBarMethods), Member = "DrawManaMouseOver", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void TryToHover()
		{
			throw null;
		}

		// Token: 0x04006F2C RID: 28460
		[global::Cpp2ILInjected.Token(Token = "0x400884D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int UIDisplay_ManaPerStar;

		// Token: 0x04006F2D RID: 28461
		[global::Cpp2ILInjected.Token(Token = "0x400884E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float UIDisplay_LifePerHeart;

		// Token: 0x04006F2E RID: 28462
		[global::Cpp2ILInjected.Token(Token = "0x400884F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int UI_ScreenAnchorX;

		// Token: 0x04006F2F RID: 28463
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008850")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <NameKey>k__BackingField;

		// Token: 0x04006F30 RID: 28464
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008851")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string <ConfigKey>k__BackingField;
	}
}
