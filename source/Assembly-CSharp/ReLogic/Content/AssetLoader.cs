using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Content.Sources;
using Terraria.Initializers;

namespace ReLogic.Content
{
	// Token: 0x0200073A RID: 1850
	[global::Cpp2ILInjected.Token(Token = "0x2000B3A")]
	public class AssetLoader : IAssetLoader
	{
		// Token: 0x06004718 RID: 18200 RVA: 0x0002EB4A File Offset: 0x0002CD4A
		[global::Cpp2ILInjected.Token(Token = "0x60053D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x945A7C", Offset = "0x945A7C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "CreateAssetServices", MemberParameters = new object[] { typeof(GameServiceContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public AssetLoader(AssetReaderCollection readers)
		{
			throw null;
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x0002EB4D File Offset: 0x0002CD4D
		[global::Cpp2ILInjected.Token(Token = "0x60053D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15719A8", Offset = "0x15719A8", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetReaderCollection), Member = "CanReadExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryLoad<T>(string assetName, IContentSource source, out T resultAsset) where T : class
		{
			throw null;
		}

		// Token: 0x04007357 RID: 29527
		[global::Cpp2ILInjected.Token(Token = "0x4008CF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly AssetReaderCollection _readers;
	}
}
