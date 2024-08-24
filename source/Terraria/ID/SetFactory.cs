using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent;
using Terraria.GameContent.Prefixes;

namespace Terraria.ID
{
	// Token: 0x02000402 RID: 1026
	[global::Cpp2ILInjected.Token(Token = "0x20005EE")]
	public class SetFactory
	{
		// Token: 0x06003075 RID: 12405 RVA: 0x0002AAA9 File Offset: 0x00028CA9
		[global::Cpp2ILInjected.Token(Token = "0x600357E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C2800", Offset = "0x13C2800", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public SetFactory(int size)
		{
			throw null;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0002AAAC File Offset: 0x00028CAC
		[global::Cpp2ILInjected.Token(Token = "0x600357F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CF5A8", Offset = "0x13CF5A8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected bool[] GetBoolBuffer()
		{
			throw null;
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x0002AAAF File Offset: 0x00028CAF
		[global::Cpp2ILInjected.Token(Token = "0x6003580")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CF6DC", Offset = "0x13CF6DC", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected int[] GetIntBuffer()
		{
			throw null;
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x0002AAB2 File Offset: 0x00028CB2
		[global::Cpp2ILInjected.Token(Token = "0x6003581")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CF810", Offset = "0x13CF810", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SetFactory), Member = "CreateUshortSet", MemberParameters = new object[]
		{
			typeof(ushort),
			typeof(ushort[])
		}, ReturnType = typeof(ushort[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected ushort[] GetUshortBuffer()
		{
			throw null;
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x0002AAB5 File Offset: 0x00028CB5
		[global::Cpp2ILInjected.Token(Token = "0x6003582")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CF944", Offset = "0x13CF944", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SetFactory), Member = "CreateFloatSet", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float[])
		}, ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Dequeue", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected float[] GetFloatBuffer()
		{
			throw null;
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		[global::Cpp2ILInjected.Token(Token = "0x6003583")]
		[global::Cpp2ILInjected.Address(RVA = "0x159CF10", Offset = "0x159CF10", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Queue<>), Member = "Enqueue", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Recycle<T>(T[] buffer)
		{
			throw null;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x0002AABB File Offset: 0x00028CBB
		[global::Cpp2ILInjected.Token(Token = "0x6003584")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C29D8", Offset = "0x13C29D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorIDs.Body.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorIDs.Legs.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BuffID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileID.Sets.Conversion), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileID.Sets.ForAdvancedCollision), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallID.Sets.Conversion), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChildSafety), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrefixLegacy.ItemSets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 123)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateBoolSet", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int[])
		}, ReturnType = typeof(bool[]))]
		public bool[] CreateBoolSet(params int[] types)
		{
			throw null;
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x0002AABE File Offset: 0x00028CBE
		[global::Cpp2ILInjected.Token(Token = "0x6003585")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CF364", Offset = "0x13CF364", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 183)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "GetBoolBuffer", ReturnType = typeof(bool[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool[] CreateBoolSet(bool defaultState, params int[] types)
		{
			throw null;
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x0002AAC1 File Offset: 0x00028CC1
		[global::Cpp2ILInjected.Token(Token = "0x6003586")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFA78", Offset = "0x13CFA78", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(int[]))]
		public int[] CreateIntSet(params int[] types)
		{
			throw null;
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0002AAC4 File Offset: 0x00028CC4
		[global::Cpp2ILInjected.Token(Token = "0x6003587")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C7D0C", Offset = "0x13C7D0C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControllerInputState), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorIDs.Head.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorIDs.Body.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorIDs.Shoe.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorIDs.Face.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GoreID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerVariantID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SetFactory), Member = "CreateIntSet", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 56)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "GetIntBuffer", ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int[] CreateIntSet(int defaultState, params int[] inputs)
		{
			throw null;
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x0002AAC7 File Offset: 0x00028CC7
		[global::Cpp2ILInjected.Token(Token = "0x6003588")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CFA84", Offset = "0x13CFA84", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "GetUshortBuffer", ReturnType = typeof(ushort[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ushort[] CreateUshortSet(ushort defaultState, params ushort[] inputs)
		{
			throw null;
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x0002AACA File Offset: 0x00028CCA
		[global::Cpp2ILInjected.Token(Token = "0x6003589")]
		[global::Cpp2ILInjected.Address(RVA = "0x13CF3E0", Offset = "0x13CF3E0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetFactory), Member = "GetFloatBuffer", ReturnType = typeof(float[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public float[] CreateFloatSet(float defaultState, params float[] inputs)
		{
			throw null;
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x0002AACD File Offset: 0x00028CCD
		[global::Cpp2ILInjected.Token(Token = "0x600358A")]
		[global::Cpp2ILInjected.Address(RVA = "0x159B238", Offset = "0x159B238", Length = "0x4D8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ItemID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ProjectileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileID.Sets), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public T[] CreateCustomSet<T>(T defaultState, params object[] inputs)
		{
			throw null;
		}

		// Token: 0x04005A73 RID: 23155
		[global::Cpp2ILInjected.Token(Token = "0x4006DB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected int _size;

		// Token: 0x04005A74 RID: 23156
		[global::Cpp2ILInjected.Token(Token = "0x4006DB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Queue<int[]> _intBufferCache;

		// Token: 0x04005A75 RID: 23157
		[global::Cpp2ILInjected.Token(Token = "0x4006DB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Queue<ushort[]> _ushortBufferCache;

		// Token: 0x04005A76 RID: 23158
		[global::Cpp2ILInjected.Token(Token = "0x4006DB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Queue<bool[]> _boolBufferCache;

		// Token: 0x04005A77 RID: 23159
		[global::Cpp2ILInjected.Token(Token = "0x4006DB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly Queue<float[]> _floatBufferCache;

		// Token: 0x04005A78 RID: 23160
		[global::Cpp2ILInjected.Token(Token = "0x4006DB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private object _queueLock;
	}
}
