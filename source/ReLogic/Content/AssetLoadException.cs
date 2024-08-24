using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content.Sources;

namespace ReLogic.Content
{
	// Token: 0x0200073F RID: 1855
	[global::Cpp2ILInjected.Token(Token = "0x2000B3F")]
	[Serializable]
	public class AssetLoadException : Exception
	{
		// Token: 0x06004723 RID: 18211 RVA: 0x0002EB65 File Offset: 0x0002CD65
		[global::Cpp2ILInjected.Token(Token = "0x60053DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x945EB0", Offset = "0x945EB0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetLoadException), Member = "FromInvalidReader", MemberTypeParameters = new object[] { "TReaderType", "TAssetType" }, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetLoadException), Member = "FromMissingReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private AssetLoadException(string text, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06004724 RID: 18212 RVA: 0x0002EB68 File Offset: 0x0002CD68
		[global::Cpp2ILInjected.Token(Token = "0x60053DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x945F20", Offset = "0x945F20", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "FindSourceForAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IContentSource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileSystemContentSource), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaContentSource), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XnaDirectContentSource), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static AssetLoadException FromMissingAsset(string assetName, Exception innerException = null)
		{
			throw null;
		}

		// Token: 0x06004725 RID: 18213 RVA: 0x0002EB6B File Offset: 0x0002CD6B
		[global::Cpp2ILInjected.Token(Token = "0x60053DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x15718A4", Offset = "0x15718A4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static AssetLoadException FromInvalidReader<TReaderType, TAssetType>()
		{
			throw null;
		}

		// Token: 0x06004726 RID: 18214 RVA: 0x0002EB6E File Offset: 0x0002CD6E
		[global::Cpp2ILInjected.Token(Token = "0x60053DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x945FB4", Offset = "0x945FB4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetReaderCollection), Member = "Read", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(string)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static AssetLoadException FromMissingReader(string extension)
		{
			throw null;
		}
	}
}
