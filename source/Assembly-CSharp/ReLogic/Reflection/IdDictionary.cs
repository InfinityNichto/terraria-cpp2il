using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.LootSimulation;
using Terraria.GameContent.Metadata;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Initializers;

namespace ReLogic.Reflection
{
	// Token: 0x02000720 RID: 1824
	[global::Cpp2ILInjected.Token(Token = "0x2000B1C")]
	public class IdDictionary
	{
		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06004683 RID: 18051 RVA: 0x0002E9E8 File Offset: 0x0002CBE8
		[global::Cpp2ILInjected.Token(Token = "0x170008F7")]
		public IEnumerable<string> Names
		{
			[global::Cpp2ILInjected.Token(Token = "0x600532E")]
			[global::Cpp2ILInjected.Address(RVA = "0x942304", Offset = "0x942304", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x0002E9EB File Offset: 0x0002CBEB
		[global::Cpp2ILInjected.Token(Token = "0x600532F")]
		[global::Cpp2ILInjected.Address(RVA = "0x94234C", Offset = "0x94234C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdDictionary), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IdDictionary(int count)
		{
			throw null;
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x0002E9EE File Offset: 0x0002CBEE
		[global::Cpp2ILInjected.Token(Token = "0x6005330")]
		[global::Cpp2ILInjected.Address(RVA = "0x9423D4", Offset = "0x9423D4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryGetName(int id, out string name)
		{
			throw null;
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x0002E9F1 File Offset: 0x0002CBF1
		[global::Cpp2ILInjected.Token(Token = "0x6005331")]
		[global::Cpp2ILInjected.Address(RVA = "0x942434", Offset = "0x942434", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativeItemSacrificesCatalog), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool TryGetId(string name, out int id)
		{
			throw null;
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x0002E9F4 File Offset: 0x0002CBF4
		[global::Cpp2ILInjected.Token(Token = "0x6005332")]
		[global::Cpp2ILInjected.Address(RVA = "0x942494", Offset = "0x942494", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool ContainsName(string name)
		{
			throw null;
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x0002E9F7 File Offset: 0x0002CBF7
		[global::Cpp2ILInjected.Token(Token = "0x6005333")]
		[global::Cpp2ILInjected.Address(RVA = "0x9424EC", Offset = "0x9424EC", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool ContainsId(int id)
		{
			throw null;
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x0002E9FA File Offset: 0x0002CBFA
		[global::Cpp2ILInjected.Token(Token = "0x6005334")]
		[global::Cpp2ILInjected.Address(RVA = "0x942544", Offset = "0x942544", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIEmotesWindow), Member = "EmoteOver", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lang), Member = "AnglerQuestChat", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChatInitializer), Member = "PrepareAliases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentSamples), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "AddHappinessReportText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShopHelper), Member = "LoveNPCByTypeName", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LootSimulator), Member = "TryGettingLootFor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.LootSimulation.LootSimulationItemCounter.<>c__DisplayClass8_0", Member = "<PrintCollectedItems>b__3", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EmoteButton), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string GetName(int id)
		{
			throw null;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x0002E9FD File Offset: 0x0002CBFD
		[global::Cpp2ILInjected.Token(Token = "0x6005335")]
		[global::Cpp2ILInjected.Address(RVA = "0x94259C", Offset = "0x94259C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileMaterials), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int GetId(string name)
		{
			throw null;
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x0002EA00 File Offset: 0x0002CC00
		[global::Cpp2ILInjected.Token(Token = "0x6005336")]
		[global::Cpp2ILInjected.Address(RVA = "0x9425F4", Offset = "0x9425F4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Add(string name, int id)
		{
			throw null;
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x0002EA03 File Offset: 0x0002CC03
		[global::Cpp2ILInjected.Token(Token = "0x6005337")]
		[global::Cpp2ILInjected.Address(RVA = "0x942684", Offset = "0x942684", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Remove(string name)
		{
			throw null;
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x0002EA06 File Offset: 0x0002CC06
		[global::Cpp2ILInjected.Token(Token = "0x6005338")]
		[global::Cpp2ILInjected.Address(RVA = "0x94272C", Offset = "0x94272C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, object>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Remove(int id)
		{
			throw null;
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x0002EA09 File Offset: 0x0002CC09
		[global::Cpp2ILInjected.Token(Token = "0x6005339")]
		[global::Cpp2ILInjected.Address(RVA = "0x9427D4", Offset = "0x9427D4", Length = "0x430")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IdDictionary), Member = "Create", MemberTypeParameters = new object[] { "IdClass", "IdType" }, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetFields", ReturnType = typeof(FieldInfo[]))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(FieldInfo),
			typeof(FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "ToList", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = "System.Collections.Generic.List`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ForEach", MemberParameters = new object[] { typeof(Action<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, int>, int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, int>, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "ToDictionary", MemberTypeParameters = new object[] { "TSource", "TKey", "TElement" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>", "System.Func`2<TSource, TElement>" }, ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TElement>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static IdDictionary Create(Type idClass, Type idType)
		{
			throw null;
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x0002EA0C File Offset: 0x0002CC0C
		[global::Cpp2ILInjected.Token(Token = "0x600533A")]
		[global::Cpp2ILInjected.Address(RVA = "0x158B9FC", Offset = "0x158B9FC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IdDictionary), Member = "Create", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(IdDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IdDictionary Create<IdClass, IdType>()
		{
			throw null;
		}

		// Token: 0x04007174 RID: 29044
		[global::Cpp2ILInjected.Token(Token = "0x4008B09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, int> _nameToId;

		// Token: 0x04007175 RID: 29045
		[global::Cpp2ILInjected.Token(Token = "0x4008B0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Dictionary<int, string> _idToName;

		// Token: 0x04007176 RID: 29046
		[global::Cpp2ILInjected.Token(Token = "0x4008B0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly int Count;

		// Token: 0x02000AD8 RID: 2776
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B1D")]
		private sealed class <>c__DisplayClass15_0
		{
			// Token: 0x060052D7 RID: 21207 RVA: 0x000309CB File Offset: 0x0002EBCB
			[global::Cpp2ILInjected.Token(Token = "0x600533B")]
			[global::Cpp2ILInjected.Address(RVA = "0x942C04", Offset = "0x942C04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass15_0()
			{
				throw null;
			}

			// Token: 0x060052D8 RID: 21208 RVA: 0x000309CE File Offset: 0x0002EBCE
			[global::Cpp2ILInjected.Token(Token = "0x600533C")]
			[global::Cpp2ILInjected.Address(RVA = "0x942C0C", Offset = "0x942C0C", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal bool <Create>b__1(FieldInfo f)
			{
				throw null;
			}

			// Token: 0x060052D9 RID: 21209 RVA: 0x000309D1 File Offset: 0x0002EBD1
			[global::Cpp2ILInjected.Token(Token = "0x600533D")]
			[global::Cpp2ILInjected.Address(RVA = "0x942CB4", Offset = "0x942CB4", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <Create>b__2(FieldInfo field)
			{
				throw null;
			}

			// Token: 0x04008FA1 RID: 36769
			[global::Cpp2ILInjected.Token(Token = "0x4008B0C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Type idType;

			// Token: 0x04008FA2 RID: 36770
			[global::Cpp2ILInjected.Token(Token = "0x4008B0D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public IdDictionary dictionary;
		}

		// Token: 0x02000AD9 RID: 2777
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000B1E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060052DA RID: 21210 RVA: 0x000309D4 File Offset: 0x0002EBD4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600533E")]
			[global::Cpp2ILInjected.Address(RVA = "0x942D98", Offset = "0x942D98", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060052DB RID: 21211 RVA: 0x000309D7 File Offset: 0x0002EBD7
			[global::Cpp2ILInjected.Token(Token = "0x600533F")]
			[global::Cpp2ILInjected.Address(RVA = "0x942DF4", Offset = "0x942DF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060052DC RID: 21212 RVA: 0x000309DA File Offset: 0x0002EBDA
			[global::Cpp2ILInjected.Token(Token = "0x6005340")]
			[global::Cpp2ILInjected.Address(RVA = "0x942DFC", Offset = "0x942DFC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <Create>b__15_0(FieldInfo field)
			{
				throw null;
			}

			// Token: 0x060052DD RID: 21213 RVA: 0x000309DD File Offset: 0x0002EBDD
			[global::Cpp2ILInjected.Token(Token = "0x6005341")]
			[global::Cpp2ILInjected.Address(RVA = "0x942E54", Offset = "0x942E54", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal int <Create>b__15_3(KeyValuePair<string, int> kp)
			{
				throw null;
			}

			// Token: 0x060052DE RID: 21214 RVA: 0x000309E0 File Offset: 0x0002EBE0
			[global::Cpp2ILInjected.Token(Token = "0x6005342")]
			[global::Cpp2ILInjected.Address(RVA = "0x942E90", Offset = "0x942E90", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <Create>b__15_4(KeyValuePair<string, int> kp)
			{
				throw null;
			}

			// Token: 0x04008FA3 RID: 36771
			[global::Cpp2ILInjected.Token(Token = "0x4008B0E")]
			public static readonly IdDictionary.<>c <>9;

			// Token: 0x04008FA4 RID: 36772
			[global::Cpp2ILInjected.Token(Token = "0x4008B0F")]
			public static Func<FieldInfo, bool> <>9__15_0;

			// Token: 0x04008FA5 RID: 36773
			[global::Cpp2ILInjected.Token(Token = "0x4008B10")]
			public static Func<KeyValuePair<string, int>, int> <>9__15_3;

			// Token: 0x04008FA6 RID: 36774
			[global::Cpp2ILInjected.Token(Token = "0x4008B11")]
			public static Func<KeyValuePair<string, int>, string> <>9__15_4;
		}
	}
}
