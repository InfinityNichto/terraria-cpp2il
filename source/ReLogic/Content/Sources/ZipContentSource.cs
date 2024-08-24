using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zip;
using Terraria.IO;

namespace ReLogic.Content.Sources
{
	// Token: 0x0200074F RID: 1871
	[global::Cpp2ILInjected.Token(Token = "0x2000B51")]
	public class ZipContentSource : IContentSource, IDisposable
	{
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06004789 RID: 18313 RVA: 0x0002EC37 File Offset: 0x0002CE37
		[global::Cpp2ILInjected.Token(Token = "0x1700092A")]
		public int EntryCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005447")]
			[global::Cpp2ILInjected.Address(RVA = "0x9486AC", Offset = "0x9486AC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x0002EC3A File Offset: 0x0002CE3A
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x0002EC3D File Offset: 0x0002CE3D
		[global::Cpp2ILInjected.Token(Token = "0x1700092B")]
		public IContentValidator ContentValidator
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005448")]
			[global::Cpp2ILInjected.Address(RVA = "0x9486F4", Offset = "0x9486F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6005449")]
			[global::Cpp2ILInjected.Address(RVA = "0x9486FC", Offset = "0x9486FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x0002EC40 File Offset: 0x0002CE40
		[global::Cpp2ILInjected.Token(Token = "0x600544A")]
		[global::Cpp2ILInjected.Address(RVA = "0x948704", Offset = "0x948704", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ZipContentSource(string path)
		{
			throw null;
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x0002EC43 File Offset: 0x0002CE43
		[global::Cpp2ILInjected.Token(Token = "0x600544B")]
		[global::Cpp2ILInjected.Address(RVA = "0x94875C", Offset = "0x94875C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "GetContentSource", ReturnType = typeof(IContentSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContentSource), Member = "ZipPathContainsInvalidCharacters", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContentSource), Member = "CleanZipPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContentSource), Member = "BuildExtensionFreeEntryList", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public ZipContentSource(string path, string contentDir)
		{
			throw null;
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x0002EC46 File Offset: 0x0002CE46
		[global::Cpp2ILInjected.Token(Token = "0x600544C")]
		[global::Cpp2ILInjected.Address(RVA = "0x948E78", Offset = "0x948E78", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "IsRejected", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool HasAsset(string assetName)
		{
			throw null;
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x0002EC49 File Offset: 0x0002CE49
		[global::Cpp2ILInjected.Token(Token = "0x600544D")]
		[global::Cpp2ILInjected.Address(RVA = "0x948EFC", Offset = "0x948EFC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public string GetExtension(string assetName)
		{
			throw null;
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x0002EC4C File Offset: 0x0002CE4C
		[global::Cpp2ILInjected.Token(Token = "0x600544E")]
		[global::Cpp2ILInjected.Address(RVA = "0x948FE4", Offset = "0x948FE4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Extract", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Stream OpenStream(string assetName)
		{
			throw null;
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x0002EC4F File Offset: 0x0002CE4F
		[global::Cpp2ILInjected.Token(Token = "0x600544F")]
		[global::Cpp2ILInjected.Address(RVA = "0x948A50", Offset = "0x948A50", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Entries", ReturnType = typeof(ICollection<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private void BuildExtensionFreeEntryList()
		{
			throw null;
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x0002EC52 File Offset: 0x0002CE52
		[global::Cpp2ILInjected.Token(Token = "0x6005450")]
		[global::Cpp2ILInjected.Address(RVA = "0x9488C8", Offset = "0x9488C8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool ZipPathContainsInvalidCharacters(string path)
		{
			throw null;
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x0002EC55 File Offset: 0x0002CE55
		[global::Cpp2ILInjected.Token(Token = "0x6005451")]
		[global::Cpp2ILInjected.Address(RVA = "0x94894C", Offset = "0x94894C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContentSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string CleanZipPath(string path)
		{
			throw null;
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x0002EC58 File Offset: 0x0002CE58
		[global::Cpp2ILInjected.Token(Token = "0x6005452")]
		[global::Cpp2ILInjected.Address(RVA = "0x9490D4", Offset = "0x9490D4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x0002EC5B File Offset: 0x0002CE5B
		[global::Cpp2ILInjected.Token(Token = "0x6005453")]
		[global::Cpp2ILInjected.Address(RVA = "0x949144", Offset = "0x949144", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x0002EC5E File Offset: 0x0002CE5E
		[global::Cpp2ILInjected.Token(Token = "0x6005454")]
		[global::Cpp2ILInjected.Address(RVA = "0x949158", Offset = "0x949158", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "Reject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IRejectionReason)
		}, ReturnType = typeof(void))]
		public void RejectAsset(string assetName, IRejectionReason reason)
		{
			throw null;
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x0002EC61 File Offset: 0x0002CE61
		[global::Cpp2ILInjected.Token(Token = "0x6005455")]
		[global::Cpp2ILInjected.Address(RVA = "0x949160", Offset = "0x949160", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "Clear", ReturnType = typeof(void))]
		public void ClearRejections()
		{
			throw null;
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x0002EC64 File Offset: 0x0002CE64
		[global::Cpp2ILInjected.Token(Token = "0x6005456")]
		[global::Cpp2ILInjected.Address(RVA = "0x949168", Offset = "0x949168", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RejectedAssetCollection), Member = "TryGetRejections", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(bool))]
		public bool TryGetRejections(List<string> rejectionReasons)
		{
			throw null;
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x0002EC67 File Offset: 0x0002CE67
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6005457")]
		[global::Cpp2ILInjected.Address(RVA = "0x949170", Offset = "0x949170", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		private bool <BuildExtensionFreeEntryList>b__14_0(ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x0400737E RID: 29566
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008D20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IContentValidator <ContentValidator>k__BackingField;

		// Token: 0x0400737F RID: 29567
		[global::Cpp2ILInjected.Token(Token = "0x4008D21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly ZipFile _zipFile;

		// Token: 0x04007380 RID: 29568
		[global::Cpp2ILInjected.Token(Token = "0x4008D22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<string, ZipEntry> _entries;

		// Token: 0x04007381 RID: 29569
		[global::Cpp2ILInjected.Token(Token = "0x4008D23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string _basePath;

		// Token: 0x04007382 RID: 29570
		[global::Cpp2ILInjected.Token(Token = "0x4008D24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _isDisposed;

		// Token: 0x04007383 RID: 29571
		[global::Cpp2ILInjected.Token(Token = "0x4008D25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly RejectedAssetCollection _rejections;
	}
}
