using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content.Readers;
using ReLogic.Content.Sources;
using Terraria.Initializers;
using Terraria.IO;

namespace ReLogic.Content
{
	// Token: 0x02000741 RID: 1857
	[global::Cpp2ILInjected.Token(Token = "0x2000B41")]
	public class AssetReaderCollection
	{
		// Token: 0x06004729 RID: 18217 RVA: 0x0002EB77 File Offset: 0x0002CD77
		[global::Cpp2ILInjected.Token(Token = "0x60053E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x9460F8", Offset = "0x9460F8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RegisterReader(IAssetReader reader, params string[] extensions)
		{
			throw null;
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0002EB7A File Offset: 0x0002CD7A
		[global::Cpp2ILInjected.Token(Token = "0x60053E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1571B18", Offset = "0x1571B18", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "CreateIcon", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T Read<T>(Stream stream, string extension) where T : class
		{
			throw null;
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0002EB7D File Offset: 0x0002CD7D
		[global::Cpp2ILInjected.Token(Token = "0x60053E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x946198", Offset = "0x946198", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetLoader), Member = "TryLoad", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(IContentSource),
			"T&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool CanReadExtension(string extension)
		{
			throw null;
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0002EB80 File Offset: 0x0002CD80
		[global::Cpp2ILInjected.Token(Token = "0x60053E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x946200", Offset = "0x946200", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "CreateAssetServices", MemberParameters = new object[] { typeof(GameServiceContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public AssetReaderCollection()
		{
			throw null;
		}

		// Token: 0x04007359 RID: 29529
		[global::Cpp2ILInjected.Token(Token = "0x4008CF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IAssetReader> _readersByExtension;
	}
}
