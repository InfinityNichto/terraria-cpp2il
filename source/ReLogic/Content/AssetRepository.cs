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
	[global::Cpp2ILInjected.Token(Token = "0x2000B42")]
	public class AssetRepository : IAssetRepository, IDisposable
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60053FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x94737C", Offset = "0x94737C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int <TotalAssets>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008CFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <LoadedAssets>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4008CFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, IAsset> _assets;

		[global::Cpp2ILInjected.Token(Token = "0x4008CFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private IEnumerable<IContentSource> _sources;

		[global::Cpp2ILInjected.Token(Token = "0x4008CFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<Type, Action<IAsset, AssetRequestMode>> _typeSpecificReloadActions;

		[global::Cpp2ILInjected.Token(Token = "0x4008CFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly AsyncAssetLoader _asyncLoader;

		[global::Cpp2ILInjected.Token(Token = "0x4008CFF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly IAssetLoader _loader;

		[global::Cpp2ILInjected.Token(Token = "0x4008D00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private List<IAsset> _queuedAssets;

		[global::Cpp2ILInjected.Token(Token = "0x4008D01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly object _requestLock;

		[global::Cpp2ILInjected.Token(Token = "0x4008D02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _isDisposed;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B43")]
		[Serializable]
		private sealed class <>c
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x60053FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x9473E8", Offset = "0x9473E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60053FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x9473F0", Offset = "0x9473F0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <ReloadAssetsIfSourceChanged>b__25_0(IAsset asset)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008D03")]
			public static readonly AssetRepository.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x4008D04")]
			public static Func<IAsset, bool> <>9__25_0;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B44")]
		private sealed class <>c__DisplayClass31_0
		{
			[global::Cpp2ILInjected.Token(Token = "0x60053FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x9471B8", Offset = "0x9471B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass31_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6005400")]
			[global::Cpp2ILInjected.Address(RVA = "0x947488", Offset = "0x947488", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <FindSourceForAsset>b__0(IContentSource source)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4008D05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string assetName;
		}
	}
}
