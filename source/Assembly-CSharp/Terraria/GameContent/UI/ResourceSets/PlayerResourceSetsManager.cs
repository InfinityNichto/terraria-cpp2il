using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using ReLogic.Content;
using Terraria.IO;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x020006AE RID: 1710
	[global::Cpp2ILInjected.Token(Token = "0x2000A84")]
	public class PlayerResourceSetsManager
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x0002E0E5 File Offset: 0x0002C2E5
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x0002E0E8 File Offset: 0x0002C2E8
		[global::Cpp2ILInjected.Token(Token = "0x170008B3")]
		public string ActiveSetKeyName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F95")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FF544", Offset = "0x8FF544", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6004F96")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FF54C", Offset = "0x8FF54C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x0002E0EB File Offset: 0x0002C2EB
		[global::Cpp2ILInjected.Token(Token = "0x6004F97")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF554", Offset = "0x8FF554", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnLoad", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "add_OnSave", MemberParameters = new object[] { typeof(Action<Preferences>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void BindTo(Preferences preferences)
		{
			throw null;
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x0002E0EE File Offset: 0x0002C2EE
		[global::Cpp2ILInjected.Token(Token = "0x6004F98")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF624", Offset = "0x8FF624", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerResourceSetsManager), Member = "SetActive", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Configuration_OnLoad(Preferences obj)
		{
			throw null;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x0002E0F1 File Offset: 0x0002C2F1
		[global::Cpp2ILInjected.Token(Token = "0x6004F99")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF6E4", Offset = "0x8FF6E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Configuration_OnSave(Preferences obj)
		{
			throw null;
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x0002E0F4 File Offset: 0x0002C2F4
		[global::Cpp2ILInjected.Token(Token = "0x6004F9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF740", Offset = "0x8FF740", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public void LoadContent(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x0002E0F7 File Offset: 0x0002C2F7
		[global::Cpp2ILInjected.Token(Token = "0x6004F9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF6DC", Offset = "0x8FF6DC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerResourceSetsManager), Member = "SetActive", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public void SetActiveFromLoadedConfigKey()
		{
			throw null;
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x0002E0FA File Offset: 0x0002C2FA
		[global::Cpp2ILInjected.Token(Token = "0x6004F9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FF9EC", Offset = "0x8FF9EC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "Configuration_OnLoad", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "SetActiveFromLoadedConfigKey", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(KeyValuePair<object, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerResourceSetsManager), Member = "SetActiveFrame", MemberParameters = new object[] { typeof(IPlayerResourcesDisplaySet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void SetActive(string name)
		{
			throw null;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x0002E0FD File Offset: 0x0002C2FD
		[global::Cpp2ILInjected.Token(Token = "0x6004F9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFB20", Offset = "0x8FFB20", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "SetActive", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerResourceSetsManager), Member = "CycleResourceSet", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void SetActiveFrame(IPlayerResourcesDisplaySet set)
		{
			throw null;
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x0002E100 File Offset: 0x0002C300
		[global::Cpp2ILInjected.Token(Token = "0x6004F9E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFC2C", Offset = "0x8FFC2C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void TryToHoverOverResources()
		{
			throw null;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x0002E103 File Offset: 0x0002C303
		[global::Cpp2ILInjected.Token(Token = "0x6004F9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFCC8", Offset = "0x8FFCC8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Draw()
		{
			throw null;
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x0002E106 File Offset: 0x0002C306
		[global::Cpp2ILInjected.Token(Token = "0x6004FA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFD60", Offset = "0x8FFD60", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Last", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerResourceSetsManager), Member = "SetActiveFrame", MemberParameters = new object[] { typeof(IPlayerResourcesDisplaySet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void CycleResourceSet()
		{
			throw null;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x0002E109 File Offset: 0x0002C309
		[global::Cpp2ILInjected.Token(Token = "0x6004FA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFE9C", Offset = "0x8FFE9C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public PlayerResourceSetsManager()
		{
			throw null;
		}

		// Token: 0x04006F60 RID: 28512
		[global::Cpp2ILInjected.Token(Token = "0x4008881")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<string, IPlayerResourcesDisplaySet> _sets;

		// Token: 0x04006F61 RID: 28513
		[global::Cpp2ILInjected.Token(Token = "0x4008882")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IPlayerResourcesDisplaySet _activeSet;

		// Token: 0x04006F62 RID: 28514
		[global::Cpp2ILInjected.Token(Token = "0x4008883")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _activeSetConfigKey;

		// Token: 0x04006F63 RID: 28515
		[global::Cpp2ILInjected.Token(Token = "0x4008884")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _loadedContent;

		// Token: 0x04006F64 RID: 28516
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4008885")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string <ActiveSetKeyName>k__BackingField;

		// Token: 0x02000AB2 RID: 2738
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A85")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06005259 RID: 21081 RVA: 0x00030869 File Offset: 0x0002EA69
			[global::Cpp2ILInjected.Token(Token = "0x6004FA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FFB18", Offset = "0x8FFB18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x0600525A RID: 21082 RVA: 0x0003086C File Offset: 0x0002EA6C
			[global::Cpp2ILInjected.Token(Token = "0x6004FA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FFF18", Offset = "0x8FFF18", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <SetActive>b__0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				throw null;
			}

			// Token: 0x04008F2D RID: 36653
			[global::Cpp2ILInjected.Token(Token = "0x4008886")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string name;
		}

		// Token: 0x02000AB3 RID: 2739
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A86")]
		private sealed class <>c__DisplayClass17_0
		{
			// Token: 0x0600525B RID: 21083 RVA: 0x0003086F File Offset: 0x0002EA6F
			[global::Cpp2ILInjected.Token(Token = "0x6004FA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FFE94", Offset = "0x8FFE94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass17_0()
			{
				throw null;
			}

			// Token: 0x0600525C RID: 21084 RVA: 0x00030872 File Offset: 0x0002EA72
			[global::Cpp2ILInjected.Token(Token = "0x6004FA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x8FFF60", Offset = "0x8FFF60", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <CycleResourceSet>b__0(IPlayerResourcesDisplaySet frame)
			{
				throw null;
			}

			// Token: 0x04008F2E RID: 36654
			[global::Cpp2ILInjected.Token(Token = "0x4008887")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public PlayerResourceSetsManager <>4__this;

			// Token: 0x04008F2F RID: 36655
			[global::Cpp2ILInjected.Token(Token = "0x4008888")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public IPlayerResourcesDisplaySet lastFrame;
		}
	}
}
