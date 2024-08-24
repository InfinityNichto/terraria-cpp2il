using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using ReLogic.Content.Sources;
using Terraria.Initializers;

namespace ReLogic.Content
{
	// Token: 0x02000742 RID: 1858
	[global::Cpp2ILInjected.Token(Token = "0x2000B42")]
	public class AssetRepository : IAssetRepository, IDisposable
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x0600472D RID: 18221 RVA: 0x0002EB83 File Offset: 0x0002CD83
		[global::Cpp2ILInjected.Token(Token = "0x17000915")]
		public int PendingAssets
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x94627C", Offset = "0x94627C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600472E RID: 18222 RVA: 0x0002EB86 File Offset: 0x0002CD86
		// (set) Token: 0x0600472F RID: 18223 RVA: 0x0002EB89 File Offset: 0x0002CD89
		[global::Cpp2ILInjected.Token(Token = "0x17000916")]
		public int TotalAssets
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x9462BC", Offset = "0x9462BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x9462C4", Offset = "0x9462C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		// (set) Token: 0x06004731 RID: 18225 RVA: 0x0002EB8F File Offset: 0x0002CD8F
		[global::Cpp2ILInjected.Token(Token = "0x17000917")]
		public int LoadedAssets
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x9462CC", Offset = "0x9462CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60053EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x9462D4", Offset = "0x9462D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06004732 RID: 18226 RVA: 0x0002EB92 File Offset: 0x0002CD92
		[global::Cpp2ILInjected.Token(Token = "0x17000918")]
		public bool IsAsyncLoadingEnabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x9462DC", Offset = "0x9462DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0002EB95 File Offset: 0x0002CD95
		[global::Cpp2ILInjected.Token(Token = "0x60053EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x9462E4", Offset = "0x9462E4", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "CreateAssetServices", MemberParameters = new object[] { typeof(GameServiceContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader)
		{
			throw null;
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0002EB98 File Offset: 0x0002CD98
		[global::Cpp2ILInjected.Token(Token = "0x60053ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x94645C", Offset = "0x94645C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal AssetRepository(IAssetLoader syncLoader, AsyncAssetLoader asyncLoader, bool useAsync)
		{
			throw null;
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0002EB9B File Offset: 0x0002CD9B
		[global::Cpp2ILInjected.Token(Token = "0x60053EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9465D4", Offset = "0x9465D4", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "FromMilliseconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(TimeSpan),
			typeof(TimeSpan)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void ProcessAsyncLoad()
		{
			throw null;
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0002EB9E File Offset: 0x0002CD9E
		[global::Cpp2ILInjected.Token(Token = "0x60053EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x9467BC", Offset = "0x9467BC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncAssetLoader), Member = "TransferCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = "ReloadAssetsIfSourceChanged", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void SetSources(IEnumerable<IContentSource> sources, AssetRequestMode mode = AssetRequestMode.ImmediateLoad)
		{
			throw null;
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0002EBA1 File Offset: 0x0002CDA1
		[global::Cpp2ILInjected.Token(Token = "0x60053F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1571E30", Offset = "0x1571E30", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetPathHelper), Member = "CleanPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public Asset<T> Request<T>(string assetName, AssetRequestMode mode = AssetRequestMode.ImmediateLoad) where T : class
		{
			throw null;
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
		[global::Cpp2ILInjected.Token(Token = "0x60053F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x946F58", Offset = "0x946F58", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = "ThrowIfDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncAssetLoader), Member = "TransferCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void TransferCompletedAssets()
		{
			throw null;
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0002EBA7 File Offset: 0x0002CDA7
		[global::Cpp2ILInjected.Token(Token = "0x60053F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x946A24", Offset = "0x946A24", Length = "0x534")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "SetSources", MemberParameters = new object[]
		{
			typeof(IEnumerable<IContentSource>),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = "FindSourceForAsset", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IContentSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = "ForceReloadAsset", MemberParameters = new object[]
		{
			typeof(IAsset),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private void ReloadAssetsIfSourceChanged(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0002EBAA File Offset: 0x0002CDAA
		[global::Cpp2ILInjected.Token(Token = "0x60053F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1571DB4", Offset = "0x1571DB4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void LoadAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
		{
			throw null;
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x0002EBAD File Offset: 0x0002CDAD
		[global::Cpp2ILInjected.Token(Token = "0x60053F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1572038", Offset = "0x1572038", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void TryLoadingAsset<T>(Asset<T> asset, AssetRequestMode mode) where T : class
		{
			throw null;
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x0002EBB0 File Offset: 0x0002CDB0
		[global::Cpp2ILInjected.Token(Token = "0x60053F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x947120", Offset = "0x947120", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "ReloadAssetsIfSourceChanged", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ForceReloadAsset(IAsset asset, AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x0002EBB3 File Offset: 0x0002CDB3
		[global::Cpp2ILInjected.Token(Token = "0x60053F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1571C4C", Offset = "0x1571C4C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object, Int32Enum>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void EnsureReloadActionExistsForType<T>() where T : class
		{
			throw null;
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x0002EBB6 File Offset: 0x0002CDB6
		[global::Cpp2ILInjected.Token(Token = "0x60053F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1571D28", Offset = "0x1571D28", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ForceReloadAsset<T>(IAsset asset, AssetRequestMode mode) where T : class
		{
			throw null;
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x0002EBB9 File Offset: 0x0002CDB9
		[global::Cpp2ILInjected.Token(Token = "0x60053F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x94701C", Offset = "0x94701C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "ReloadAssetsIfSourceChanged", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoadException), Member = "FromMissingAsset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(AssetLoadException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private IContentSource FindSourceForAsset(string assetName)
		{
			throw null;
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x0002EBBC File Offset: 0x0002CDBC
		[global::Cpp2ILInjected.Token(Token = "0x60053F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x9468F0", Offset = "0x9468F0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "SetSources", MemberParameters = new object[]
		{
			typeof(IEnumerable<IContentSource>),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "Request", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetRepository), Member = "TransferCompletedAssets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ThrowIfDisposed()
		{
			throw null;
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x0002EBBF File Offset: 0x0002CDBF
		[global::Cpp2ILInjected.Token(Token = "0x60053FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x9471C0", Offset = "0x9471C0", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x0002EBC2 File Offset: 0x0002CDC2
		[global::Cpp2ILInjected.Token(Token = "0x60053FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x94737C", Offset = "0x94737C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400735A RID: 29530
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <TotalAssets>k__BackingField;

		// Token: 0x0400735B RID: 29531
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <LoadedAssets>k__BackingField;

		// Token: 0x0400735C RID: 29532
		[global::Cpp2ILInjected.Token(Token = "0x4008CFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, IAsset> _assets;

		// Token: 0x0400735D RID: 29533
		[global::Cpp2ILInjected.Token(Token = "0x4008CFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IEnumerable<IContentSource> _sources;

		// Token: 0x0400735E RID: 29534
		[global::Cpp2ILInjected.Token(Token = "0x4008CFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Type, Action<IAsset, AssetRequestMode>> _typeSpecificReloadActions;

		// Token: 0x0400735F RID: 29535
		[global::Cpp2ILInjected.Token(Token = "0x4008CFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly AsyncAssetLoader _asyncLoader;

		// Token: 0x04007360 RID: 29536
		[global::Cpp2ILInjected.Token(Token = "0x4008CFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly IAssetLoader _loader;

		// Token: 0x04007361 RID: 29537
		[global::Cpp2ILInjected.Token(Token = "0x4008D00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private List<IAsset> _queuedAssets;

		// Token: 0x04007362 RID: 29538
		[global::Cpp2ILInjected.Token(Token = "0x4008D01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly object _requestLock;

		// Token: 0x04007363 RID: 29539
		[global::Cpp2ILInjected.Token(Token = "0x4008D02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _isDisposed;

		// Token: 0x02000ADC RID: 2780
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B43")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060052E5 RID: 21221 RVA: 0x000309F5 File Offset: 0x0002EBF5
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60053FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x94738C", Offset = "0x94738C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060052E6 RID: 21222 RVA: 0x000309F8 File Offset: 0x0002EBF8
			[global::Cpp2ILInjected.Token(Token = "0x60053FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x9473E8", Offset = "0x9473E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060052E7 RID: 21223 RVA: 0x000309FB File Offset: 0x0002EBFB
			[global::Cpp2ILInjected.Token(Token = "0x60053FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x9473F0", Offset = "0x9473F0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <ReloadAssetsIfSourceChanged>b__25_0(IAsset asset)
			{
				throw null;
			}

			// Token: 0x04008FAB RID: 36779
			[global::Cpp2ILInjected.Token(Token = "0x4008D03")]
			public static readonly AssetRepository.<>c <>9;

			// Token: 0x04008FAC RID: 36780
			[global::Cpp2ILInjected.Token(Token = "0x4008D04")]
			public static Func<IAsset, bool> <>9__25_0;
		}

		// Token: 0x02000ADD RID: 2781
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B44")]
		private sealed class <>c__DisplayClass31_0
		{
			// Token: 0x060052E8 RID: 21224 RVA: 0x000309FE File Offset: 0x0002EBFE
			[global::Cpp2ILInjected.Token(Token = "0x60053FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x9471B8", Offset = "0x9471B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass31_0()
			{
				throw null;
			}

			// Token: 0x060052E9 RID: 21225 RVA: 0x00030A01 File Offset: 0x0002EC01
			[global::Cpp2ILInjected.Token(Token = "0x6005400")]
			[global::Cpp2ILInjected.Address(RVA = "0x947488", Offset = "0x947488", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <FindSourceForAsset>b__0(IContentSource source)
			{
				throw null;
			}

			// Token: 0x04008FAD RID: 36781
			[global::Cpp2ILInjected.Token(Token = "0x4008D05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string assetName;
		}
	}
}
