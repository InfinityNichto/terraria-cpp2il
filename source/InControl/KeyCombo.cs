using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x0200000C RID: 12
	[global::Cpp2ILInjected.Token(Token = "0x200000C")]
	public struct KeyCombo
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00002138 File Offset: 0x00000338
		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A770", Offset = "0x197A770", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyCombo), Member = "With", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(KeyCombo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public KeyCombo(params Key[] keys)
		{
			throw null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000213B File Offset: 0x0000033B
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B388", Offset = "0x197B388", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddIncludeInt(int key)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000213E File Offset: 0x0000033E
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B3BC", Offset = "0x197B3BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int GetIncludeInt(int index)
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002141 File Offset: 0x00000341
		[Obsolete("Use KeyCombo.AddInclude instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B3D0", Offset = "0x197B3D0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Add(Key key)
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002144 File Offset: 0x00000344
		[Obsolete("Use KeyCombo.GetInclude instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B404", Offset = "0x197B404", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Key Get(int index)
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002147 File Offset: 0x00000347
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B354", Offset = "0x197B354", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddInclude(Key key)
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000214A File Offset: 0x0000034A
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B408", Offset = "0x197B408", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Key GetInclude(int index)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000214D File Offset: 0x0000034D
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B4DC", Offset = "0x197B4DC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddExcludeInt(int key)
		{
			throw null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002150 File Offset: 0x00000350
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B510", Offset = "0x197B510", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int GetExcludeInt(int index)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002153 File Offset: 0x00000353
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B524", Offset = "0x197B524", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void AddExclude(Key key)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002156 File Offset: 0x00000356
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B558", Offset = "0x197B558", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public Key GetExclude(int index)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002159 File Offset: 0x00000359
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B62C", Offset = "0x197B62C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = ".ctor", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
		public static KeyCombo With(params Key[] keys)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000215C File Offset: 0x0000035C
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B640", Offset = "0x197B640", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public KeyCombo AndNot(params Key[] keys)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000215F File Offset: 0x0000035F
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AFF4", Offset = "0x197AFF4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002162 File Offset: 0x00000362
		[Obsolete("Use KeyCombo.IncludeCount instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000053")]
			[global::Cpp2ILInjected.Address(RVA = "0x197B6A0", Offset = "0x197B6A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002165 File Offset: 0x00000365
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public int IncludeCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000054")]
			[global::Cpp2ILInjected.Address(RVA = "0x197B6A8", Offset = "0x197B6A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002168 File Offset: 0x00000368
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public int ExcludeCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000055")]
			[global::Cpp2ILInjected.Address(RVA = "0x197B6B0", Offset = "0x197B6B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000216B File Offset: 0x0000036B
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public bool IsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000056")]
			[global::Cpp2ILInjected.Address(RVA = "0x197A82C", Offset = "0x197A82C", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBindingSource), Member = "GetState", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBindingSourceListener), Member = "Listen", MemberParameters = new object[]
			{
				typeof(BindingListenOptions),
				typeof(InputDevice)
			}, ReturnType = typeof(BindingSource))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyInfo), Member = "get_IsPressed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000216E File Offset: 0x0000036E
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B194", Offset = "0x197B194", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBindingSourceListener), Member = "Listen", MemberParameters = new object[]
		{
			typeof(BindingListenOptions),
			typeof(InputDevice)
		}, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "get_AnyKeyIsPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyInfo), Member = "get_IsPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static KeyCombo Detect(bool modifiersAsKeys)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002171 File Offset: 0x00000371
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x197A99C", Offset = "0x197A99C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBindingSource), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ulong, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyInfo), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002174 File Offset: 0x00000374
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AC3C", Offset = "0x197AC3C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(KeyCombo a, KeyCombo b)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002177 File Offset: 0x00000377
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B768", Offset = "0x197B768", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(KeyCombo a, KeyCombo b)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000217A File Offset: 0x0000037A
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B794", Offset = "0x197B794", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000217D File Offset: 0x0000037D
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AD90", Offset = "0x197AD90", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002180 File Offset: 0x00000380
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AE14", Offset = "0x197AE14", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBindingSource), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002183 File Offset: 0x00000383
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197AF64", Offset = "0x197AF64", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyBindingSource), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002186 File Offset: 0x00000386
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B884", Offset = "0x197B884", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<ulong, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static KeyCombo()
		{
			throw null;
		}

		// Token: 0x040000A8 RID: 168
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int includeSize;

		// Token: 0x040000A9 RID: 169
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private ulong includeData;

		// Token: 0x040000AA RID: 170
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int excludeSize;

		// Token: 0x040000AB RID: 171
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ulong excludeData;

		// Token: 0x040000AC RID: 172
		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		private static Dictionary<ulong, string> cachedStrings;
	}
}
