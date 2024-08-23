using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Localization;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000621 RID: 1569
	[global::Cpp2ILInjected.Token(Token = "0x2000944")]
	public class CustomEntryIcon : IEntryIcon
	{
		// Token: 0x06003E90 RID: 16016 RVA: 0x0002D2CF File Offset: 0x0002B4CF
		[global::Cpp2ILInjected.Token(Token = "0x60047A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x81A8CC", Offset = "0x81A8CC", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BestiaryEntry), Member = "Biome", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Func<bool>)
		}, ReturnType = typeof(BestiaryEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomEntryIcon), Member = "CreateClone", ReturnType = typeof(IEntryIcon))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomEntryIcon), Member = "UpdateUnlockState", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CustomEntryIcon(string nameLanguageKey, string texturePath, Func<bool> unlockCondition)
		{
			throw null;
		}

		// Token: 0x06003E91 RID: 16017 RVA: 0x0002D2D2 File Offset: 0x0002B4D2
		[global::Cpp2ILInjected.Token(Token = "0x60047A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x81B94C", Offset = "0x81B94C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Func<bool>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public IEntryIcon CreateClone()
		{
			throw null;
		}

		// Token: 0x06003E92 RID: 16018 RVA: 0x0002D2D5 File Offset: 0x0002B4D5
		[global::Cpp2ILInjected.Token(Token = "0x60047A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x81B9D0", Offset = "0x81B9D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CustomEntryIcon), Member = "UpdateUnlockState", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Update(BestiaryUICollectionInfo providedInfo, Rectangle hitbox, EntryIconDrawSettings settings)
		{
			throw null;
		}

		// Token: 0x06003E93 RID: 16019 RVA: 0x0002D2D8 File Offset: 0x0002B4D8
		[global::Cpp2ILInjected.Token(Token = "0x60047A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x81B9E8", Offset = "0x81B9E8", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Center", ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToVector2", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
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
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Draw(BestiaryUICollectionInfo providedInfo, SpriteBatch spriteBatch, EntryIconDrawSettings settings)
		{
			throw null;
		}

		// Token: 0x06003E94 RID: 16020 RVA: 0x0002D2DB File Offset: 0x0002B4DB
		[global::Cpp2ILInjected.Token(Token = "0x60047A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x81BBE8", Offset = "0x81BBE8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetHoverText(BestiaryUICollectionInfo providedInfo)
		{
			throw null;
		}

		// Token: 0x06003E95 RID: 16021 RVA: 0x0002D2DE File Offset: 0x0002B4DE
		[global::Cpp2ILInjected.Token(Token = "0x60047A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x81B8A0", Offset = "0x81B8A0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomEntryIcon), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Func<bool>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomEntryIcon), Member = "Update", MemberParameters = new object[]
		{
			typeof(BestiaryUICollectionInfo),
			typeof(Rectangle),
			typeof(EntryIconDrawSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Inflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UpdateUnlockState(bool state)
		{
			throw null;
		}

		// Token: 0x06003E96 RID: 16022 RVA: 0x0002D2E1 File Offset: 0x0002B4E1
		[global::Cpp2ILInjected.Token(Token = "0x60047AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x81B9DC", Offset = "0x81B9DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool GetUnlockState(BestiaryUICollectionInfo providedInfo)
		{
			throw null;
		}

		// Token: 0x04006C56 RID: 27734
		[global::Cpp2ILInjected.Token(Token = "0x4008375")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private LocalizedText _text;

		// Token: 0x04006C57 RID: 27735
		[global::Cpp2ILInjected.Token(Token = "0x4008376")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Asset<Texture2D> _textureAsset;

		// Token: 0x04006C58 RID: 27736
		[global::Cpp2ILInjected.Token(Token = "0x4008377")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Rectangle _sourceRectangle;

		// Token: 0x04006C59 RID: 27737
		[global::Cpp2ILInjected.Token(Token = "0x4008378")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Func<bool> _unlockCondition;
	}
}
