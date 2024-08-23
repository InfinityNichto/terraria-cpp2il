using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x0200009A RID: 154
	[NativeHeader("Runtime/Scripting/TextAsset.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000A8")]
	public class TextAsset : Object
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002FD RID: 765
		[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
		public extern byte[] bytes
		{
			[global::Cpp2ILInjected.Token(Token = "0x600030B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7B800", Offset = "0x1F7B800", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CSVReader", Member = "Begin", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadReleaseLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TextureAtlasDB", Member = "Load", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "LoadSpriteFont", MemberParameters = new object[] { typeof(string) }, ReturnType = "Microsoft.Xna.Framework.Graphics.SpriteFont")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "LoadTutorialPlayer", ReturnType = "Terraria.IO.PlayerFileData")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "GetTutorialMetadata", ReturnType = "Terraria.IO.WorldFileData")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "LoadTutorialOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00002638 File Offset: 0x00000838
		[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
		public string text
		{
			[global::Cpp2ILInjected.Token(Token = "0x600030C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7B83C", Offset = "0x1F7B83C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.TitleContainer", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldBuilding.WorldGenConfiguration", Member = "LoadOnMainThread", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "LoadFilesForCulture", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Metadata.TileMaterials", Member = "DeserializeEmbeddedResource", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Creative.CreativeItemSacrificesCatalog", Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextAsset), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000263B File Offset: 0x0000083B
		[global::Cpp2ILInjected.Token(Token = "0x600030D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7BA6C", Offset = "0x1F7BA6C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000263E File Offset: 0x0000083E
		[global::Cpp2ILInjected.Token(Token = "0x600030E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B87C", Offset = "0x1F7B87C", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static string DecodeString(byte[] bytes)
		{
			throw null;
		}

		// Token: 0x0200016E RID: 366
		[global::Cpp2ILInjected.Token(Token = "0x20000A9")]
		private static class EncodingUtility
		{
			// Token: 0x060006C2 RID: 1730 RVA: 0x00002F92 File Offset: 0x00001192
			[global::Cpp2ILInjected.Token(Token = "0x600030F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7BA70", Offset = "0x1F7BA70", Length = "0x31C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EncoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(int),
				typeof(EncoderFallback),
				typeof(DecoderFallback)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF32Encoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnicodeEncoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyValuePair<object, object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			static EncodingUtility()
			{
				throw null;
			}

			// Token: 0x04000660 RID: 1632
			[global::Cpp2ILInjected.Token(Token = "0x4000366")]
			internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

			// Token: 0x04000661 RID: 1633
			[global::Cpp2ILInjected.Token(Token = "0x4000367")]
			internal static readonly Encoding targetEncoding;
		}
	}
}
